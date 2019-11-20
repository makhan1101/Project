namespace Store_Management
{
    partial class Add
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
            this.label1 = new System.Windows.Forms.Label();
            this.Balance_TextBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AccountTitle_TextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HeadAccount_CB = new System.Windows.Forms.ComboBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 117;
            this.label1.Text = "Balance";
            // 
            // Balance_TextBox
            // 
            this.Balance_TextBox.Location = new System.Drawing.Point(148, 84);
            this.Balance_TextBox.Name = "Balance_TextBox";
            this.Balance_TextBox.Size = new System.Drawing.Size(261, 31);
            this.Balance_TextBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 23);
            this.label6.TabIndex = 115;
            this.label6.Text = "Account Title";
            // 
            // AccountTitle_TextBox
            // 
            this.AccountTitle_TextBox.Location = new System.Drawing.Point(148, 38);
            this.AccountTitle_TextBox.Name = "AccountTitle_TextBox";
            this.AccountTitle_TextBox.Size = new System.Drawing.Size(261, 31);
            this.AccountTitle_TextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 120;
            this.label2.Text = "Head Account";
            // 
            // HeadAccount_CB
            // 
            this.HeadAccount_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HeadAccount_CB.FormattingEnabled = true;
            this.HeadAccount_CB.Location = new System.Drawing.Point(148, 131);
            this.HeadAccount_CB.Name = "HeadAccount_CB";
            this.HeadAccount_CB.Size = new System.Drawing.Size(261, 31);
            this.HeadAccount_CB.TabIndex = 3;
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.Save_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_button.ForeColor = System.Drawing.Color.White;
            this.Save_button.Image = global::Store_Management.Properties.Resources.save_white_24x24;
            this.Save_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_button.Location = new System.Drawing.Point(318, 186);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(91, 57);
            this.Save_button.TabIndex = 4;
            this.Save_button.Text = "SAVE";
            this.Save_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Add
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(438, 255);
            this.Controls.Add(this.HeadAccount_CB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Balance_TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AccountTitle_TextBox);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Balance_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox AccountTitle_TextBox;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox HeadAccount_CB;
    }
}