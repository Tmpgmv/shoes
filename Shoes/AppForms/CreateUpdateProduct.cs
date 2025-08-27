using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using Shoes.AppModels;
using Shoes.AppService;
using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.WebRequestMethods;
using Shoes.AppModels;
using System.Diagnostics;

namespace Shoes.AppForms
{
    public partial class CreateUpdateProduct : ParentForm        
    {
        private Shoes.AppModels.Product _product;

        public CreateUpdateProduct()
        {
            InitializeComponent();            
            _product = new Shoes.AppModels.Product();
            Program.context.Product.Add(_product);
        }


        public CreateUpdateProduct(Shoes.AppModels.Product product)
        {
            InitializeComponent();
            _product = product;            
        }


        private void CreateUpdateProduct_Shown(object sender, EventArgs e)
        {
            FormManager.prepareForm("Добавить/редактировать товар", false);
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grablevskiy_mv_shoesDataSet);

        }

        private void CreateUpdateProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "grablevskiy_mv_shoesDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.grablevskiy_mv_shoesDataSet.Category);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "grablevskiy_mv_shoesDataSet.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.grablevskiy_mv_shoesDataSet.Manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "grablevskiy_mv_shoesDataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.grablevskiy_mv_shoesDataSet.Supplier);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "grablevskiy_mv_shoesDataSet.UnitOfMeasurement". При необходимости она может быть перемещена или удалена.
            this.unitOfMeasurementTableAdapter.Fill(this.grablevskiy_mv_shoesDataSet.UnitOfMeasurement);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "grablevskiy_mv_shoesDataSet.ProductName". При необходимости она может быть перемещена или удалена.
            this.productNameTableAdapter.Fill(this.grablevskiy_mv_shoesDataSet.ProductName);

            if (!_product.isNew())
            {
                productBindingSource.DataSource = _product;
            }
        }

        private void openFileDialogButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                openFileDialog.OpenFile();
                photoTextBox.Text = Path.GetFileName(openFileDialog.FileName);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Пожалуйста, исправьте ошибки в форме перед сохранением.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Additional validation for photo file:
            if (!isPhotoSelected())
            {
                MessageBox.Show("Пожалуйста, выберите файл изображения перед сохранением.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {

                string newFileName = saveImage();

                string fileName = newFileName == "" ? _product.Photo : newFileName;
                
                FillModelFields(fileName);

                DialogResult toBeSaved = MessageBox.Show("Сохранить?", "Запрос подтверждения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (toBeSaved == DialogResult.No)
                {
                    return;
                }

                try
                {
                    Program.context.SaveChanges();
                    MessageBox.Show("Данные сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FillModelFields(string fileName)
        {
            _product.Sku = skuTextBox.Text;
            _product.ProductNameId = (int)productNameIdComboBox.SelectedValue;
            _product.UnitOfMeasurementId = (int)unitOfMeasurementIdComboBox.SelectedValue;
            _product.Price = Math.Round(double.Parse(priceTextBox.Text), 2);
            _product.SupplierId = (int)supplierIdComboBox.SelectedValue;
            _product.ManufacturerId = (int)manufacturerIdComboBox.SelectedValue;
            _product.CategoryId = (int)categoryIdComboBox.SelectedValue;
            _product.Discount = double.Parse(discountTextBox.Text);
            _product.Amount = double.Parse(amountTextBox.Text);
            _product.Description = descriptionTextBox.Text;
            _product.Photo = fileName;
        }



        private string saveImage()
        {
            if (string.IsNullOrEmpty(openFileDialog.FileName)) {
                return "";
            }

            Image originalImage = Image.FromFile(openFileDialog.FileName);

            // Создаем уменьшенное изображение
            int newWidth = 300;
            int newHeight = 200;
            Bitmap resizedImage = new Bitmap(originalImage, newWidth, newHeight);

            // Генерируем имя файла
            string fileName = Guid.NewGuid().ToString().Substring(0, 8) + ".jpg"; // PKGH Длина имени файла без расширения - 8 символов.
            string savePath = FileManager.getImgPath(fileName);

            // Сохраняем изображение
            resizedImage.Save(savePath);

            // Освобождаем ресурсы
            originalImage.Dispose();
            resizedImage.Dispose();
            
            return fileName;
        }

        private void floatValidator(TextBox field, string fieldNameRu, System.ComponentModel.CancelEventArgs e) {
            float val;
            if (!float.TryParse(field.Text, out val) || val < 0)
            {
                e.Cancel = true; 
                MessageBox.Show(fieldNameRu + ": введите неотрицательное число с корректным десятичным разделителем.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                field.SelectAll();
            }
        }

        private void priceTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            floatValidator(priceTextBox, "Цена", e);
        }

        private void discountTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            floatValidator(discountTextBox, "Скидка", e);
        }

        private void amountTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int amount;
            if (!int.TryParse(amountTextBox.Text, out amount) || amount < 0)
            {
                e.Cancel = true; // Prevents focus from leaving the control
                MessageBox.Show("Количество: введите целое неотрицательное число.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                priceTextBox.SelectAll();
            }
        }

        private void descriptionTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (descriptionTextBox.Text.Length == 0)
            {
                e.Cancel = true; // Prevents focus from leaving the control
                MessageBox.Show("Введите описание");
                priceTextBox.SelectAll();
            }
        }

        

        private bool isPhotoSelected()
        {
            bool result = true;
            if (string.IsNullOrEmpty(photoTextBox.Text))
            {
                result = false;                 
            }

            return result;
        }
    }
}
