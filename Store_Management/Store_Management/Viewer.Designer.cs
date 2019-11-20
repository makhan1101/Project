﻿namespace Store_Management
{
    partial class Viewer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AccountTitle_CB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.After_dp = new System.Windows.Forms.DateTimePicker();
            this.Before_dp = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.After_c = new System.Windows.Forms.CheckBox();
            this.Before_c = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(16, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 547);
            this.panel2.TabIndex = 122;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(943, 541);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Store_Management.Properties.Resources.add_file_24;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(871, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Print";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 48);
            this.panel1.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORT";
            // 
            // AccountTitle_CB
            // 
            this.AccountTitle_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountTitle_CB.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTitle_CB.FormattingEnabled = true;
            this.AccountTitle_CB.Location = new System.Drawing.Point(629, 55);
            this.AccountTitle_CB.Name = "AccountTitle_CB";
            this.AccountTitle_CB.Size = new System.Drawing.Size(121, 31);
            this.AccountTitle_CB.TabIndex = 130;
            this.AccountTitle_CB.Click += new System.EventHandler(this.AccountTitle_CB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 134;
            this.label4.Text = "AccountTitle";
            // 
            // After_dp
            // 
            this.After_dp.CustomFormat = "yyyy-MM-dd";
            this.After_dp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.After_dp.Location = new System.Drawing.Point(191, 52);
            this.After_dp.Name = "After_dp";
            this.After_dp.Size = new System.Drawing.Size(133, 31);
            this.After_dp.TabIndex = 128;
            this.After_dp.Value = new System.DateTime(2019, 9, 22, 0, 0, 0, 0);
            // 
            // Before_dp
            // 
            this.Before_dp.CustomFormat = "yyyy-MM-dd";
            this.Before_dp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Before_dp.Location = new System.Drawing.Point(379, 52);
            this.Before_dp.Name = "Before_dp";
            this.Before_dp.Size = new System.Drawing.Size(133, 31);
            this.Before_dp.TabIndex = 126;
            this.Before_dp.Value = new System.DateTime(2019, 9, 22, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Store_Management.Properties.Resources.add_file_24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(756, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 131;
            this.button1.Text = "Search";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // After_c
            // 
            this.After_c.AutoSize = true;
            this.After_c.Location = new System.Drawing.Point(112, 57);
            this.After_c.Name = "After_c";
            this.After_c.Size = new System.Drawing.Size(73, 27);
            this.After_c.TabIndex = 129;
            this.After_c.Text = "From";
            this.After_c.UseVisualStyleBackColor = true;
            this.After_c.CheckedChanged += new System.EventHandler(this.After_c_CheckedChanged);
            // 
            // Before_c
            // 
            this.Before_c.AutoSize = true;
            this.Before_c.Location = new System.Drawing.Point(330, 57);
            this.Before_c.Name = "Before_c";
            this.Before_c.Size = new System.Drawing.Size(50, 27);
            this.Before_c.TabIndex = 127;
            this.Before_c.Text = "To";
            this.Before_c.UseVisualStyleBackColor = true;
            this.Before_c.CheckedChanged += new System.EventHandler(this.Before_c_CheckedChanged);
            // 
            // Viewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.Controls.Add(this.AccountTitle_CB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.After_dp);
            this.Controls.Add(this.Before_c);
            this.Controls.Add(this.Before_dp);
            this.Controls.Add(this.After_c);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Viewer";
            this.Size = new System.Drawing.Size(974, 663);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AccountTitle_CB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker After_dp;
        private System.Windows.Forms.DateTimePicker Before_dp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox After_c;
        private System.Windows.Forms.CheckBox Before_c;
    }
}