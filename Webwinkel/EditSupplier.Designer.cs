namespace Webwinkel
{
    partial class EditSupplier
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
            this.btUpdateSupplier = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.tbSuppMail = new System.Windows.Forms.TextBox();
            this.tbSupplierPhone = new System.Windows.Forms.TextBox();
            this.tbSuppAdress = new System.Windows.Forms.TextBox();
            this.tbCompanySupp = new System.Windows.Forms.TextBox();
            this.tbSupID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btUpdateSupplier
            // 
            this.btUpdateSupplier.Location = new System.Drawing.Point(73, 234);
            this.btUpdateSupplier.Name = "btUpdateSupplier";
            this.btUpdateSupplier.Size = new System.Drawing.Size(270, 23);
            this.btUpdateSupplier.TabIndex = 15;
            this.btUpdateSupplier.Text = "Update";
            this.btUpdateSupplier.UseVisualStyleBackColor = true;
            this.btUpdateSupplier.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(73, 190);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(120, 23);
            this.btSave.TabIndex = 14;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbSuppMail
            // 
            this.tbSuppMail.Location = new System.Drawing.Point(223, 193);
            this.tbSuppMail.Name = "tbSuppMail";
            this.tbSuppMail.Size = new System.Drawing.Size(120, 20);
            this.tbSuppMail.TabIndex = 13;
            this.tbSuppMail.Text = "Email";
            // 
            // tbSupplierPhone
            // 
            this.tbSupplierPhone.Location = new System.Drawing.Point(223, 102);
            this.tbSupplierPhone.Name = "tbSupplierPhone";
            this.tbSupplierPhone.Size = new System.Drawing.Size(120, 20);
            this.tbSupplierPhone.TabIndex = 12;
            this.tbSupplierPhone.Text = "0000000000";
            // 
            // tbSuppAdress
            // 
            this.tbSuppAdress.Location = new System.Drawing.Point(73, 149);
            this.tbSuppAdress.Name = "tbSuppAdress";
            this.tbSuppAdress.Size = new System.Drawing.Size(270, 20);
            this.tbSuppAdress.TabIndex = 11;
            this.tbSuppAdress.Text = "Adress";
            // 
            // tbCompanySupp
            // 
            this.tbCompanySupp.Location = new System.Drawing.Point(73, 102);
            this.tbCompanySupp.Name = "tbCompanySupp";
            this.tbCompanySupp.Size = new System.Drawing.Size(120, 20);
            this.tbCompanySupp.TabIndex = 9;
            this.tbCompanySupp.Text = "Company Name";
            // 
            // tbSupID
            // 
            this.tbSupID.Location = new System.Drawing.Point(73, 57);
            this.tbSupID.Name = "tbSupID";
            this.tbSupID.ReadOnly = true;
            this.tbSupID.Size = new System.Drawing.Size(120, 20);
            this.tbSupID.TabIndex = 16;
            // 
            // EditSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.btUpdateSupplier);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbSuppMail);
            this.Controls.Add(this.tbSupplierPhone);
            this.Controls.Add(this.tbSuppAdress);
            this.Controls.Add(this.tbCompanySupp);
            this.Controls.Add(this.tbSupID);
            this.Name = "EditSupplier";
            this.Text = "Supplier Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btUpdateSupplier;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbSuppMail;
        private System.Windows.Forms.TextBox tbSupplierPhone;
        private System.Windows.Forms.TextBox tbSuppAdress;
        private System.Windows.Forms.TextBox tbCompanySupp;
        private System.Windows.Forms.TextBox tbSupID;
    }
}