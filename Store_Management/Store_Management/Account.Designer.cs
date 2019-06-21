namespace Store_Management
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Accounts = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AccountTitle_TextBox = new System.Windows.Forms.MaskedTextBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Balance_TextBox = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Accounts);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 72);
            this.panel1.TabIndex = 83;
            // 
            // Accounts
            // 
            this.Accounts.AutoSize = true;
            this.Accounts.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accounts.Location = new System.Drawing.Point(29, 25);
            this.Accounts.Name = "Accounts";
            this.Accounts.Size = new System.Drawing.Size(119, 26);
            this.Accounts.TabIndex = 0;
            this.Accounts.Text = "ACCOUNTS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 23);
            this.label6.TabIndex = 98;
            this.label6.Text = "Account Title";
            // 
            // AccountTitle_TextBox
            // 
            this.AccountTitle_TextBox.Location = new System.Drawing.Point(237, 79);
            this.AccountTitle_TextBox.Name = "AccountTitle_TextBox";
            this.AccountTitle_TextBox.Size = new System.Drawing.Size(261, 31);
            this.AccountTitle_TextBox.TabIndex = 96;
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.Save_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_button.ForeColor = System.Drawing.Color.White;
            this.Save_button.Image = ((System.Drawing.Image)(resources.GetObject("Save_button.Image")));
            this.Save_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_button.Location = new System.Drawing.Point(38, 190);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(91, 57);
            this.Save_button.TabIndex = 99;
            this.Save_button.Text = "SAVE";
            this.Save_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.Delete_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_button.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_button.ForeColor = System.Drawing.Color.White;
            this.Delete_button.Image = ((System.Drawing.Image)(resources.GetObject("Delete_button.Image")));
            this.Delete_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete_button.Location = new System.Drawing.Point(154, 190);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(112, 57);
            this.Delete_button.TabIndex = 100;
            this.Delete_button.Text = "DELETE";
            this.Delete_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.Update_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_button.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_button.ForeColor = System.Drawing.Color.White;
            this.Update_button.Image = ((System.Drawing.Image)(resources.GetObject("Update_button.Image")));
            this.Update_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update_button.Location = new System.Drawing.Point(298, 190);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(117, 57);
            this.Update_button.TabIndex = 101;
            this.Update_button.Text = "UPDATE";
            this.Update_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Update_button.UseVisualStyleBackColor = false;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(38, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 303);
            this.panel2.TabIndex = 102;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(696, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 104;
            this.label1.Text = "Balance";
            // 
            // Balance_TextBox
            // 
            this.Balance_TextBox.Location = new System.Drawing.Point(154, 133);
            this.Balance_TextBox.Name = "Balance_TextBox";
            this.Balance_TextBox.Size = new System.Drawing.Size(261, 31);
            this.Balance_TextBox.TabIndex = 103;
            // 
            // Account
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Balance_TextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AccountTitle_TextBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Account";
            this.Size = new System.Drawing.Size(750, 600);
            this.Load += new System.EventHandler(this.Account_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Accounts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox AccountTitle_TextBox;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Balance_TextBox;
    }
}
