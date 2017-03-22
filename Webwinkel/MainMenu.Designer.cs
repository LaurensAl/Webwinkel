namespace Webwinkel
{
    partial class MainMenu
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
            this.sbarticle = new System.Windows.Forms.TextBox();
            this.btsearch = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewArticles = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btEditArticle = new System.Windows.Forms.Button();
            this.btAddToOrder = new System.Windows.Forms.Button();
            this.btAddArticle = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAddCustomers = new System.Windows.Forms.Button();
            this.btEditCustomer = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOrderAmount = new System.Windows.Forms.TextBox();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btResetOrder = new System.Windows.Forms.Button();
            this.btRemoveRow = new System.Windows.Forms.Button();
            this.btAddCategory = new System.Windows.Forms.Button();
            this.btEditCategory = new System.Windows.Forms.Button();
            this.cbCategoriesPr = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // sbarticle
            // 
            this.sbarticle.Location = new System.Drawing.Point(28, 46);
            this.sbarticle.Name = "sbarticle";
            this.sbarticle.Size = new System.Drawing.Size(179, 20);
            this.sbarticle.TabIndex = 4;
            // 
            // btsearch
            // 
            this.btsearch.AccessibleName = "";
            this.btsearch.Location = new System.Drawing.Point(231, 46);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(130, 20);
            this.btsearch.TabIndex = 1;
            this.btsearch.Text = "Search Article Name";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(28, 86);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(500, 167);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Article ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Amount in Stock";
            this.columnHeader4.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(365, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Laurens Webwinkel";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.btsearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sbarticle);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(537, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 285);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search For Your Article";
            // 
            // listViewArticles
            // 
            this.listViewArticles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader18});
            this.listViewArticles.FullRowSelect = true;
            this.listViewArticles.GridLines = true;
            this.listViewArticles.Location = new System.Drawing.Point(22, 19);
            this.listViewArticles.Name = "listViewArticles";
            this.listViewArticles.Size = new System.Drawing.Size(475, 168);
            this.listViewArticles.TabIndex = 5;
            this.listViewArticles.UseCompatibleStateImageBehavior = false;
            this.listViewArticles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Article ID";
            this.columnHeader5.Width = 58;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Name";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Description";
            this.columnHeader7.Width = 140;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Stock";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Category";
            this.columnHeader18.Width = 72;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.btEditArticle);
            this.groupBox2.Controls.Add(this.btAddToOrder);
            this.groupBox2.Controls.Add(this.btAddArticle);
            this.groupBox2.Controls.Add(this.listViewArticles);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 242);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Browse Articles";
            // 
            // btEditArticle
            // 
            this.btEditArticle.AccessibleName = "";
            this.btEditArticle.Location = new System.Drawing.Point(396, 203);
            this.btEditArticle.Name = "btEditArticle";
            this.btEditArticle.Size = new System.Drawing.Size(101, 20);
            this.btEditArticle.TabIndex = 7;
            this.btEditArticle.Text = "Edit Article";
            this.btEditArticle.UseVisualStyleBackColor = true;
            this.btEditArticle.Click += new System.EventHandler(this.btEditArticle_Click);
            // 
            // btAddToOrder
            // 
            this.btAddToOrder.AccessibleName = "";
            this.btAddToOrder.Location = new System.Drawing.Point(22, 203);
            this.btAddToOrder.Name = "btAddToOrder";
            this.btAddToOrder.Size = new System.Drawing.Size(101, 20);
            this.btAddToOrder.TabIndex = 5;
            this.btAddToOrder.Text = "Add to Order";
            this.btAddToOrder.UseVisualStyleBackColor = true;
            this.btAddToOrder.Click += new System.EventHandler(this.btAddToOrder_Click);
            // 
            // btAddArticle
            // 
            this.btAddArticle.AccessibleName = "";
            this.btAddArticle.Location = new System.Drawing.Point(266, 203);
            this.btAddArticle.Name = "btAddArticle";
            this.btAddArticle.Size = new System.Drawing.Size(101, 20);
            this.btAddArticle.TabIndex = 6;
            this.btAddArticle.Text = "Add Article";
            this.btAddArticle.UseVisualStyleBackColor = true;
            this.btAddArticle.Click += new System.EventHandler(this.btAddArticle_Click);
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(28, 50);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(500, 190);
            this.listView3.TabIndex = 5;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID";
            this.columnHeader9.Width = 40;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Firstname";
            this.columnHeader10.Width = 90;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Lastname";
            this.columnHeader11.Width = 90;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Adress";
            this.columnHeader12.Width = 155;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Phonenumber";
            this.columnHeader13.Width = 100;
            // 
            // btAddCustomers
            // 
            this.btAddCustomers.AccessibleName = "";
            this.btAddCustomers.Location = new System.Drawing.Point(421, 19);
            this.btAddCustomers.Name = "btAddCustomers";
            this.btAddCustomers.Size = new System.Drawing.Size(101, 20);
            this.btAddCustomers.TabIndex = 5;
            this.btAddCustomers.Text = "Add Customer";
            this.btAddCustomers.UseVisualStyleBackColor = true;
            this.btAddCustomers.Click += new System.EventHandler(this.btAddCustomers_Click);
            // 
            // btEditCustomer
            // 
            this.btEditCustomer.AccessibleName = "";
            this.btEditCustomer.Location = new System.Drawing.Point(260, 19);
            this.btEditCustomer.Name = "btEditCustomer";
            this.btEditCustomer.Size = new System.Drawing.Size(101, 20);
            this.btEditCustomer.TabIndex = 9;
            this.btEditCustomer.Text = "Edit Customer";
            this.btEditCustomer.UseVisualStyleBackColor = true;
            this.btEditCustomer.Click += new System.EventHandler(this.btEditCustomer_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.btAddCustomers);
            this.groupBox3.Controls.Add(this.listView3);
            this.groupBox3.Controls.Add(this.btEditCustomer);
            this.groupBox3.Location = new System.Drawing.Point(537, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(558, 257);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customers Mangement";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightGray;
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.tbOrderAmount);
            this.groupBox4.Controls.Add(this.listViewOrders);
            this.groupBox4.Controls.Add(this.btResetOrder);
            this.groupBox4.Controls.Add(this.btRemoveRow);
            this.groupBox4.Location = new System.Drawing.Point(12, 260);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(519, 220);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Your Current Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total Items in Order";
            // 
            // tbOrderAmount
            // 
            this.tbOrderAmount.Location = new System.Drawing.Point(202, 21);
            this.tbOrderAmount.Name = "tbOrderAmount";
            this.tbOrderAmount.ReadOnly = true;
            this.tbOrderAmount.Size = new System.Drawing.Size(30, 20);
            this.tbOrderAmount.TabIndex = 5;
            this.tbOrderAmount.Text = "0";
            this.tbOrderAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.listViewOrders.FullRowSelect = true;
            this.listViewOrders.GridLines = true;
            this.listViewOrders.Location = new System.Drawing.Point(22, 60);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(475, 154);
            this.listViewOrders.TabIndex = 8;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader14
            // 
            this.columnHeader14.DisplayIndex = 1;
            this.columnHeader14.Text = "Article ID";
            this.columnHeader14.Width = 64;
            // 
            // columnHeader15
            // 
            this.columnHeader15.DisplayIndex = 2;
            this.columnHeader15.Text = "Name";
            this.columnHeader15.Width = 120;
            // 
            // columnHeader16
            // 
            this.columnHeader16.DisplayIndex = 3;
            this.columnHeader16.Text = "Description";
            this.columnHeader16.Width = 200;
            // 
            // columnHeader17
            // 
            this.columnHeader17.DisplayIndex = 0;
            this.columnHeader17.Text = "Amount";
            this.columnHeader17.Width = 69;
            // 
            // btResetOrder
            // 
            this.btResetOrder.AccessibleName = "";
            this.btResetOrder.Location = new System.Drawing.Point(396, 21);
            this.btResetOrder.Name = "btResetOrder";
            this.btResetOrder.Size = new System.Drawing.Size(101, 20);
            this.btResetOrder.TabIndex = 5;
            this.btResetOrder.Text = "Reset Order";
            this.btResetOrder.UseVisualStyleBackColor = true;
            // 
            // btRemoveRow
            // 
            this.btRemoveRow.AccessibleName = "";
            this.btRemoveRow.Location = new System.Drawing.Point(266, 21);
            this.btRemoveRow.Name = "btRemoveRow";
            this.btRemoveRow.Size = new System.Drawing.Size(101, 20);
            this.btRemoveRow.TabIndex = 9;
            this.btRemoveRow.Text = "Remove row";
            this.btRemoveRow.UseVisualStyleBackColor = true;
            // 
            // btAddCategory
            // 
            this.btAddCategory.AccessibleName = "";
            this.btAddCategory.Location = new System.Drawing.Point(28, 28);
            this.btAddCategory.Name = "btAddCategory";
            this.btAddCategory.Size = new System.Drawing.Size(101, 20);
            this.btAddCategory.TabIndex = 10;
            this.btAddCategory.Text = "Add Category";
            this.btAddCategory.UseVisualStyleBackColor = true;
            this.btAddCategory.Click += new System.EventHandler(this.btAddCategory_Click);
            // 
            // btEditCategory
            // 
            this.btEditCategory.AccessibleName = "";
            this.btEditCategory.Location = new System.Drawing.Point(158, 28);
            this.btEditCategory.Name = "btEditCategory";
            this.btEditCategory.Size = new System.Drawing.Size(101, 20);
            this.btEditCategory.TabIndex = 11;
            this.btEditCategory.Text = "Edit Category";
            this.btEditCategory.UseVisualStyleBackColor = true;
            this.btEditCategory.Click += new System.EventHandler(this.btEditCategory_Click);
            // 
            // cbCategoriesPr
            // 
            this.cbCategoriesPr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriesPr.FormattingEnabled = true;
            this.cbCategoriesPr.Location = new System.Drawing.Point(55, 27);
            this.cbCategoriesPr.Name = "cbCategoriesPr";
            this.cbCategoriesPr.Size = new System.Drawing.Size(121, 21);
            this.cbCategoriesPr.TabIndex = 12;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.LightGray;
            this.groupBox5.Controls.Add(this.cbCategoriesPr);
            this.groupBox5.Location = new System.Drawing.Point(12, 486);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(232, 78);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Preview Categories";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.LightGray;
            this.groupBox6.Controls.Add(this.btAddCategory);
            this.groupBox6.Controls.Add(this.btEditCategory);
            this.groupBox6.Location = new System.Drawing.Point(250, 486);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(281, 78);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Categories Management";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1102, 576);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Activated += new System.EventHandler(this.MainMenu_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox sbarticle;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewArticles;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button btAddCustomers;
        private System.Windows.Forms.Button btEditCustomer;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btAddToOrder;
        private System.Windows.Forms.Button btAddArticle;
        private System.Windows.Forms.Button btEditArticle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.Button btResetOrder;
        private System.Windows.Forms.Button btRemoveRow;
        private System.Windows.Forms.Button btAddCategory;
        private System.Windows.Forms.Button btEditCategory;
        private System.Windows.Forms.ComboBox cbCategoriesPr;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.TextBox tbOrderAmount;
        private System.Windows.Forms.Label label2;
    }
}

