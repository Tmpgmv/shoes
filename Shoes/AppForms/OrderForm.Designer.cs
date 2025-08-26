namespace Shoes.AppForms
{
    partial class OrderForm
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grablevskiy_mv_shoesDataSet = new Shoes.grablevskiy_mv_shoesDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.descRadioButton = new System.Windows.Forms.RadioButton();
            this.ascRadioButton = new System.Windows.Forms.RadioButton();
            this.backButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.statusTableAdapter = new Shoes.grablevskiy_mv_shoesDataSetTableAdapters.StatusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grablevskiy_mv_shoesDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 70);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.Chartreuse;
            this.splitContainer.Panel1.Controls.Add(this.label2);
            this.splitContainer.Panel1.Controls.Add(this.label1);
            this.splitContainer.Panel1.Controls.Add(this.search);
            this.splitContainer.Panel1.Controls.Add(this.statusComboBox);
            this.splitContainer.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer.Panel1.Controls.Add(this.backButton);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.flowLayoutPanel);
            this.splitContainer.Size = new System.Drawing.Size(800, 380);
            this.splitContainer.SplitterDistance = 38;
            this.splitContainer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Поиск";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Статус";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(389, 12);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 20);
            this.search.TabIndex = 5;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataSource = this.statusBindingSource;
            this.statusComboBox.DisplayMember = "StatusName";
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(206, 11);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 22);
            this.statusComboBox.TabIndex = 2;
            this.statusComboBox.ValueMember = "StatusName";
            this.statusComboBox.SelectedValueChanged += new System.EventHandler(this.statusComboBox_SelectedValueChanged);
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.grablevskiy_mv_shoesDataSet;
            // 
            // grablevskiy_mv_shoesDataSet
            // 
            this.grablevskiy_mv_shoesDataSet.DataSetName = "grablevskiy_mv_shoesDataSet";
            this.grablevskiy_mv_shoesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.descRadioButton);
            this.groupBox1.Controls.Add(this.ascRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(13, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 36);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Адрес пункта выдачи";
            // 
            // descRadioButton
            // 
            this.descRadioButton.AutoSize = true;
            this.descRadioButton.Location = new System.Drawing.Point(67, 13);
            this.descRadioButton.Name = "descRadioButton";
            this.descRadioButton.Size = new System.Drawing.Size(44, 18);
            this.descRadioButton.TabIndex = 1;
            this.descRadioButton.TabStop = true;
            this.descRadioButton.Text = "Я-А";
            this.descRadioButton.UseVisualStyleBackColor = true;
            this.descRadioButton.CheckedChanged += new System.EventHandler(this.descRadioButton_CheckedChanged);
            // 
            // ascRadioButton
            // 
            this.ascRadioButton.AutoSize = true;
            this.ascRadioButton.Location = new System.Drawing.Point(7, 14);
            this.ascRadioButton.Name = "ascRadioButton";
            this.ascRadioButton.Size = new System.Drawing.Size(44, 18);
            this.ascRadioButton.TabIndex = 0;
            this.ascRadioButton.TabStop = true;
            this.ascRadioButton.Text = "А-Я";
            this.ascRadioButton.UseVisualStyleBackColor = true;
            this.ascRadioButton.CheckedChanged += new System.EventHandler(this.descRadioButton_CheckedChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(722, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(800, 338);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderForm_FormClosed);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.Shown += new System.EventHandler(this.OrderForm_Shown);
            this.Controls.SetChildIndex(this.splitContainer, 0);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grablevskiy_mv_shoesDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ascRadioButton;
        private System.Windows.Forms.RadioButton descRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox statusComboBox;
        private grablevskiy_mv_shoesDataSet grablevskiy_mv_shoesDataSet;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private grablevskiy_mv_shoesDataSetTableAdapters.StatusTableAdapter statusTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}