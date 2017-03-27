namespace Webwinkel
{
    partial class EditArticle
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
            this.textBoxArticleID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.btAddArticle = new System.Windows.Forms.Button();
            this.btUpdateArticle = new System.Windows.Forms.Button();
            this.tbCurrentCat = new System.Windows.Forms.TextBox();
            this.lbCurrentCat = new System.Windows.Forms.Label();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxArticleID
            // 
            this.textBoxArticleID.Location = new System.Drawing.Point(88, 46);
            this.textBoxArticleID.Name = "textBoxArticleID";
            this.textBoxArticleID.ReadOnly = true;
            this.textBoxArticleID.Size = new System.Drawing.Size(120, 20);
            this.textBoxArticleID.TabIndex = 0;
            this.textBoxArticleID.Text = "ID";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(88, 90);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(120, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = "Article Name";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(88, 139);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(120, 20);
            this.textBoxDescription.TabIndex = 2;
            this.textBoxDescription.Text = "Description";
            // 
            // cbCategories
            // 
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(242, 45);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(120, 21);
            this.cbCategories.TabIndex = 4;
            // 
            // btAddArticle
            // 
            this.btAddArticle.Location = new System.Drawing.Point(242, 90);
            this.btAddArticle.Name = "btAddArticle";
            this.btAddArticle.Size = new System.Drawing.Size(116, 23);
            this.btAddArticle.TabIndex = 5;
            this.btAddArticle.Text = "Save Article";
            this.btAddArticle.UseVisualStyleBackColor = true;
            this.btAddArticle.Click += new System.EventHandler(this.btAddArticle_Click);
            // 
            // btUpdateArticle
            // 
            this.btUpdateArticle.Location = new System.Drawing.Point(88, 233);
            this.btUpdateArticle.Name = "btUpdateArticle";
            this.btUpdateArticle.Size = new System.Drawing.Size(270, 20);
            this.btUpdateArticle.TabIndex = 6;
            this.btUpdateArticle.Text = "Update";
            this.btUpdateArticle.UseVisualStyleBackColor = true;
            this.btUpdateArticle.Click += new System.EventHandler(this.btUpdateArticle_Click);
            // 
            // tbCurrentCat
            // 
            this.tbCurrentCat.Location = new System.Drawing.Point(242, 90);
            this.tbCurrentCat.Name = "tbCurrentCat";
            this.tbCurrentCat.ReadOnly = true;
            this.tbCurrentCat.Size = new System.Drawing.Size(120, 20);
            this.tbCurrentCat.TabIndex = 7;
            // 
            // lbCurrentCat
            // 
            this.lbCurrentCat.AutoSize = true;
            this.lbCurrentCat.Location = new System.Drawing.Point(239, 71);
            this.lbCurrentCat.Name = "lbCurrentCat";
            this.lbCurrentCat.Size = new System.Drawing.Size(100, 13);
            this.lbCurrentCat.TabIndex = 8;
            this.lbCurrentCat.Text = "Current CategoryID:";
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(88, 189);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(120, 20);
            this.textBoxStock.TabIndex = 3;
            this.textBoxStock.Text = "00";
            // 
            // cbSupplier
            // 
            this.cbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(242, 139);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(120, 21);
            this.cbSupplier.TabIndex = 9;
            // 
            // EditArticle
            // 
            this.ClientSize = new System.Drawing.Size(454, 361);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.lbCurrentCat);
            this.Controls.Add(this.tbCurrentCat);
            this.Controls.Add(this.btUpdateArticle);
            this.Controls.Add(this.btAddArticle);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxArticleID);
            this.Name = "EditArticle";
            this.Text = "Article";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxArticleID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Button btAddArticle;
        private System.Windows.Forms.Button btUpdateArticle;
        private System.Windows.Forms.TextBox tbCurrentCat;
        private System.Windows.Forms.Label lbCurrentCat;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.ComboBox cbSupplier;
    }
}