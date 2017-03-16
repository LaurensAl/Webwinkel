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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(217, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // btAddCategorie
            // 
            this.btAddCategorie.Location = new System.Drawing.Point(77, 132);
            this.btAddCategorie.Name = "btAddCategorie";
            this.btAddCategorie.Size = new System.Drawing.Size(261, 23);
            this.btAddCategorie.TabIndex = 3;
            this.btAddCategorie.Text = "Add Category";
            this.btAddCategorie.UseVisualStyleBackColor = true;
            // 
            // btEditCategorie
            // 
            this.btEditCategorie.Location = new System.Drawing.Point(77, 161);
            this.btEditCategorie.Name = "btEditCategorie";
            this.btEditCategorie.Size = new System.Drawing.Size(261, 23);
            this.btEditCategorie.TabIndex = 4;
            this.btEditCategorie.Text = "Update Category";
            this.btEditCategorie.UseVisualStyleBackColor = true;
            // 
            // EditCategorie
            // 
            this.ClientSize = new System.Drawing.Size(419, 281);
            this.Controls.Add(this.btEditCategorie);
            this.Controls.Add(this.btAddCategorie);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "EditCategorie";
            this.Text = "Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btAddCategorie;
        private System.Windows.Forms.Button btEditCategorie;
    }
}