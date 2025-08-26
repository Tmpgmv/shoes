using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using Shoes.AppModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void showData(Order order)
        {
            orderIdlabel.Text = "ID: " + order.IdOrder.ToString();
            deliveryDateLabel.Text = string.Format("{0:dd.MM.yyyy}", order.DeliveryDate); ;
            orderDateLabel.Text = "Дата заказа:" + string.Format("{0:dd.MM.yyyy}", order.OrderDate);
            officeLabel.Text = "Адрес пункта выдачи: " + order.Office.Address;
            statusLabel.Text = "Статус заказа: " + order.Status.StatusName;
        }
    }
}
