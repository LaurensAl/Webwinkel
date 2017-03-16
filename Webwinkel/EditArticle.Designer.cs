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
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.btAddArticle = new System.Windows.Forms.Button();
            this.btUpdateArticle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxArticleID
            // 
            this.textBoxArticleID.Location = new System.Drawing.Point(88, 90);
            this.textBoxArticleID.Name = "textBoxArticleID";
            this.textBoxArticleID.ReadOnly = true;
            this.textBoxArticleID.Size = new System.Drawing.Size(120, 20);
            this.textBoxArticleID.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(88, 139);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(120, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = "Article Name";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(88, 191);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(120, 20);
            this.textBoxDescription.TabIndex = 2;
            this.textBoxDescription.Text = "Description";
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(242, 90);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(116, 20);
            this.textBoxStock.TabIndex = 3;
            this.textBoxStock.Text = "00";
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(242, 138);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(116, 21);
            this.cbCategories.TabIndex = 4;
            // 
            // btAddArticle
            // 
            this.btAddArticle.Location = new System.Drawing.Point(242, 191);
            this.btAddArticle.Name = "btAddArticle";
            this.btAddArticle.Size = new System.Drawing.Size(116, 23);
            this.btAddArticle.TabIndex = 5;
            this.btAddArticle.Text = "Save Article";
            this.btAddArticle.UseVisualStyleBackColor = true;
            // 
            // btUpdateArticle
            // 
            this.btUpdateArticle.Location = new System.Drawing.Point(88, 233);
            this.btUpdateArticle.Name = "btUpdateArticle";
            this.btUpdateArticle.Size = new System.Drawing.Size(270, 23);
            this.btUpdateArticle.TabIndex = 6;
            this.btUpdateArticle.Text = "Update";
            this.btUpdateArticle.UseVisualStyleBackColor = true;
            // 
            // EditArticle
            // 
            this.ClientSize = new System.Drawing.Size(454, 361);
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
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Button btAddArticle;
        private System.Windows.Forms.Button btUpdateArticle;
    }
}