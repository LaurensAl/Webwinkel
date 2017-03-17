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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.btAddCategorie = new System.Windows.Forms.Button();
            this.btEditCategorie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "ID";
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Location = new System.Drawing.Point(77, 98);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.Size = new System.Drawing.Size(121, 20);
            this.tbCategoryName.TabIndex = 1;
            // 
            // btAddCategorie
            // 
            this.btAddCategorie.Location = new System.Drawing.Point(204, 67);
            this.btAddCategorie.Name = "btAddCategorie";
            this.btAddCategorie.Size = new System.Drawing.Size(119, 20);
            this.btAddCategorie.TabIndex = 3;
            this.btAddCategorie.Text = "Add Category";
            this.btAddCategorie.UseVisualStyleBackColor = true;
            this.btAddCategorie.Click += new System.EventHandler(this.btAddCategorie_Click);
            // 
            // btEditCategorie
            // 
            this.btEditCategorie.Location = new System.Drawing.Point(204, 98);
            this.btEditCategorie.Name = "btEditCategorie";
            this.btEditCategorie.Size = new System.Drawing.Size(119, 20);
            this.btEditCategorie.TabIndex = 4;
            this.btEditCategorie.Text = "Update Category";
            this.btEditCategorie.UseVisualStyleBackColor = true;
            this.btEditCategorie.Click += new System.EventHandler(this.btEditCategorie_Click);
            // 
            // EditCategorie
            // 
            this.ClientSize = new System.Drawing.Size(419, 281);
            this.Controls.Add(this.btEditCategorie);
            this.Controls.Add(this.btAddCategorie);
            this.Controls.Add(this.tbCategoryName);
            this.Controls.Add(this.textBox1);
            this.Name = "EditCategorie";
            this.Text = "Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbCategoryName;
        private System.Windows.Forms.Button btAddCategorie;
        private System.Windows.Forms.Button btEditCategorie;
    }
}