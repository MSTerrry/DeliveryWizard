namespace DW.UI
{
    partial class WayPointF
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
            this.Adress = new System.Windows.Forms.Label();
            this.AdressBox = new System.Windows.Forms.TextBox();
            this.ShopType = new System.Windows.Forms.Label();
            this.DroppedBox1 = new System.Windows.Forms.ComboBox();
            this.ShopList = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.OlaceTitle = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.ProductList = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.CostUD = new System.Windows.Forms.NumericUpDown();
            this.Cost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CostUD)).BeginInit();
            this.SuspendLayout();
            // 
            // Adress
            // 
            this.Adress.AutoSize = true;
            this.Adress.Location = new System.Drawing.Point(25, 49);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(38, 13);
            this.Adress.TabIndex = 0;
            this.Adress.Text = "Адрес";
            // 
            // AdressBox
            // 
            this.AdressBox.Location = new System.Drawing.Point(122, 46);
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(218, 20);
            this.AdressBox.TabIndex = 1;
            // 
            // ShopType
            // 
            this.ShopType.AutoSize = true;
            this.ShopType.Location = new System.Drawing.Point(25, 75);
            this.ShopType.Name = "ShopType";
            this.ShopType.Size = new System.Drawing.Size(60, 13);
            this.ShopType.TabIndex = 2;
            this.ShopType.Text = "Тип места";
            // 
            // DroppedBox1
            // 
            this.DroppedBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DroppedBox1.FormattingEnabled = true;
            this.DroppedBox1.Items.AddRange(new object[] {
            "Магазин",
            "Кафе",
            "Ресторан",
            "Другое"});
            this.DroppedBox1.Location = new System.Drawing.Point(122, 72);
            this.DroppedBox1.Name = "DroppedBox1";
            this.DroppedBox1.Size = new System.Drawing.Size(121, 21);
            this.DroppedBox1.TabIndex = 3;
            // 
            // ShopList
            // 
            this.ShopList.AutoSize = true;
            this.ShopList.Location = new System.Drawing.Point(25, 100);
            this.ShopList.Name = "ShopList";
            this.ShopList.Size = new System.Drawing.Size(88, 13);
            this.ShopList.TabIndex = 4;
            this.ShopList.Text = "Список покупок";
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Save.Enabled = false;
            this.Save.Location = new System.Drawing.Point(478, 330);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 7;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(559, 330);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // OlaceTitle
            // 
            this.OlaceTitle.AutoSize = true;
            this.OlaceTitle.Location = new System.Drawing.Point(25, 23);
            this.OlaceTitle.Name = "OlaceTitle";
            this.OlaceTitle.Size = new System.Drawing.Size(91, 13);
            this.OlaceTitle.TabIndex = 9;
            this.OlaceTitle.Text = "Название места";
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(122, 19);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(218, 20);
            this.TitleBox.TabIndex = 10;
            // 
            // ProductList
            // 
            this.ProductList.FormattingEnabled = true;
            this.ProductList.Location = new System.Drawing.Point(28, 122);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(596, 108);
            this.ProductList.TabIndex = 11;
            this.ProductList.SelectedIndexChanged += new System.EventHandler(this.ProductList_SelectedIndexChanged);
            this.ProductList.DoubleClick += new System.EventHandler(this.ProductList_DoubleClick);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(28, 236);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 12;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.Location = new System.Drawing.Point(109, 236);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 13;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // CostUD
            // 
            this.CostUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CostUD.DecimalPlaces = 2;
            this.CostUD.Location = new System.Drawing.Point(549, 239);
            this.CostUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.CostUD.Name = "CostUD";
            this.CostUD.Size = new System.Drawing.Size(75, 20);
            this.CostUD.TabIndex = 14;
            this.CostUD.ValueChanged += new System.EventHandler(this.CostUD_ValueChanged);
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Location = new System.Drawing.Point(438, 242);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(99, 13);
            this.Cost.TabIndex = 15;
            this.Cost.Text = "Общая стоимость";
            // 
            // WayPointF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 365);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.CostUD);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.OlaceTitle);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.ShopList);
            this.Controls.Add(this.DroppedBox1);
            this.Controls.Add(this.ShopType);
            this.Controls.Add(this.AdressBox);
            this.Controls.Add(this.Adress);
            this.Name = "WayPointF";
            this.Text = "WayPoint";
            this.Load += new System.EventHandler(this.WayPointF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CostUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Adress;
        private System.Windows.Forms.TextBox AdressBox;
        private System.Windows.Forms.Label ShopType;
        private System.Windows.Forms.ComboBox DroppedBox1;
        private System.Windows.Forms.Label ShopList;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label OlaceTitle;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.ListBox ProductList;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.NumericUpDown CostUD;
        private System.Windows.Forms.Label Cost;
    }
}