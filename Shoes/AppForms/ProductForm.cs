using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shoes.AppControls;
using Shoes.AppModels;

namespace Shoes.AppForms
{
    public partial class ProductForm : ParentForm
    {
        private IQueryable<Product> products;
        public ProductForm()
        {
            InitializeComponent();            
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grablevskiy_mv_shoesDataSet);

        }



        private void ProductForm_Load(object sender, EventArgs e)
        {
            fillManufacturer();
        }

        private void fillManufacturer()
        {
            List<Manufacturer> manufacturers = Program.context.Manufacturer.OrderBy(m => m.ManufacturerName).ToList();
            manufacturers.Insert(0, new Manufacturer());

            manufacturerBindingSource.DataSource = manufacturers;
        }

        private void showProducts()
        {
            products = getProducts();
            foreach (Product p in products.ToList())
            {
                flowLayoutPanel.Controls.Add(new ProductUserControl(p));
            }
        }

        private IQueryable<Product> getProducts()
        {
            string searchInput = search.Text;

            bool cheapFirstInput = cheapFirst.Checked;

            int manufacturerId = getManufacturerId();

            IQueryable<Product> tmpProducts = Program.context.Product;

            if (search.Text.Trim() != "") {
                tmpProducts = tmpProducts.Where(obj => DbFunctions.Like(obj.Sku, "%" + searchInput + "%")
                || DbFunctions.Like(obj.Description, "%" + searchInput + "%"));
            }

            if (cheapFirstInput)
            {
                tmpProducts = tmpProducts.OrderBy(p => p.Price);
            }
            else {
                tmpProducts = tmpProducts.OrderByDescending(p => p.Price);
            }

            if (manufacturerId > 0) {
                tmpProducts = tmpProducts.Where(p => p.ManufacturerId == manufacturerId);
            }

            return tmpProducts;
        }

        private int getManufacturerId()
        {
            int id = 0;
            var selected = filterByManufacturer.SelectedItem;
            
            if (selected != null) {
                id = ((Shoes.AppModels.Manufacturer)selected).IdManufacturer;
            }
            
            return id;
        }

        private void ProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void clearProducts() {
            flowLayoutPanel.Controls.Clear();
        }

        //private void showCheapFirst()
        //{
        //    clearProducts();            
        //    showProducts();
        //}

        //private void showExpensiveFirst()
        //{
        //    clearProducts();            
        //    showProducts();
        //}

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            clearProducts();
            showProducts();
        }

        private void filterByManufacturer_SelectedValueChanged(object sender, EventArgs e)
        {
            clearProducts();
            showProducts();

            //string selectedValue = ((ListControl)sender).SelectedValue.ToString();

            //int manufacturerId = -1;            

            //if (selectedValue != "" && manufacturerId != -1) {
            //    products = products.Where(p => p.ManufacturerId == manufacturerId);
            //    clearProducts();
            //    showProducts();
            //} else { 

            //}           
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            clearProducts();
            showProducts();
        }

        private void ProductForm_Shown(object sender, EventArgs e)
        {
            clearProducts();
            showProducts();
        }
    }
}
