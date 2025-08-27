namespace Shoes.AppForms
{
    partial class CreateUpdateProduct
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
            System.Windows.Forms.Label skuLabel;
            System.Windows.Forms.Label productNameIdLabel;
            System.Windows.Forms.Label unitOfMeasurementIdLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label supplierIdLabel;
            System.Windows.Forms.Label manufacturerIdLabel;
            System.Windows.Forms.Label categoryIdLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label photoLabel;
            this.grablevskiy_mv_shoesDataSet = new Shoes.grablevskiy_mv_shoesDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Shoes.grablevskiy_mv_shoesDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new Shoes.grablevskiy_mv_shoesDataSetTableAdapters.TableAdapterManager();
            this.saveButton = new System.Windows.Forms.Button();
            this.skuTextBox = new System.Windows.Forms.TextBox();
            this.productNameIdComboBox = new System.Windows.Forms.ComboBox();
            this.productNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitOfMeasurementIdComboBox = new System.Windows.Forms.ComboBox();
            this.unitOfMeasurementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.supplierIdComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerIdComboBox = new System.Windows.Forms.ComboBox();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.productNameTableAdapter = new Shoes.grablevskiy_mv_shoesDataSetTableAdapters.ProductNameTableAdapter();
            this.unitOfMeasurementTableAdapter = new Shoes.grablevskiy_mv_shoesDataSetTableAdapters.UnitOfMeasurementTableAdapter();
            this.supplierTableAdapter = new Shoes.grablevskiy_mv_shoesDataSetTableAdapters.SupplierTableAdapter();
            this.manufacturerTableAdapter = new Shoes.grablevskiy_mv_shoesDataSetTableAdapters.ManufacturerTableAdapter();
            this.grablevskiymvshoesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new Shoes.grablevskiy_mv_shoesDataSetTableAdapters.CategoryTableAdapter();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogButton = new System.Windows.Forms.Button();
            skuLabel = new System.Windows.Forms.Label();
            productNameIdLabel = new System.Windows.Forms.Label();
            unitOfMeasurementIdLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            supplierIdLabel = new System.Windows.Forms.Label();
            manufacturerIdLabel = new System.Windows.Forms.Label();
            categoryIdLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grablevskiy_mv_shoesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasurementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grablevskiymvshoesDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // skuLabel
            // 
            skuLabel.AutoSize = true;
            skuLabel.Location = new System.Drawing.Point(248, 89);
            skuLabel.Name = "skuLabel";
            skuLabel.Size = new System.Drawing.Size(48, 14);
            skuLabel.TabIndex = 26;
            skuLabel.Text = "Артикул";
            // 
            // productNameIdLabel
            // 
            productNameIdLabel.AutoSize = true;
            productNameIdLabel.Location = new System.Drawing.Point(248, 115);
            productNameIdLabel.Name = "productNameIdLabel";
            productNameIdLabel.Size = new System.Drawing.Size(124, 14);
            productNameIdLabel.TabIndex = 28;
            productNameIdLabel.Text = "Наименование продукта";
            // 
            // unitOfMeasurementIdLabel
            // 
            unitOfMeasurementIdLabel.AutoSize = true;
            unitOfMeasurementIdLabel.Location = new System.Drawing.Point(248, 143);
            unitOfMeasurementIdLabel.Name = "unitOfMeasurementIdLabel";
            unitOfMeasurementIdLabel.Size = new System.Drawing.Size(101, 14);
            unitOfMeasurementIdLabel.TabIndex = 30;
            unitOfMeasurementIdLabel.Text = "Единица измерения";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(248, 171);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(31, 14);
            priceLabel.TabIndex = 32;
            priceLabel.Text = "Цена";
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Location = new System.Drawing.Point(248, 197);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(60, 14);
            supplierIdLabel.TabIndex = 34;
            supplierIdLabel.Text = "Поставщик";
            // 
            // manufacturerIdLabel
            // 
            manufacturerIdLabel.AutoSize = true;
            manufacturerIdLabel.Location = new System.Drawing.Point(248, 225);
            manufacturerIdLabel.Name = "manufacturerIdLabel";
            manufacturerIdLabel.Size = new System.Drawing.Size(79, 14);
            manufacturerIdLabel.TabIndex = 36;
            manufacturerIdLabel.Text = "Производитель";
            // 
            // categoryIdLabel
            // 
            categoryIdLabel.AutoSize = true;
            categoryIdLabel.Location = new System.Drawing.Point(248, 253);
            categoryIdLabel.Name = "categoryIdLabel";
            categoryIdLabel.Size = new System.Drawing.Size(57, 14);
            categoryIdLabel.TabIndex = 38;
            categoryIdLabel.Text = "Категория";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new System.Drawing.Point(248, 281);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(40, 14);
            discountLabel.TabIndex = 40;
            discountLabel.Text = "Скидка";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(248, 307);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(62, 14);
            amountLabel.TabIndex = 42;
            amountLabel.Text = "Количество";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(248, 333);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(54, 14);
            descriptionLabel.TabIndex = 44;
            descriptionLabel.Text = "Описание";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(248, 359);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(66, 14);
            photoLabel.TabIndex = 46;
            photoLabel.Text = "Фотография";
            // 
            // grablevskiy_mv_shoesDataSet
            // 
            this.grablevskiy_mv_shoesDataSet.DataSetName = "grablevskiy_mv_shoesDataSet";
            this.grablevskiy_mv_shoesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.saveButton.Location = new System.Drawing.Point(246, 399);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(359, 23);
            this.saveButton.TabIndex = 26;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // skuTextBox
            // 
            this.skuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Sku", true));
            this.skuTextBox.Location = new System.Drawing.Point(377, 86);
            this.skuTextBox.Name = "skuTextBox";
            this.skuTextBox.Size = new System.Drawing.Size(228, 20);
            this.skuTextBox.TabIndex = 27;
            // 
            // productNameIdComboBox
            // 
            this.productNameIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ProductNameId", true));
            this.productNameIdComboBox.DataSource = this.productNameBindingSource;
            this.productNameIdComboBox.DisplayMember = "ProductName";
            this.productNameIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productNameIdComboBox.FormattingEnabled = true;
            this.productNameIdComboBox.Location = new System.Drawing.Point(377, 112);
            this.productNameIdComboBox.Name = "productNameIdComboBox";
            this.productNameIdComboBox.Size = new System.Drawing.Size(228, 22);
            this.productNameIdComboBox.TabIndex = 29;
            this.productNameIdComboBox.ValueMember = "IdProductName";
            // 
            // productNameBindingSource
            // 
            this.productNameBindingSource.DataMember = "ProductName";
            this.productNameBindingSource.DataSource = this.grablevskiy_mv_shoesDataSet;
            // 
            // unitOfMeasurementIdComboBox
            // 
            this.unitOfMeasurementIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "UnitOfMeasurementId", true));
            this.unitOfMeasurementIdComboBox.DataSource = this.unitOfMeasurementBindingSource;
            this.unitOfMeasurementIdComboBox.DisplayMember = "UnitOfMeasurementName";
            this.unitOfMeasurementIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitOfMeasurementIdComboBox.FormattingEnabled = true;
            this.unitOfMeasurementIdComboBox.Location = new System.Drawing.Point(377, 140);
            this.unitOfMeasurementIdComboBox.Name = "unitOfMeasurementIdComboBox";
            this.unitOfMeasurementIdComboBox.Size = new System.Drawing.Size(228, 22);
            this.unitOfMeasurementIdComboBox.TabIndex = 31;
            this.unitOfMeasurementIdComboBox.ValueMember = "IdUnitOfMeasurement";
            // 
            // unitOfMeasurementBindingSource
            // 
            this.unitOfMeasurementBindingSource.DataMember = "UnitOfMeasurement";
            this.unitOfMeasurementBindingSource.DataSource = this.grablevskiy_mv_shoesDataSet;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(377, 168);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(228, 20);
            this.priceTextBox.TabIndex = 33;
            this.priceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.priceTextBox_Validating);
            // 
            // supplierIdComboBox
            // 
            this.supplierIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "SupplierId", true));
            this.supplierIdComboBox.DataSource = this.supplierBindingSource;
            this.supplierIdComboBox.DisplayMember = "SupplierName";
            this.supplierIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierIdComboBox.FormattingEnabled = true;
            this.supplierIdComboBox.Location = new System.Drawing.Point(377, 194);
            this.supplierIdComboBox.Name = "supplierIdComboBox";
            this.supplierIdComboBox.Size = new System.Drawing.Size(228, 22);
            this.supplierIdComboBox.TabIndex = 35;
            this.supplierIdComboBox.ValueMember = "IdSupplier";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.grablevskiy_mv_shoesDataSet;
            // 
            // manufacturerIdComboBox
            // 
            this.manufacturerIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ManufacturerId", true));
            this.manufacturerIdComboBox.DataSource = this.manufacturerBindingSource;
            this.manufacturerIdComboBox.DisplayMember = "ManufacturerName";
            this.manufacturerIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturerIdComboBox.FormattingEnabled = true;
            this.manufacturerIdComboBox.Location = new System.Drawing.Point(377, 222);
            this.manufacturerIdComboBox.Name = "manufacturerIdComboBox";
            this.manufacturerIdComboBox.Size = new System.Drawing.Size(228, 22);
            this.manufacturerIdComboBox.TabIndex = 37;
            this.manufacturerIdComboBox.ValueMember = "IdManufacturer";
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.grablevskiy_mv_shoesDataSet;
            // 
            // categoryIdComboBox
            // 
            this.categoryIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "CategoryId", true));
            this.categoryIdComboBox.DataSource = this.categoryBindingSource;
            this.categoryIdComboBox.DisplayMember = "CategoryName";
            this.categoryIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryIdComboBox.FormattingEnabled = true;
            this.categoryIdComboBox.Location = new System.Drawing.Point(377, 250);
            this.categoryIdComboBox.Name = "categoryIdComboBox";
            this.categoryIdComboBox.Size = new System.Drawing.Size(228, 22);
            this.categoryIdComboBox.TabIndex = 39;
            this.categoryIdComboBox.ValueMember = "IdCategory";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.grablevskiy_mv_shoesDataSet;
            // 
            // discountTextBox
            // 
            this.discountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Discount", true));
            this.discountTextBox.Location = new System.Drawing.Point(377, 278);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(228, 20);
            this.discountTextBox.TabIndex = 41;
            this.discountTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.discountTextBox_Validating);
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(377, 304);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(228, 20);
            this.amountTextBox.TabIndex = 43;
            this.amountTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.amountTextBox_Validating);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(377, 330);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(228, 20);
            this.descriptionTextBox.TabIndex = 45;
            this.descriptionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.descriptionTextBox_Validating);
            // 
            // photoTextBox
            // 
            this.photoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Photo", true));
            this.photoTextBox.Enabled = false;
            this.photoTextBox.Location = new System.Drawing.Point(377, 356);
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.Size = new System.Drawing.Size(149, 20);
            this.photoTextBox.TabIndex = 47;
            // 
            // productNameTableAdapter
            // 
            this.productNameTableAdapter.ClearBeforeFill = true;
            // 
            // unitOfMeasurementTableAdapter
            // 
            this.unitOfMeasurementTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // grablevskiymvshoesDataSetBindingSource
            // 
            this.grablevskiymvshoesDataSetBindingSource.DataSource = this.grablevskiy_mv_shoesDataSet;
            this.grablevskiymvshoesDataSetBindingSource.Position = 0;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialogButton
            // 
            this.openFileDialogButton.Location = new System.Drawing.Point(533, 356);
            this.openFileDialogButton.Name = "openFileDialogButton";
            this.openFileDialogButton.Size = new System.Drawing.Size(72, 20);
            this.openFileDialogButton.TabIndex = 48;
            this.openFileDialogButton.Text = "Файл";
            this.openFileDialogButton.UseVisualStyleBackColor = true;
            this.openFileDialogButton.Click += new System.EventHandler(this.openFileDialogButton_Click);
            // 
            // CreateUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openFileDialogButton);
            this.Controls.Add(skuLabel);
            this.Controls.Add(this.skuTextBox);
            this.Controls.Add(productNameIdLabel);
            this.Controls.Add(this.productNameIdComboBox);
            this.Controls.Add(unitOfMeasurementIdLabel);
            this.Controls.Add(this.unitOfMeasurementIdComboBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(supplierIdLabel);
            this.Controls.Add(this.supplierIdComboBox);
            this.Controls.Add(manufacturerIdLabel);
            this.Controls.Add(this.manufacturerIdComboBox);
            this.Controls.Add(categoryIdLabel);
            this.Controls.Add(this.categoryIdComboBox);
            this.Controls.Add(discountLabel);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoTextBox);
            this.Controls.Add(this.saveButton);
            this.Name = "CreateUpdateProduct";
            this.Text = "CreateUpdateProduct";
            this.Load += new System.EventHandler(this.CreateUpdateProduct_Load);
            this.Shown += new System.EventHandler(this.CreateUpdateProduct_Shown);
            this.Controls.SetChildIndex(this.saveButton, 0);
            this.Controls.SetChildIndex(this.photoTextBox, 0);
            this.Controls.SetChildIndex(photoLabel, 0);
            this.Controls.SetChildIndex(this.descriptionTextBox, 0);
            this.Controls.SetChildIndex(descriptionLabel, 0);
            this.Controls.SetChildIndex(this.amountTextBox, 0);
            this.Controls.SetChildIndex(amountLabel, 0);
            this.Controls.SetChildIndex(this.discountTextBox, 0);
            this.Controls.SetChildIndex(discountLabel, 0);
            this.Controls.SetChildIndex(this.categoryIdComboBox, 0);
            this.Controls.SetChildIndex(categoryIdLabel, 0);
            this.Controls.SetChildIndex(this.manufacturerIdComboBox, 0);
            this.Controls.SetChildIndex(manufacturerIdLabel, 0);
            this.Controls.SetChildIndex(this.supplierIdComboBox, 0);
            this.Controls.SetChildIndex(supplierIdLabel, 0);
            this.Controls.SetChildIndex(this.priceTextBox, 0);
            this.Controls.SetChildIndex(priceLabel, 0);
            this.Controls.SetChildIndex(this.unitOfMeasurementIdComboBox, 0);
            this.Controls.SetChildIndex(unitOfMeasurementIdLabel, 0);
            this.Controls.SetChildIndex(this.productNameIdComboBox, 0);
            this.Controls.SetChildIndex(productNameIdLabel, 0);
            this.Controls.SetChildIndex(this.skuTextBox, 0);
            this.Controls.SetChildIndex(skuLabel, 0);
            this.Controls.SetChildIndex(this.openFileDialogButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grablevskiy_mv_shoesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasurementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grablevskiymvshoesDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private grablevskiy_mv_shoesDataSet grablevskiy_mv_shoesDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private grablevskiy_mv_shoesDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private grablevskiy_mv_shoesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox skuTextBox;
        private System.Windows.Forms.ComboBox productNameIdComboBox;
        private System.Windows.Forms.ComboBox unitOfMeasurementIdComboBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox supplierIdComboBox;
        private System.Windows.Forms.ComboBox manufacturerIdComboBox;
        private System.Windows.Forms.ComboBox categoryIdComboBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.BindingSource productNameBindingSource;
        private grablevskiy_mv_shoesDataSetTableAdapters.ProductNameTableAdapter productNameTableAdapter;
        private System.Windows.Forms.BindingSource unitOfMeasurementBindingSource;
        private grablevskiy_mv_shoesDataSetTableAdapters.UnitOfMeasurementTableAdapter unitOfMeasurementTableAdapter;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private grablevskiy_mv_shoesDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private grablevskiy_mv_shoesDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.BindingSource grablevskiymvshoesDataSetBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private grablevskiy_mv_shoesDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button openFileDialogButton;
    }
}