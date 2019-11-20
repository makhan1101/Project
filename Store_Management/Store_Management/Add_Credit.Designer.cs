namespace Store_Management
{
    partial class Add_Credit
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
            this.CRAccount_CB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Description_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CR_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DR_textbox = new System.Windows.Forms.TextBox();
            this.DRAccount_CB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 111;
            this.label2.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 31);
            this.dateTimePicker1.TabIndex = 99;
            // 
            // CRAccount_CB
            // 
            this.CRAccount_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CRAccount_CB.FormattingEnabled = true;
            this.CRAccount_CB.Location = new System.Drawing.Point(443, 65);
            this.CRAccount_CB.Name = "CRAccount_CB";
            this.CRAccount_CB.Size = new System.Drawing.Size(178, 31);
            this.CRAccount_CB.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 110;
            this.label3.Text = "CR Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 109;
            this.label1.Text = "Description";
            // 
            // Description_richTextBox
            // 
            this.Description_richTextBox.Location = new System.Drawing.Point(142, 155);
            this.Description_richTextBox.Name = "Description_richTextBox";
            this.Description_richTextBox.Size = new System.Drawing.Size(479, 85);
            this.Description_richTextBox.TabIndex = 104;
            this.Description_richTextBox.Text = "";
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
            this.Save_button.Location = new System.Drawing.Point(529, 255);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(91, 57);
            this.Save_button.TabIndex = 105;
            this.Save_button.Text = "Save";
            this.Save_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 23);
            this.label6.TabIndex = 108;
            this.label6.Text = "CR";
            // 
            // CR_textBox
            // 
            this.CR_textBox.Location = new System.Drawing.Point(443, 107);
            this.CR_textBox.Name = "CR_textBox";
            this.CR_textBox.Size = new System.Drawing.Size(177, 31);
            this.CR_textBox.TabIndex = 103;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 23);
            this.label5.TabIndex = 107;
            this.label5.Text = "DR";
            // 
            // DR_textbox
            // 
            this.DR_textbox.Location = new System.Drawing.Point(142, 107);
            this.DR_textbox.Name = "DR_textbox";
            this.DR_textbox.Size = new System.Drawing.Size(178, 31);
            this.DR_textbox.TabIndex = 102;
            // 
            // DRAccount_CB
            // 
            this.DRAccount_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DRAccount_CB.FormattingEnabled = true;
            this.DRAccount_CB.Location = new System.Drawing.Point(142, 60);
            this.DRAccount_CB.Name = "DRAccount_CB";
            this.DRAccount_CB.Size = new System.Drawing.Size(178, 31);
            this.DRAccount_CB.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 106;
            this.label4.Text = "DR  Account";
            // 
            // Add_Credit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(646, 326);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CRAccount_CB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Description_richTextBox);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CR_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DR_textbox);
            this.Controls.Add(this.DRAccount_CB);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Add_Credit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Credit";
            this.Load += new System.EventHandler(this.Add_Credit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CRAccount_CB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Description_richTextBox;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CR_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DR_textbox;
        private System.Windows.Forms.ComboBox DRAccount_CB;
        private System.Windows.Forms.Label label4;
    }
}