namespace Store_Management
{
    partial class Add_StockAdjusment
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
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Save_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Type_CB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Item_CB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Quantity_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Quantity2_tb = new System.Windows.Forms.TextBox();
            this.Type2_CB = new System.Windows.Forms.ComboBox();
            this.Item2_CB = new System.Windows.Forms.ComboBox();
            this.Add_c = new System.Windows.Forms.CheckBox();
            this.Location_CB = new System.Windows.Forms.ComboBox();
            this.Location2_CB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 111;
            this.label2.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 31);
            this.dateTimePicker1.TabIndex = 99;
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.Save_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_button.ForeColor = System.Drawing.Color.White;
            this.Save_button.Image = global::Store_Management.Properties.Resources.save_white_24x241;
            this.Save_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_button.Location = new System.Drawing.Point(530, 255);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(91, 57);
            this.Save_button.TabIndex = 105;
            this.Save_button.Text = "Save";
            this.Save_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 23);
            this.label7.TabIndex = 117;
            this.label7.Text = "Type";
            // 
            // Type_CB
            // 
            this.Type_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_CB.FormattingEnabled = true;
            this.Type_CB.Items.AddRange(new object[] {
            "--Select--",
            "Purchase",
            "MoveIn",
            "MoveOut",
            "Damage",
            "Missing",
            "Sale"});
            this.Type_CB.Location = new System.Drawing.Point(142, 155);
            this.Type_CB.Name = "Type_CB";
            this.Type_CB.Size = new System.Drawing.Size(178, 31);
            this.Type_CB.TabIndex = 116;
            this.Type_CB.SelectedIndexChanged += new System.EventHandler(this.Type_CB_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 114;
            this.label5.Text = "Location";
            // 
            // Item_CB
            // 
            this.Item_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Item_CB.FormattingEnabled = true;
            this.Item_CB.Location = new System.Drawing.Point(142, 60);
            this.Item_CB.Name = "Item_CB";
            this.Item_CB.Size = new System.Drawing.Size(178, 31);
            this.Item_CB.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 113;
            this.label4.Text = "Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 123;
            this.label3.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 120;
            this.label6.Text = "Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 23);
            this.label8.TabIndex = 119;
            this.label8.Text = "Item";
            // 
            // Quantity_tb
            // 
            this.Quantity_tb.Location = new System.Drawing.Point(142, 202);
            this.Quantity_tb.Name = "Quantity_tb";
            this.Quantity_tb.Size = new System.Drawing.Size(178, 31);
            this.Quantity_tb.TabIndex = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 126;
            this.label1.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 23);
            this.label9.TabIndex = 128;
            this.label9.Text = "Quantity";
            // 
            // Quantity2_tb
            // 
            this.Quantity2_tb.Location = new System.Drawing.Point(433, 197);
            this.Quantity2_tb.Name = "Quantity2_tb";
            this.Quantity2_tb.Size = new System.Drawing.Size(188, 31);
            this.Quantity2_tb.TabIndex = 133;
            // 
            // Type2_CB
            // 
            this.Type2_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type2_CB.FormattingEnabled = true;
            this.Type2_CB.Items.AddRange(new object[] {
            "--Select--",
            "Purchase",
            "MoveIn",
            "MoveOut",
            "Damage",
            "Missing",
            "Sale"});
            this.Type2_CB.Location = new System.Drawing.Point(433, 150);
            this.Type2_CB.Name = "Type2_CB";
            this.Type2_CB.Size = new System.Drawing.Size(188, 31);
            this.Type2_CB.TabIndex = 132;
            // 
            // Item2_CB
            // 
            this.Item2_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Item2_CB.FormattingEnabled = true;
            this.Item2_CB.Location = new System.Drawing.Point(433, 55);
            this.Item2_CB.Name = "Item2_CB";
            this.Item2_CB.Size = new System.Drawing.Size(188, 31);
            this.Item2_CB.TabIndex = 131;
            // 
            // Add_c
            // 
            this.Add_c.AutoSize = true;
            this.Add_c.Location = new System.Drawing.Point(348, 18);
            this.Add_c.Name = "Add_c";
            this.Add_c.Size = new System.Drawing.Size(63, 27);
            this.Add_c.TabIndex = 135;
            this.Add_c.Text = "Add";
            this.Add_c.UseVisualStyleBackColor = true;
            this.Add_c.CheckedChanged += new System.EventHandler(this.Add_c_CheckedChanged);
            // 
            // Location_CB
            // 
            this.Location_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Location_CB.FormattingEnabled = true;
            this.Location_CB.Location = new System.Drawing.Point(142, 107);
            this.Location_CB.Name = "Location_CB";
            this.Location_CB.Size = new System.Drawing.Size(178, 31);
            this.Location_CB.TabIndex = 136;
            this.Location_CB.TextChanged += new System.EventHandler(this.Location_CB_TextChanged);
            // 
            // Location2_CB
            // 
            this.Location2_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Location2_CB.FormattingEnabled = true;
            this.Location2_CB.Location = new System.Drawing.Point(433, 107);
            this.Location2_CB.Name = "Location2_CB";
            this.Location2_CB.Size = new System.Drawing.Size(188, 31);
            this.Location2_CB.TabIndex = 137;
            this.Location2_CB.TextChanged += new System.EventHandler(this.Location2_CB_TextChanged);
            // 
            // Add_StockAdjusment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(646, 334);
            this.Controls.Add(this.Location2_CB);
            this.Controls.Add(this.Location_CB);
            this.Controls.Add(this.Add_c);
            this.Controls.Add(this.Quantity2_tb);
            this.Controls.Add(this.Type2_CB);
            this.Controls.Add(this.Item2_CB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quantity_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Type_CB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Item_CB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Save_button);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Add_StockAdjusment";
            this.Text = "Add_StockAdjusment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Type_CB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Item_CB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Quantity_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Quantity2_tb;
        private System.Windows.Forms.ComboBox Type2_CB;
        private System.Windows.Forms.ComboBox Item2_CB;
        private System.Windows.Forms.CheckBox Add_c;
        public  System.Windows.Forms.ComboBox Location_CB;
        private System.Windows.Forms.ComboBox Location2_CB;
    }
}