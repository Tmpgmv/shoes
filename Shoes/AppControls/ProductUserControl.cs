using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shoes.AppModels;
using Shoes.AppConstants;
using System.IO;
using Shoes.AppService;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity.Infrastructure;
using Shoes.AppForms;

namespace Shoes.AppControls
{
    public partial class ProductUserControl : UserControl
    {
        private Product _product;

        public ProductUserControl(Product product)
        {
            InitializeComponent();
            showData(product);
            highlightGreatDiscount(product);
            highlightAbsent(product);
            this._product = product;
            hideDeleteButton();
        }

        private void hideDeleteButton()
        {
            deleteProductButton.Visible = ContextManager.user.isAdmin();
        }

        private void showData(Product product)
        {
            categoryName.Text = string.Format("{0} | {1}", product.Category.CategoryName, product.ProductName.ProductName1);
            discount.Text = String.Format("{0} %", product.Discount); 
            description.Text = String.Format("Описание товара: {0}", product.Description);
            amount.Text = String.Format("Количество на складе: {0}", product.Amount);
            supplier.Text = String.Format("Поставщик: {0}", product.Supplier.SupplierName);
            manufacturer.Text = String.Format("Производитель: {0}", product.Manufacturer.ManufacturerName);
            unitOfMeasurement.Text = String.Format("Единица измерения: {0}", product.UnitOfMeasurement.UnitOfMeasurementName);
            price.Text = getPrice(product);
            oldPrice.Text = getOldPrice(product);
            photo.Image = getImage(product);
        }

        private Image getImage(Product product)
        {
            
            Image img;
            try
            {
                using (Image tempImg = Image.FromFile(FileManager.getImgPath(product.Photo)))
                {
                    // PKGH Создать копию, чтобы не блокировать файл.
                    // Иначе его невозможно удалить программно.
                    img = new Bitmap(tempImg); 
                }
                
            } catch (FileNotFoundException ex) {                
                img = Image.FromFile(FileManager.getImgPath(FilePath.defaultPicture));
            }
            
            return img;
            
        }

        private string getOldPrice(Product product)
        {
            return product.Discount > 0? product.Price.ToString() : "";
        }

        private string getPrice(Product product)
        {
            double tmpPrice = product.Price;

            if (product.Discount > 0)
            {
                tmpPrice = product.Price * ((100 - product.Discount) / 100);
            }            

            return String.Format("Цена: {0}", tmpPrice);
        }

        public void highlightGreatDiscount(Product product)
        {
            if (product.Discount > 15)
            {
                this.BackColor = ColorTranslator.FromHtml(AppConstants.Color.greatDiscount);
            }
        }

        public void highlightAbsent(Product product) {
            // PKGH На всякий случай предусмотрим и отрицательное количество.
            if (product.Amount <= 0) { 
                this.BackColor = ColorTranslator.FromHtml(AppConstants.Color.attention);
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            DialogResult toBeDeleted = MessageBox.Show("Удалить?", "Удалить?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (toBeDeleted == DialogResult.OK) {
                
                Product product = Program.context.Product.Where(p => p.IdProduct == this._product.IdProduct).FirstOrDefault();
                try {
                    Program.context.Product.Remove(product);
                    Program.context.SaveChanges();
                    FileManager.deleteFile(product.Photo);
                    ((ProductForm)this.Parent.Parent.Parent.Parent.Parent).refreshProductList();
                } catch (DbUpdateException ex) {
                    MessageBox.Show("Товар заказан. Его нельзя удалить.", 
                        "Товар заказан. Его нельзя удалить.", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
            
        }

        private void control_Click(object sender, EventArgs e)
        {
            CreateUpdateProduct createUpdateProduct = new CreateUpdateProduct(_product);
            DialogResult productSaved = createUpdateProduct.ShowDialog();

            if (productSaved == DialogResult.OK) {
                ProductForm productForm = (ProductForm)this.Parent.Parent.Parent.Parent.Parent;
                productForm.refreshProductList();
            }
        }
    }
}
