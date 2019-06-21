namespace Store_Management
{
    partial class Accounts_datagrid
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
            this.Accounts = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Change_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Accounts);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 100);
            this.panel1.TabIndex = 84;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(751, 431);
            this.dataGridView1.TabIndex = 85;
            // 
            // Change_button
            // 
            this.Change_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.Change_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Change_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change_button.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_button.ForeColor = System.Drawing.Color.White;
            this.Change_button.Image = global::Store_Management.Properties.Resources.check_circle_white_24x24;
            this.Change_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Change_button.Location = new System.Drawing.Point(620, 106);
            this.Change_button.Name = "Change_button";
            this.Change_button.Size = new System.Drawing.Size(113, 57);
            this.Change_button.TabIndex = 100;
            this.Change_button.Text = "Change";
            this.Change_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Change_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Change_button.UseVisualStyleBackColor = false;
            this.Change_button.Click += new System.EventHandler(this.Change_button_Click);
            // 
            // Accounts_datagrid
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.Controls.Add(this.Change_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Accounts_datagrid";
            this.Size = new System.Drawing.Size(750, 600);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Accounts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Change_button;
    }
}
