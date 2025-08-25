namespace Shoes.AppControls
{
    partial class ProductUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.photo = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.oldPrice = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.unitOfMeasurement = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.supplier = new System.Windows.Forms.Label();
            this.manufacturer = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.categoryName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.discount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // photo
            // 
            this.photo.Location = new System.Drawing.Point(13, 12);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(122, 122);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photo.TabIndex = 0;
            this.photo.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.deleteProductButton);
            this.mainPanel.Controls.Add(this.oldPrice);
            this.mainPanel.Controls.Add(this.amount);
            this.mainPanel.Controls.Add(this.unitOfMeasurement);
            this.mainPanel.Controls.Add(this.price);
            this.mainPanel.Controls.Add(this.supplier);
            this.mainPanel.Controls.Add(this.manufacturer);
            this.mainPanel.Controls.Add(this.description);
            this.mainPanel.Controls.Add(this.categoryName);
            this.mainPanel.Location = new System.Drawing.Point(142, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(500, 122);
            this.mainPanel.TabIndex = 1;
            // 
            // oldPrice
            // 
            this.oldPrice.AutoSize = true;
            this.oldPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPrice.ForeColor = System.Drawing.Color.Red;
            this.oldPrice.Location = new System.Drawing.Point(100, 60);
            this.oldPrice.Name = "oldPrice";
            this.oldPrice.Size = new System.Drawing.Size(0, 13);
            this.oldPrice.TabIndex = 7;
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(13, 86);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(120, 13);
            this.amount.TabIndex = 6;
            this.amount.Text = "Количество на складе";
            // 
            // unitOfMeasurement
            // 
            this.unitOfMeasurement.AutoSize = true;
            this.unitOfMeasurement.Location = new System.Drawing.Point(13, 73);
            this.unitOfMeasurement.Name = "unitOfMeasurement";
            this.unitOfMeasurement.Size = new System.Drawing.Size(109, 13);
            this.unitOfMeasurement.TabIndex = 5;
            this.unitOfMeasurement.Text = "Единица измерения";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(13, 60);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(33, 13);
            this.price.TabIndex = 4;
            this.price.Text = "Цена";
            // 
            // supplier
            // 
            this.supplier.AutoSize = true;
            this.supplier.Location = new System.Drawing.Point(13, 47);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(65, 13);
            this.supplier.TabIndex = 3;
            this.supplier.Text = "Поставщик";
            // 
            // manufacturer
            // 
            this.manufacturer.AutoSize = true;
            this.manufacturer.Location = new System.Drawing.Point(13, 34);
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.Size = new System.Drawing.Size(86, 13);
            this.manufacturer.TabIndex = 2;
            this.manufacturer.Text = "Производитель";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(13, 21);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(95, 13);
            this.description.TabIndex = 1;
            this.description.Text = "Описание товара";
            // 
            // categoryName
            // 
            this.categoryName.AutoSize = true;
            this.categoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryName.Location = new System.Drawing.Point(13, 4);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(157, 13);
            this.categoryName.TabIndex = 0;
            this.categoryName.Text = "КатегорияНаименование";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.discount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(652, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 122);
            this.panel1.TabIndex = 2;
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Location = new System.Drawing.Point(51, 54);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(44, 13);
            this.discount.TabIndex = 1;
            this.discount.Text = "Скидка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Скидка";
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.deleteProductButton.Location = new System.Drawing.Point(410, 86);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(75, 23);
            this.deleteProductButton.TabIndex = 8;
            this.deleteProductButton.Text = "Удалить";
            this.deleteProductButton.UseVisualStyleBackColor = false;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.photo);
            this.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(793, 148);
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label categoryName;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label supplier;
        private System.Windows.Forms.Label manufacturer;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label unitOfMeasurement;
        private System.Windows.Forms.Label oldPrice;
        private System.Windows.Forms.Button deleteProductButton;
    }
}
