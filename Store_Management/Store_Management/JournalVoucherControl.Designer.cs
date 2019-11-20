namespace Store_Management
{
    partial class JournalVoucherControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Save_button = new System.Windows.Forms.Button();
            this.After_c = new System.Windows.Forms.CheckBox();
            this.Before_c = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Before_dp = new System.Windows.Forms.DateTimePicker();
            this.After_dp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.AccountTitle_CB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 51);
            this.panel1.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "JOURNAL VOUCHER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column9,
            this.Column11,
            this.Column10,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(937, 533);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Date";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "JournalID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "AccountTitle";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "VoucherID";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.HeaderText = "VoucherIndex";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText = "VoucherType";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "CR";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "DR";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Description";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column7.HeaderText = "Edit";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Text = "Edit";
            this.Column7.UseColumnTextForButtonValue = true;
            this.Column7.Width = 50;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column8.HeaderText = "Delete";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Text = "Delete";
            this.Column8.UseColumnTextForButtonValue = true;
            this.Column8.Width = 71;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(18, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 532);
            this.panel2.TabIndex = 60;
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
            this.Save_button.Location = new System.Drawing.Point(755, 62);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(200, 38);
            this.Save_button.TabIndex = 1;
            this.Save_button.Text = "ADD NEW ENTRY";
            this.Save_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // After_c
            // 
            this.After_c.AutoSize = true;
            this.After_c.Location = new System.Drawing.Point(18, 69);
            this.After_c.Name = "After_c";
            this.After_c.Size = new System.Drawing.Size(73, 27);
            this.After_c.TabIndex = 5;
            this.After_c.Text = "From";
            this.After_c.UseVisualStyleBackColor = true;
            this.After_c.CheckedChanged += new System.EventHandler(this.After_c_CheckedChanged);
            // 
            // Before_c
            // 
            this.Before_c.AutoSize = true;
            this.Before_c.Location = new System.Drawing.Point(223, 69);
            this.Before_c.Name = "Before_c";
            this.Before_c.Size = new System.Drawing.Size(50, 27);
            this.Before_c.TabIndex = 3;
            this.Before_c.Text = "To";
            this.Before_c.UseVisualStyleBackColor = true;
            this.Before_c.CheckedChanged += new System.EventHandler(this.Before_c_CheckedChanged);
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
            this.button1.Location = new System.Drawing.Point(647, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Before_dp
            // 
            this.Before_dp.CustomFormat = "yyyy-MM-dd";
            this.Before_dp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Before_dp.Location = new System.Drawing.Point(275, 64);
            this.Before_dp.Name = "Before_dp";
            this.Before_dp.Size = new System.Drawing.Size(133, 31);
            this.Before_dp.TabIndex = 2;
            this.Before_dp.Value = new System.DateTime(2019, 9, 22, 0, 0, 0, 0);
            this.Before_dp.ValueChanged += new System.EventHandler(this.Before_dp_ValueChanged);
            // 
            // After_dp
            // 
            this.After_dp.CustomFormat = "yyyy-MM-dd";
            this.After_dp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.After_dp.Location = new System.Drawing.Point(84, 64);
            this.After_dp.Name = "After_dp";
            this.After_dp.Size = new System.Drawing.Size(133, 31);
            this.After_dp.TabIndex = 4;
            this.After_dp.Value = new System.DateTime(2019, 9, 22, 0, 0, 0, 0);
            this.After_dp.ValueChanged += new System.EventHandler(this.After_dp_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 125;
            this.label4.Text = "AccountTitle";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AccountTitle_CB
            // 
            this.AccountTitle_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountTitle_CB.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTitle_CB.FormattingEnabled = true;
            this.AccountTitle_CB.Location = new System.Drawing.Point(520, 67);
            this.AccountTitle_CB.Name = "AccountTitle_CB";
            this.AccountTitle_CB.Size = new System.Drawing.Size(121, 31);
            this.AccountTitle_CB.TabIndex = 6;
            this.AccountTitle_CB.SelectedIndexChanged += new System.EventHandler(this.AccountTitle_CB_SelectedIndexChanged);
            this.AccountTitle_CB.Click += new System.EventHandler(this.AccountTitle_CB_Click);
            // 
            // JournalVoucherControl
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
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "JournalVoucherControl";
            this.Size = new System.Drawing.Size(974, 663);
            this.Load += new System.EventHandler(this.JournalVoucherControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox After_c;
        private System.Windows.Forms.CheckBox Before_c;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker Before_dp;
        private System.Windows.Forms.DateTimePicker After_dp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AccountTitle_CB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
    }
}
