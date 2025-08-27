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
    public partial class CreateUpdateOrder : ParentForm
    {
        private Shoes.AppModels.Order _order;
        
        public CreateUpdateOrder()
        {
            InitializeComponent();
            _order = new Shoes.AppModels.Order();
            Program.context.Order.Add(_order);
        }

        public CreateUpdateOrder(Shoes.AppModels.Order order)
        {
            InitializeComponent();
            _order = order;            
        }

        private void CreateUpdateOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "grablevskiy_mv_shoesDataSet.User". При необходимости она может быть перемещена или удалена.
            //this.userTableAdapter.Fill(this.grablevskiy_mv_shoesDataSet.User.OrderBy(u=>u.FullName));
            userBindingSource.DataSource = Program.context.User.OrderBy(u => u.FullName).ToList();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "grablevskiy_mv_shoesDataSet.Status". При необходимости она может быть перемещена или удалена.
            this.statusTableAdapter.Fill(this.grablevskiy_mv_shoesDataSet.Status);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "grablevskiy_mv_shoesDataSet.Office". При необходимости она может быть перемещена или удалена.
            this.officeTableAdapter.Fill(this.grablevskiy_mv_shoesDataSet.Office);
            
            if (!_order.isNew())
            {
                orderBindingSource.DataSource = _order;
            }
        }

        private void CreateUpdateOrder_Shown(object sender, EventArgs e)
        {
            FormManager.prepareForm("Добавить/редактировать заказ", false);            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            FillModelFields();
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

        private void FillModelFields()
        {
            _order.OfficeId = (int)officeIdComboBox.SelectedValue;
            _order.UserId = (int)userIdComboBox.SelectedValue;
            _order.OrderDate = orderDateDateTimePicker.Value;
            _order.DeliveryDate = deliveryDateDateTimePicker.Value;
            _order.StatusId = (int)statusIdComboBox.SelectedValue;
        }
    }
}
