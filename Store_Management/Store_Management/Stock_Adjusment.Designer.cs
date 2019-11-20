namespace Store_Management
{
    partial class Stock_Adjusment
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AccountTitle_CB = new System.Windows.Forms.ComboBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.After_dp = new System.Windows.Forms.DateTimePicker();
            this.Before_dp = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.After_c = new System.Windows.Forms.CheckBox();
            this.Before_c = new System.Windows.Forms.CheckBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 53);
            this.panel2.TabIndex = 133;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(13, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 549);
            this.panel1.TabIndex = 132;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(946, 549);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AccountTitle_CB
            // 
            this.AccountTitle_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountTitle_CB.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTitle_CB.FormattingEnabled = true;
            this.AccountTitle_CB.Location = new System.Drawing.Point(515, 57);
            this.AccountTitle_CB.Name = "AccountTitle_CB";
            this.AccountTitle_CB.Size = new System.Drawing.Size(121, 31);
            this.AccountTitle_CB.TabIndex = 139;
            this.AccountTitle_CB.SelectedIndexChanged += new System.EventHandler(this.AccountTitle_CB_SelectedIndexChanged);
            this.AccountTitle_CB.Click += new System.EventHandler(this.AccountTitle_CB_Click);
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.Save_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_button.ForeColor = System.Drawing.Color.White;
            this.Save_button.Image = global::Store_Management.Properties.Resources.add_file_24;
            this.Save_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_button.Location = new System.Drawing.Point(759, 52);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(200, 38);
            this.Save_button.TabIndex = 134;
            this.Save_button.Text = "ADD NEW ENTRY";
            this.Save_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 141;
            this.label4.Text = "AccountTitle";
            // 
            // After_dp
            // 
            this.After_dp.CustomFormat = "yyyy-MM-dd";
            this.After_dp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.After_dp.Location = new System.Drawing.Point(79, 54);
            this.After_dp.Name = "After_dp";
            this.After_dp.Size = new System.Drawing.Size(133, 31);
            this.After_dp.TabIndex = 137;
            this.After_dp.Value = new System.DateTime(2019, 9, 22, 0, 0, 0, 0);
            // 
            // Before_dp
            // 
            this.Before_dp.CustomFormat = "yyyy-MM-dd";
            this.Before_dp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Before_dp.Location = new System.Drawing.Point(270, 54);
            this.Before_dp.Name = "Before_dp";
            this.Before_dp.Size = new System.Drawing.Size(133, 31);
            this.Before_dp.TabIndex = 135;
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
            this.button1.Location = new System.Drawing.Point(642, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 140;
            this.button1.Text = "Search";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // After_c
            // 
            this.After_c.AutoSize = true;
            this.After_c.Location = new System.Drawing.Point(13, 59);
            this.After_c.Name = "After_c";
            this.After_c.Size = new System.Drawing.Size(73, 27);
            this.After_c.TabIndex = 138;
            this.After_c.Text = "From";
            this.After_c.UseVisualStyleBackColor = true;
            this.After_c.CheckedChanged += new System.EventHandler(this.After_c_CheckedChanged);
            // 
            // Before_c
            // 
            this.Before_c.AutoSize = true;
            this.Before_c.Location = new System.Drawing.Point(218, 59);
            this.Before_c.Name = "Before_c";
            this.Before_c.Size = new System.Drawing.Size(50, 27);
            this.Before_c.TabIndex = 136;
            this.Before_c.Text = "To";
            this.Before_c.UseVisualStyleBackColor = true;
            this.Before_c.CheckedChanged += new System.EventHandler(this.Before_c_CheckedChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Date";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Item";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "Location";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText = "Quantity";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.HeaderText = "Type";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Edit";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Text = "Edit";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Delete";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Text = "Delete";
            this.Column6.UseColumnTextForButtonValue = true;
            // 
            // Stock_Adjusment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.Controls.Add(this.AccountTitle_CB);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.After_dp);
            this.Controls.Add(this.Before_dp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.After_c);
            this.Controls.Add(this.Before_c);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Stock_Adjusment";
            this.Size = new System.Drawing.Size(974, 663);
            this.Load += new System.EventHandler(this.Stock_Adjusment_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox AccountTitle_CB;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker After_dp;
        private System.Windows.Forms.DateTimePicker Before_dp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox After_c;
        private System.Windows.Forms.CheckBox Before_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
    }
}
