namespace DW.UI
{
    partial class Form1
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DateTime = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.FullName = new System.Windows.Forms.Label();
            this.TimeToDeliver = new System.Windows.Forms.Label();
            this.FullNameBox = new System.Windows.Forms.TextBox();
            this.TimeToDeliverPicker = new System.Windows.Forms.DateTimePicker();
            this.Places = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.ClientAddress = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.Label();
            this.CostUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CostUD)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(138, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // DateTime
            // 
            this.DateTime.AutoSize = true;
            this.DateTime.Location = new System.Drawing.Point(22, 18);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(103, 13);
            this.DateTime.TabIndex = 1;
            this.DateTime.Text = "Время заполнения";
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.Location = new System.Drawing.Point(501, 316);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 23);
            this.Save.TabIndex = 2;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Open
            // 
            this.Open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Open.Location = new System.Drawing.Point(607, 316);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(100, 23);
            this.Open.TabIndex = 3;
            this.Open.Text = "Открыть";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Location = new System.Drawing.Point(22, 45);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(34, 13);
            this.FullName.TabIndex = 4;
            this.FullName.Text = "ФИО";
            // 
            // TimeToDeliver
            // 
            this.TimeToDeliver.AutoSize = true;
            this.TimeToDeliver.Location = new System.Drawing.Point(327, 18);
            this.TimeToDeliver.Name = "TimeToDeliver";
            this.TimeToDeliver.Size = new System.Drawing.Size(90, 13);
            this.TimeToDeliver.TabIndex = 6;
            this.TimeToDeliver.Text = "Время доставки";
            // 
            // FullNameBox
            // 
            this.FullNameBox.Location = new System.Drawing.Point(138, 45);
            this.FullNameBox.Name = "FullNameBox";
            this.FullNameBox.Size = new System.Drawing.Size(160, 20);
            this.FullNameBox.TabIndex = 5;
            // 
            // TimeToDeliverPicker
            // 
            this.TimeToDeliverPicker.CustomFormat = "";
            this.TimeToDeliverPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeToDeliverPicker.Location = new System.Drawing.Point(440, 15);
            this.TimeToDeliverPicker.Name = "TimeToDeliverPicker";
            this.TimeToDeliverPicker.Size = new System.Drawing.Size(83, 20);
            this.TimeToDeliverPicker.TabIndex = 7;
            // 
            // Places
            // 
            this.Places.AutoSize = true;
            this.Places.Location = new System.Drawing.Point(22, 81);
            this.Places.Name = "Places";
            this.Places.Size = new System.Drawing.Size(83, 13);
            this.Places.TabIndex = 8;
            this.Places.Text = "Места покупки";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(663, 121);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(30, 224);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 10;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.Location = new System.Drawing.Point(111, 224);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ClientAddress
            // 
            this.ClientAddress.AutoSize = true;
            this.ClientAddress.Location = new System.Drawing.Point(327, 48);
            this.ClientAddress.Name = "ClientAddress";
            this.ClientAddress.Size = new System.Drawing.Size(38, 13);
            this.ClientAddress.TabIndex = 12;
            this.ClientAddress.Text = "Адрес";
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(371, 45);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(160, 20);
            this.AddressBox.TabIndex = 13;
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Location = new System.Drawing.Point(502, 230);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(99, 13);
            this.Cost.TabIndex = 17;
            this.Cost.Text = "Общая стоимость";
            // 
            // CostUD
            // 
            this.CostUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CostUD.DecimalPlaces = 2;
            this.CostUD.Location = new System.Drawing.Point(613, 227);
            this.CostUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.CostUD.Name = "CostUD";
            this.CostUD.Size = new System.Drawing.Size(75, 20);
            this.CostUD.TabIndex = 16;
            this.CostUD.ValueChanged += new System.EventHandler(this.CostUD_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 351);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.CostUD);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.ClientAddress);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Places);
            this.Controls.Add(this.TimeToDeliverPicker);
            this.Controls.Add(this.TimeToDeliver);
            this.Controls.Add(this.FullNameBox);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Delivery Wizard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CostUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label DateTime;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label TimeToDeliver;
        private System.Windows.Forms.TextBox FullNameBox;
        private System.Windows.Forms.DateTimePicker TimeToDeliverPicker;
        private System.Windows.Forms.Label Places;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label ClientAddress;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.NumericUpDown CostUD;
    }
}

