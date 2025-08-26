using Shoes.AppControls;
using Shoes.AppModels;
using Shoes.AppService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Windows.Forms;

namespace Shoes.AppForms
{
    public partial class ProductForm : ParentForm
    {
        private IQueryable<Product> products;
        public ProductForm()
        {
            InitializeComponent();
        }


        private void ProductForm_Load(object sender, EventArgs e)
        {
            fillSupplier();
        }

        private void fillSupplier()
        {
            List<Supplier> suppliers = Program.context.Supplier.OrderBy(s => s.SupplierName).ToList();
            Supplier supplier = new Supplier();
            supplier.SupplierName = "Все поставщики";
            suppliers.Insert(0, supplier);

            supplierBindingSource.DataSource = suppliers;
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

            bool fewerFirstInput = fewerFirst.Checked;

            int supplierId = getSupplierId();

            IQueryable<Product> tmpProducts = Program.context.Product;

            if (search.Text.Trim() != "")
            {
                tmpProducts = tmpProducts.Where(obj => DbFunctions.Like(obj.Sku, "%" + searchInput + "%")
                || DbFunctions.Like(obj.Description, "%" + searchInput + "%"));
            }

            if (fewerFirstInput)
            {
                tmpProducts = tmpProducts.OrderBy(p => p.Amount);
            }
            else
            {
                tmpProducts = tmpProducts.OrderByDescending(p => p.Amount);
            }

            if (supplierId > 0)
            {
                tmpProducts = tmpProducts.Where(p => p.SupplierId == supplierId);
            }

            return tmpProducts;
        }

        private int getSupplierId()
        {
            int id = 0;
            var selected = filterByManufacturer.SelectedItem;

            if (selected != null)
            {
                id = ((Shoes.AppModels.Supplier)selected).IdSupplier;
            }

            return id;
        }

        private void ProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void clearProducts()
        {
            flowLayoutPanel.Controls.Clear();
        }

        public void refreshProductList()
        {
            clearProducts();
            showProducts();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            refreshProductList();
        }

        private void filterByManufacturer_SelectedValueChanged(object sender, EventArgs e)
        {
            refreshProductList();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            refreshProductList();
        }

        private void ProductForm_Shown(object sender, EventArgs e)
        {
            hideAddProductButton();
            hideOrdersButton();
            refreshProductList();
            if (ContextManager.user.isGuest())
            {
                splitContainer.Panel1.Hide();
            }

            FormManager.prepareForm("Товары");
        }

        private void hideOrdersButton()
        {
            ordersButton.Visible = ContextManager.user.isAdmin() || ContextManager.user.isManager();
        }

        private void hideAddProductButton()
        {
            addProductButton.Visible = ContextManager.user.isAdmin();
        }




        private void addProductButton_Click(object sender, EventArgs e)
        {
            CreateUpdateProduct createUpdateProduct = new CreateUpdateProduct();
            DialogResult productSaved = createUpdateProduct.ShowDialog();

            if (productSaved == DialogResult.OK)
            {
                refreshProductList();
            }

        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            OrderForm orderForm = new OrderForm();
            orderForm.Show();
        }
    }
}
