using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using Shoes.AppForms;
using Shoes.AppModels;
using Shoes.AppService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes.AppControls
{
    public partial class OrderUserControl : UserControl
    {
        private Order _order;
        public OrderUserControl(Order order)
        {
            InitializeComponent();
            showData(order);
            _order = order;
            hideDeleteButton();
        }

        private void hideDeleteButton()
        {
            deleteProductButton.Visible = ContextManager.user.isAdmin();
        }

        private void showData(Order order)
        {
            orderIdlabel.Text = "ID: " + order.IdOrder.ToString();
            deliveryDateLabel.Text = string.Format("{0:dd.MM.yyyy}", order.DeliveryDate); ;
            orderDateLabel.Text = "Дата заказа:" + string.Format("{0:dd.MM.yyyy}", order.OrderDate);
            officeLabel.Text = "Адрес пункта выдачи: " + order.Office.Address;
            statusLabel.Text = "Статус заказа: " + order.Status.StatusName;
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            DialogResult toBeDeleted = MessageBox.Show("Удалить?", "Удалить?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (toBeDeleted == DialogResult.OK)
            {                
                try
                {
                    Program.context.Order.Remove(_order);
                    Program.context.SaveChanges();
                    MessageBox.Show("Удалено", "Удалено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((OrderForm)this.Parent.Parent.Parent.Parent).refreshOrders();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось удалить заказ.", 
                        "Не удалось удалить заказ.",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
