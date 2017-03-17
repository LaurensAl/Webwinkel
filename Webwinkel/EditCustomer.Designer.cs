namespace Webwinkel
{
    partial class EditCustomer
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxBankAccount = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.tbArticleID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(91, 117);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(120, 20);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.Text = "Firstname";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(241, 117);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(120, 20);
            this.textBoxLastName.TabIndex = 2;
            this.textBoxLastName.Text = "Lastname";
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(91, 162);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(270, 20);
            this.textBoxAdress.TabIndex = 3;
            this.textBoxAdress.Text = "Adress";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(91, 208);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(120, 20);
            this.textBoxPhoneNumber.TabIndex = 4;
            this.textBoxPhoneNumber.Text = "0000000000";
            // 
            // textBoxBankAccount
            // 
            this.textBoxBankAccount.Location = new System.Drawing.Point(241, 208);
            this.textBoxBankAccount.Name = "textBoxBankAccount";
            this.textBoxBankAccount.Size = new System.Drawing.Size(120, 20);
            this.textBoxBankAccount.TabIndex = 5;
            this.textBoxBankAccount.Text = "BankAccount";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(241, 63);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(120, 23);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(91, 249);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(270, 23);
            this.btUpdate.TabIndex = 7;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // tbArticleID
            // 
            this.tbArticleID.Location = new System.Drawing.Point(91, 66);
            this.tbArticleID.Name = "tbArticleID";
            this.tbArticleID.ReadOnly = true;
            this.tbArticleID.Size = new System.Drawing.Size(120, 20);
            this.tbArticleID.TabIndex = 8;
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 361);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.textBoxBankAccount);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.tbArticleID);
            this.Name = "EditCustomer";
            this.Text = "Customer Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxBankAccount;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.TextBox tbArticleID;
    }
}