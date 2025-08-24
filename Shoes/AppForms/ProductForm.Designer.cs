namespace Shoes.AppForms
{
    partial class ProductForm
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
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grablevskiy_mv_shoesDataSet = new Shoes.grablevskiy_mv_shoesDataSet();
            this.productNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitOfMeasurementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Shoes.grablevskiy_mv_shoesDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new Shoes.grablevskiy_mv_shoesDataSetTableAdapters.TableAdapterManager();
            this.categoryTableAdapter = new Shoes.grablevskiy_mv_shoesDataSetTableAdapters.CategoryTableAdapter();
            this.productNameTableAdapter = new Shoes.grablevskiy_mv_shoesDataSetTableAdapters.ProductNameTableAdapter();
            this.manufacturerTableAdapter = new Shoes.grablevskiy_mv_shoesDataSetTableAdapters.ManufacturerTableAdapter();
            this.supplierTableAdapter = new Shoes.grablevskiy_mv_shoesDataSetTableAdapters.SupplierTableAdapter();
            this.unitOfMeasurementTableAdapter = new Shoes.grablevskiy_mv_shoesDataSetTableAdapters.UnitOfMeasurementTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sort = new System.Windows.Forms.GroupBox();
            this.cheapFirst = new System.Windows.Forms.RadioButton();
            this.expensiveFirst = new System.Windows.Forms.RadioButton();
            this.filterByManufacturer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grablevskiy_mv_shoesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasurementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sort.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.grablevskiy_mv_shoesDataSet;
            // 
            // grablevskiy_mv_shoesDataSet
            // 
            this.grablevskiy_mv_shoesDataSet.DataSetName = "grablevskiy_mv_shoesDataSet";
            this.grablevskiy_mv_shoesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productNameBindingSource
            // 
            this.productNameBindingSource.DataMember = "ProductName";
            this.productNameBindingSource.DataSource = this.grablevskiy_mv_shoesDataSet;
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.grablevskiy_mv_shoesDataSet;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.grablevskiy_mv_shoesDataSet;
            // 
            // unitOfMeasurementBindingSource
            // 
            this.unitOfMeasurementBindingSource.DataMember = "UnitOfMeasurement";
            this.unitOfMeasurementBindingSource.DataSource = this.grablevskiy_mv_shoesDataSet;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.grablevskiy_mv_shoesDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.OfficeTableAdapter = null;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.ProductNameTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UnitOfMeasurementTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Shoes.grablevskiy_mv_shoesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // productNameTableAdapter
            // 
            this.productNameTableAdapter.ClearBeforeFill = true;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // unitOfMeasurementTableAdapter
            // 
            this.unitOfMeasurementTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Chartreuse;
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.search);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.filterByManufacturer);
            this.splitContainer1.Panel1.Controls.Add(this.sort);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel);
            this.splitContainer1.Size = new System.Drawing.Size(834, 673);
            this.splitContainer1.SplitterDistance = 38;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(834, 631);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 673);
            this.panel2.TabIndex = 2;
            // 
            // sort
            // 
            this.sort.Controls.Add(this.expensiveFirst);
            this.sort.Controls.Add(this.cheapFirst);
            this.sort.Location = new System.Drawing.Point(13, 0);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(171, 36);
            this.sort.TabIndex = 0;
            this.sort.TabStop = false;
            this.sort.Text = "Сначала";
            // 
            // cheapFirst
            // 
            this.cheapFirst.AutoSize = true;
            this.cheapFirst.Location = new System.Drawing.Point(7, 13);
            this.cheapFirst.Name = "cheapFirst";
            this.cheapFirst.Size = new System.Drawing.Size(68, 18);
            this.cheapFirst.TabIndex = 0;
            this.cheapFirst.TabStop = true;
            this.cheapFirst.Text = "Дешевые";
            this.cheapFirst.UseVisualStyleBackColor = true;
            this.cheapFirst.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // expensiveFirst
            // 
            this.expensiveFirst.AutoSize = true;
            this.expensiveFirst.Location = new System.Drawing.Point(91, 13);
            this.expensiveFirst.Name = "expensiveFirst";
            this.expensiveFirst.Size = new System.Drawing.Size(67, 18);
            this.expensiveFirst.TabIndex = 1;
            this.expensiveFirst.TabStop = true;
            this.expensiveFirst.Text = "Дорогие";
            this.expensiveFirst.UseVisualStyleBackColor = true;
            this.expensiveFirst.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // filterByManufacturer
            // 
            this.filterByManufacturer.DataSource = this.manufacturerBindingSource;
            this.filterByManufacturer.DisplayMember = "ManufacturerName";
            this.filterByManufacturer.FormattingEnabled = true;
            this.filterByManufacturer.Location = new System.Drawing.Point(292, 9);
            this.filterByManufacturer.Name = "filterByManufacturer";
            this.filterByManufacturer.Size = new System.Drawing.Size(121, 22);
            this.filterByManufacturer.TabIndex = 1;
            this.filterByManufacturer.ValueMember = "IdManufacturer";
            this.filterByManufacturer.SelectedValueChanged += new System.EventHandler(this.filterByManufacturer_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Производитель";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(476, 11);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 20);
            this.search.TabIndex = 3;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Поиск";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(834, 749);
            this.Controls.Add(this.panel2);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductForm_FormClosed);
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.Shown += new System.EventHandler(this.ProductForm_Shown);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grablevskiy_mv_shoesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasurementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.sort.ResumeLayout(false);
            this.sort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private grablevskiy_mv_shoesDataSet grablevskiy_mv_shoesDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private grablevskiy_mv_shoesDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private grablevskiy_mv_shoesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private grablevskiy_mv_shoesDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource productNameBindingSource;
        private grablevskiy_mv_shoesDataSetTableAdapters.ProductNameTableAdapter productNameTableAdapter;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private grablevskiy_mv_shoesDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private grablevskiy_mv_shoesDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.BindingSource unitOfMeasurementBindingSource;
        private grablevskiy_mv_shoesDataSetTableAdapters.UnitOfMeasurementTableAdapter unitOfMeasurementTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox sort;
        private System.Windows.Forms.RadioButton cheapFirst;
        private System.Windows.Forms.RadioButton expensiveFirst;
        private System.Windows.Forms.ComboBox filterByManufacturer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search;
    }
}