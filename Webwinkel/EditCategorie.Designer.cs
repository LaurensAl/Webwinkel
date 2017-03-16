namespace Webwinkel
{
    partial class EditCategorie
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
            this.tbCategoriesName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btAddCategorie = new System.Windows.Forms.Button();
            this.btUpdateCategories = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCategoriesName
            // 
            this.tbCategoriesName.Location = new System.Drawing.Point(104, 138);
            this.tbCategoriesName.Name = "tbCategoriesName";
            this.tbCategoriesName.Size = new System.Drawing.Size(121, 20);
            this.tbCategoriesName.TabIndex = 0;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(104, 101);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(121, 20);
            this.textBoxID.TabIndex = 1;
            this.textBoxID.Text = "ID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(241, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // btAddCategorie
            // 
            this.btAddCategorie.Location = new System.Drawing.Point(241, 101);
            this.btAddCategorie.Name = "btAddCategorie";
            this.btAddCategorie.Size = new System.Drawing.Size(121, 23);
            this.btAddCategorie.TabIndex = 3;
            this.btAddCategorie.Text = "Add Categorie";
            this.btAddCategorie.UseVisualStyleBackColor = true;
            // 
            // btUpdateCategories
            // 
            this.btUpdateCategories.Location = new System.Drawing.Point(104, 175);
            this.btUpdateCategories.Name = "btUpdateCategories";
            this.btUpdateCategories.Size = new System.Drawing.Size(258, 23);
            this.btUpdateCategories.TabIndex = 4;
            this.btUpdateCategories.Text = "Update Categorie";
            this.btUpdateCategories.UseVisualStyleBackColor = true;
            // 
            // EditCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 361);
            this.Controls.Add(this.btUpdateCategories);
            this.Controls.Add(this.btAddCategorie);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.tbCategoriesName);
            this.Name = "EditCategorie";
            this.Text = "EditCategorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCategoriesName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btAddCategorie;
        private System.Windows.Forms.Button btUpdateCategories;
    }
}