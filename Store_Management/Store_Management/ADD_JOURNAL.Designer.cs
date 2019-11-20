namespace Store_Management
{
    partial class ADD_JOURNAL
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
            this.label6 = new System.Windows.Forms.Label();
            this.CR_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DR_textbox = new System.Windows.Forms.TextBox();
            this.DRAccount_CB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Description_richTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Save_button = new System.Windows.Forms.Button();
            this.CRAccount_CB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 23);
            this.label6.TabIndex = 68;
            this.label6.Text = "CR";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CR_textBox
            // 
            this.CR_textBox.Location = new System.Drawing.Point(441, 101);
            this.CR_textBox.Name = "CR_textBox";
            this.CR_textBox.Size = new System.Drawing.Size(177, 31);
            this.CR_textBox.TabIndex = 5;
            this.CR_textBox.TextChanged += new System.EventHandler(this.CR_textBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 23);
            this.label5.TabIndex = 66;
            this.label5.Text = "DR";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // DR_textbox
            // 
            this.DR_textbox.Location = new System.Drawing.Point(140, 101);
            this.DR_textbox.Name = "DR_textbox";
            this.DR_textbox.Size = new System.Drawing.Size(178, 31);
            this.DR_textbox.TabIndex = 4;
            this.DR_textbox.TextChanged += new System.EventHandler(this.DR_textbox_TextChanged);
            // 
            // DRAccount_CB
            // 
            this.DRAccount_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DRAccount_CB.FormattingEnabled = true;
            this.DRAccount_CB.Location = new System.Drawing.Point(140, 54);
            this.DRAccount_CB.Name = "DRAccount_CB";
            this.DRAccount_CB.Size = new System.Drawing.Size(178, 31);
            this.DRAccount_CB.TabIndex = 2;
            this.DRAccount_CB.SelectedIndexChanged += new System.EventHandler(this.Account_CB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 63;
            this.label4.Text = "DR  Account";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Description_richTextBox
            // 
            this.Description_richTextBox.Location = new System.Drawing.Point(140, 149);
            this.Description_richTextBox.Name = "Description_richTextBox";
            this.Description_richTextBox.Size = new System.Drawing.Size(479, 85);
            this.Description_richTextBox.TabIndex = 6;
            this.Description_richTextBox.Text = "";
            this.Description_richTextBox.TextChanged += new System.EventHandler(this.Description_richTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 72;
            this.label1.Text = "Description";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.Save_button.Location = new System.Drawing.Point(527, 249);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(91, 57);
            this.Save_button.TabIndex = 7;
            this.Save_button.Text = "Save";
            this.Save_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // CRAccount_CB
            // 
            this.CRAccount_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CRAccount_CB.FormattingEnabled = true;
            this.CRAccount_CB.Location = new System.Drawing.Point(441, 59);
            this.CRAccount_CB.Name = "CRAccount_CB";
            this.CRAccount_CB.Size = new System.Drawing.Size(178, 31);
            this.CRAccount_CB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 73;
            this.label3.Text = "CR Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 98;
            this.label2.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 31);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // ADD_JOURNAL
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(646, 321);
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
            this.Name = "ADD_JOURNAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD_JOURNAL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CR_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DR_textbox;
        private System.Windows.Forms.ComboBox DRAccount_CB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox Description_richTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CRAccount_CB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}