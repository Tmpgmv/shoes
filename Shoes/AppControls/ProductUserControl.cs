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

namespace Shoes.AppControls
{
    public partial class ProductUserControl : UserControl
    {
        public ProductUserControl(Product product)
        {
            InitializeComponent();
            showData(product);
            highlightGreatDiscount(product);
            highlightAbsent(product);
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
            string imagePath = "";
            Image img;
            try
            {
                imagePath = System.IO.Path.Combine(Application.StartupPath, "img", product.Photo);
                img = Image.FromFile(imagePath);
            } catch (FileNotFoundException ex) {
                imagePath = System.IO.Path.Combine(Application.StartupPath, "img", "picture.png");
                img = Image.FromFile(imagePath);
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
    }
}
