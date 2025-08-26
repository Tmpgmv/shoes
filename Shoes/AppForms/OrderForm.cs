using Shoes.AppControls;
using Shoes.AppModels;
using Shoes.AppService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shoes.AppForms
{
    public partial class OrderForm : ParentForm
    {
        private IQueryable<Order> _orders;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Shown(object sender, EventArgs e)
        {
            FormManager.prepareForm("Заказы");
        }

        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContextManager.productForm.Show();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "grablevskiy_mv_shoesDataSet.Status". При необходимости она может быть перемещена или удалена.
            
            
            List<Shoes.AppModels.Status> statuses = Program.context.Status.OrderBy(s => s.StatusName).ToList();
            Shoes.AppModels.Status status = new Shoes.AppModels.Status();
            status.StatusName = "Все статусы";
            statuses.Insert(0, status);

            statusBindingSource.DataSource = statuses;

            refreshOrders();
        }

        private IQueryable<Order> getOrders()
        {
            string searchInput = search.Text.Trim();
            var param = new SqlParameter("@search", $"%{searchInput}%");

            bool asc = ascRadioButton.Checked;

            int statusId = getStatusId();

            IQueryable<Order> tmpOrders = Program.context.Order;

            if (searchInput != "")
            {
                List<int> ids = Program.context.Database.SqlQuery<int>(
                    "select OrderId from [OrderProduct] " +
                    "left join [Product] on [Product].IdProduct = [OrderProduct].ProductId " +
                    "where Description like @search or Sku like @search",
                    param
                ).ToList();

                tmpOrders = tmpOrders.Where(o => ids.Contains(o.IdOrder));
            }

            if (asc)
            {
                tmpOrders = tmpOrders.OrderBy(p => p.Office.Address);
            }
            else
            {
                tmpOrders = tmpOrders.OrderByDescending(p => p.Office.Address);
            }

            if (statusId > 0)
            {
                tmpOrders = tmpOrders.Where(p => p.StatusId == statusId);
            }

            return tmpOrders;
        }

        private int getStatusId()
        {
            int id = 0;
            var selected = statusComboBox.SelectedItem;

            if (selected != null)
            {
                id = ((Shoes.AppModels.Status)selected).IdStatus;
            }

            return id;
        }

        private void showOrders()
        {
            foreach (Order o in _orders.ToList())
            {
                flowLayoutPanel.Controls.Add(new OrderUserControl(o));
            }
        }

        private void clearOrders()
        {
            flowLayoutPanel.Controls.Clear();
        }

        private void refreshOrders() {
            clearOrders();            
            _orders = getOrders();
            showOrders();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            refreshOrders();
        }

        private void descRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            refreshOrders();
        }

        private void statusComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            refreshOrders();
        }
    }
}
