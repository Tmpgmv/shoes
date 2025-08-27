namespace Shoes.AppForms
{
    partial class CreateUpdateOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label deliveryDateLabel;
            System.Windows.Forms.Label officeIdLabel;
            System.Windows.Forms.Label userIdLabel;
            System.Windows.Forms.Label statusIdLabel;
            this.saveButton = new System.Windows.Forms.Button();
            this.grablevskiy_mv_shoesDataSet = new Shoes.grablevskiy_mv_shoesDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new Shoes.grablevskiy_mv_shoesDataSetTableAdapters.OrderTableAdapter();
            this.tableAdapterManager = new Shoes.grablevskiy_mv_shoesDataSetTableAdapters.TableAdapterManager();
            this.officeTableAdapter = new Shoes.grablevskiy_mv_shoesDataSetTableAdapters.OfficeTableAdapter();
            this.statusTableAdapter = new Shoes.grablevskiy_mv_shoesDataSetTableAdapters.StatusTableAdapter();
            this.userTableAdapter = new Shoes.grablevskiy_mv_shoesDataSetTableAdapters.UserTableAdapter();
            this.officeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deliveryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.officeIdComboBox = new System.Windows.Forms.ComboBox();
            this.userIdComboBox = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusIdComboBox = new System.Windows.Forms.ComboBox();
            orderDateLabel = new System.Windows.Forms.Label();
            deliveryDateLabel = new System.Windows.Forms.Label();
            officeIdLabel = new System.Windows.Forms.Label();
            userIdLabel = new System.Windows.Forms.Label();
            statusIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grablevskiy_mv_shoesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(241, 139);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(61, 14);
            orderDateLabel.TabIndex = 27;
            orderDateLabel.Text = "Дата заказа";
            // 
            // deliveryDateLabel
            // 
            deliveryDateLabel.AutoSize = true;
            deliveryDateLabel.Location = new System.Drawing.Point(241, 165);
            deliveryDateLabel.Name = "deliveryDateLabel";
            deliveryDateLabel.Size = new System.Drawing.Size(67, 14);
            deliveryDateLabel.TabIndex = 29;
            deliveryDateLabel.Text = "Дата выдачи";
            // 
            // officeIdLabel
            // 
            officeIdLabel.AutoSize = true;
            officeIdLabel.Location = new System.Drawing.Point(241, 190);
            officeIdLabel.Name = "officeIdLabel";
            officeIdLabel.Size = new System.Drawing.Size(109, 14);
            officeIdLabel.TabIndex = 31;
            officeIdLabel.Text = "Адрес пункта выдачи";
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new System.Drawing.Point(241, 218);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(41, 14);
            userIdLabel.TabIndex = 33;
            userIdLabel.Text = "Клиент";
            // 
            // statusIdLabel
            // 
            statusIdLabel.AutoSize = true;
            statusIdLabel.Location = new System.Drawing.Point(241, 246);
            statusIdLabel.Name = "statusIdLabel";
            statusIdLabel.Size = new System.Drawing.Size(40, 14);
            statusIdLabel.TabIndex = 35;
            statusIdLabel.Text = "Статус";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.saveButton.Location = new System.Drawing.Point(233, 285);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(359, 23);
            this.saveButton.TabIndex = 27;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // grablevskiy_mv_shoesDataSet
            // 
            this.grablevskiy_mv_shoesDataSet.DataSetName = "grablevskiy_mv_shoesDataSet";
            this.grablevskiy_mv_shoesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.grablevskiy_mv_shoesDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.OfficeTableAdapter = this.officeTableAdapter;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager.ProductNameTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = this.statusTableAdapter;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UnitOfMeasurementTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Shoes.grablevskiy_mv_shoesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            // 
            // officeTableAdapter
            // 
            this.officeTableAdapter.ClearBeforeFill = true;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // officeBindingSource
            // 
            this.officeBindingSource.DataMember = "Office";
            this.officeBindingSource.DataSource = this.grablevskiy_mv_shoesDataSet;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.grablevskiy_mv_shoesDataSet;
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "OrderDate", true));
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(358, 135);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(232, 20);
            this.orderDateDateTimePicker.TabIndex = 28;
            // 
            // deliveryDateDateTimePicker
            // 
            this.deliveryDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "DeliveryDate", true));
            this.deliveryDateDateTimePicker.Location = new System.Drawing.Point(358, 161);
            this.deliveryDateDateTimePicker.Name = "deliveryDateDateTimePicker";
            this.deliveryDateDateTimePicker.Size = new System.Drawing.Size(232, 20);
            this.deliveryDateDateTimePicker.TabIndex = 30;
            // 
            // officeIdComboBox
            // 
            this.officeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderBindingSource, "OfficeId", true));
            this.officeIdComboBox.DataSource = this.officeBindingSource;
            this.officeIdComboBox.DisplayMember = "Address";
            this.officeIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.officeIdComboBox.FormattingEnabled = true;
            this.officeIdComboBox.Location = new System.Drawing.Point(358, 187);
            this.officeIdComboBox.Name = "officeIdComboBox";
            this.officeIdComboBox.Size = new System.Drawing.Size(232, 22);
            this.officeIdComboBox.TabIndex = 32;
            this.officeIdComboBox.ValueMember = "IdOffice";
            // 
            // userIdComboBox
            // 
            this.userIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderBindingSource, "UserId", true));
            this.userIdComboBox.DataSource = this.userBindingSource;
            this.userIdComboBox.DisplayMember = "FullName";
            this.userIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userIdComboBox.FormattingEnabled = true;
            this.userIdComboBox.Location = new System.Drawing.Point(358, 215);
            this.userIdComboBox.Name = "userIdComboBox";
            this.userIdComboBox.Size = new System.Drawing.Size(232, 22);
            this.userIdComboBox.TabIndex = 34;
            this.userIdComboBox.ValueMember = "IdUser";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.grablevskiy_mv_shoesDataSet;
            // 
            // statusIdComboBox
            // 
            this.statusIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderBindingSource, "StatusId", true));
            this.statusIdComboBox.DataSource = this.statusBindingSource;
            this.statusIdComboBox.DisplayMember = "StatusName";
            this.statusIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusIdComboBox.FormattingEnabled = true;
            this.statusIdComboBox.Location = new System.Drawing.Point(358, 243);
            this.statusIdComboBox.Name = "statusIdComboBox";
            this.statusIdComboBox.Size = new System.Drawing.Size(232, 22);
            this.statusIdComboBox.TabIndex = 36;
            this.statusIdComboBox.ValueMember = "IdStatus";
            // 
            // CreateUpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(orderDateLabel);
            this.Controls.Add(this.orderDateDateTimePicker);
            this.Controls.Add(deliveryDateLabel);
            this.Controls.Add(this.deliveryDateDateTimePicker);
            this.Controls.Add(officeIdLabel);
            this.Controls.Add(this.officeIdComboBox);
            this.Controls.Add(userIdLabel);
            this.Controls.Add(this.userIdComboBox);
            this.Controls.Add(statusIdLabel);
            this.Controls.Add(this.statusIdComboBox);
            this.Controls.Add(this.saveButton);
            this.Name = "CreateUpdateOrder";
            this.Text = "CreateUpdateOrder";
            this.Load += new System.EventHandler(this.CreateUpdateOrder_Load);
            this.Shown += new System.EventHandler(this.CreateUpdateOrder_Shown);
            this.Controls.SetChildIndex(this.saveButton, 0);
            this.Controls.SetChildIndex(this.statusIdComboBox, 0);
            this.Controls.SetChildIndex(statusIdLabel, 0);
            this.Controls.SetChildIndex(this.userIdComboBox, 0);
            this.Controls.SetChildIndex(userIdLabel, 0);
            this.Controls.SetChildIndex(this.officeIdComboBox, 0);
            this.Controls.SetChildIndex(officeIdLabel, 0);
            this.Controls.SetChildIndex(this.deliveryDateDateTimePicker, 0);
            this.Controls.SetChildIndex(deliveryDateLabel, 0);
            this.Controls.SetChildIndex(this.orderDateDateTimePicker, 0);
            this.Controls.SetChildIndex(orderDateLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grablevskiy_mv_shoesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private grablevskiy_mv_shoesDataSet grablevskiy_mv_shoesDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private grablevskiy_mv_shoesDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private grablevskiy_mv_shoesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private grablevskiy_mv_shoesDataSetTableAdapters.OfficeTableAdapter officeTableAdapter;
        private System.Windows.Forms.BindingSource officeBindingSource;
        private grablevskiy_mv_shoesDataSetTableAdapters.StatusTableAdapter statusTableAdapter;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker deliveryDateDateTimePicker;
        private System.Windows.Forms.ComboBox officeIdComboBox;
        private System.Windows.Forms.ComboBox userIdComboBox;
        private System.Windows.Forms.ComboBox statusIdComboBox;
        private grablevskiy_mv_shoesDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}