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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.ordersButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filterByManufacturer = new System.Windows.Forms.ComboBox();
            this.sort = new System.Windows.Forms.GroupBox();
            this.moreFirst = new System.Windows.Forms.RadioButton();
            this.fewerFirst = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grablevskiy_mv_shoesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasurementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
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
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 70);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.AutoScroll = true;
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.Chartreuse;
            this.splitContainer.Panel1.Controls.Add(this.ordersButton);
            this.splitContainer.Panel1.Controls.Add(this.addProductButton);
            this.splitContainer.Panel1.Controls.Add(this.label2);
            this.splitContainer.Panel1.Controls.Add(this.search);
            this.splitContainer.Panel1.Controls.Add(this.label1);
            this.splitContainer.Panel1.Controls.Add(this.filterByManufacturer);
            this.splitContainer.Panel1.Controls.Add(this.sort);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.flowLayoutPanel);
            this.splitContainer.Size = new System.Drawing.Size(834, 679);
            this.splitContainer.SplitterDistance = 38;
            this.splitContainer.TabIndex = 1;
            // 
            // ordersButton
            // 
            this.ordersButton.Location = new System.Drawing.Point(731, 8);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(92, 23);
            this.ordersButton.TabIndex = 6;
            this.ordersButton.Text = "Заказы";
            this.ordersButton.UseVisualStyleBackColor = true;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(619, 9);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(92, 23);
            this.addProductButton.TabIndex = 5;
            this.addProductButton.Text = "Добавить товар";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
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
            // search
            // 
            this.search.Location = new System.Drawing.Point(476, 11);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 20);
            this.search.TabIndex = 3;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поставщик";
            // 
            // filterByManufacturer
            // 
            this.filterByManufacturer.DataSource = this.supplierBindingSource;
            this.filterByManufacturer.DisplayMember = "SupplierName";
            this.filterByManufacturer.FormattingEnabled = true;
            this.filterByManufacturer.Location = new System.Drawing.Point(292, 9);
            this.filterByManufacturer.Name = "filterByManufacturer";
            this.filterByManufacturer.Size = new System.Drawing.Size(121, 22);
            this.filterByManufacturer.TabIndex = 1;
            this.filterByManufacturer.ValueMember = "IdSupplier";
            this.filterByManufacturer.SelectedValueChanged += new System.EventHandler(this.filterByManufacturer_SelectedValueChanged);
            // 
            // sort
            // 
            this.sort.Controls.Add(this.moreFirst);
            this.sort.Controls.Add(this.fewerFirst);
            this.sort.Location = new System.Drawing.Point(13, 0);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(171, 36);
            this.sort.TabIndex = 0;
            this.sort.TabStop = false;
            this.sort.Text = "Количество на складе";
            // 
            // moreFirst
            // 
            this.moreFirst.AutoSize = true;
            this.moreFirst.Location = new System.Drawing.Point(91, 13);
            this.moreFirst.Name = "moreFirst";
            this.moreFirst.Size = new System.Drawing.Size(61, 18);
            this.moreFirst.TabIndex = 1;
            this.moreFirst.TabStop = true;
            this.moreFirst.Text = "Больше";
            this.moreFirst.UseVisualStyleBackColor = true;
            this.moreFirst.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // fewerFirst
            // 
            this.fewerFirst.AutoSize = true;
            this.fewerFirst.Location = new System.Drawing.Point(7, 13);
            this.fewerFirst.Name = "fewerFirst";
            this.fewerFirst.Size = new System.Drawing.Size(64, 18);
            this.fewerFirst.TabIndex = 0;
            this.fewerFirst.TabStop = true;
            this.fewerFirst.Text = "Меньше";
            this.fewerFirst.UseVisualStyleBackColor = true;
            this.fewerFirst.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(834, 637);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(834, 749);
            this.Controls.Add(this.splitContainer);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductForm_FormClosed);
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.Shown += new System.EventHandler(this.ProductForm_Shown);
            this.Controls.SetChildIndex(this.splitContainer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grablevskiy_mv_shoesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasurementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filterByManufacturer;
        private System.Windows.Forms.GroupBox sort;
        private System.Windows.Forms.RadioButton moreFirst;
        private System.Windows.Forms.RadioButton fewerFirst;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}