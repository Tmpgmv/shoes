using Shoes.AppService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes.AppForms
{
    public partial class OrderForm : ParentForm
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Shown(object sender, EventArgs e)
        {
            FormManager.prepareForm("Заказы");
        }
    }
}
