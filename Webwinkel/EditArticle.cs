using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webwinkel
{
    public partial class EditArticle : Form
    {
        Article article = new Article();
        Category category = new Category();
        Supplier supplier = new Supplier();

        public EditArticle()     // to Add article                                                              //WORKS
        {
            InitializeComponent();// required for startup
            StartPosition = FormStartPosition.CenterScreen; //pops up screen in center
            btUpdateArticle.Hide();//hide update button
            fillCategorie();//fill cat with method
            fillSupplier();//fill sup with method
        }
        public EditArticle(Article article, Category category, Supplier supplier)// +4, to Edit article               //WORKS
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            btAddArticle.Hide();
            this.category = category;
            this.article = article;
            this.supplier = supplier;
            textBoxArticleID.Text = article.ID.ToString();
            textBoxName.Text = article.Name;
            textBoxDescription.Text = article.Description;
            textBoxStock.Text = article.Stock.ToString();
            fillCategorie();
            cbCategories.SelectedValue = category.ID;// fills combobox(CAT)with existing value;
            fillSupplier();
            cbSupplier.SelectedValue = supplier.ID;// fills combobox(SUP)with existing value;
        }

        private void fillCategorie()//method filler category                                               //WORKS
        {
            Dictionary<int, string> items = new Dictionary<int, string>();

            foreach (Category categories in Program.db.Categories)
            {
                items.Add(categories.ID, categories.Name);
                cbCategories.DataSource = new BindingSource(items, null);
                cbCategories.ValueMember = "Key";
                cbCategories.DisplayMember = "Value";
            }

        }
        private void fillSupplier()//method filler supp                                              //WORKS
        {
            Dictionary<int, string> items = new Dictionary<int, string>();

            foreach (Supplier supplier in Program.db.Suppliers)
            {
                items.Add(supplier.ID, supplier.CompanyName);
                cbSupplier.DataSource = new BindingSource(items, null);
                cbSupplier.ValueMember = "Key";
                cbSupplier.DisplayMember = "Value";
            }
        }

        private void btUpdateArticle_Click(object sender, EventArgs e)//SaveEdit                        //WORKS
        {
            int value;

            if (int.TryParse(textBoxStock.Text, out value))
            {

                article.Name = textBoxName.Text;
                article.Description = textBoxDescription.Text;
                article.Stock = int.Parse(textBoxStock.Text);
                Category category = Program.db.Categories.Find(cbCategories.SelectedValue);
                article.CategorieID = category.ID;
                Supplier supplier = Program.db.Suppliers.Find(cbSupplier.SelectedValue);
                article.SupplierID = supplier.ID;
                Program.db.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("Stock can only be a number, please try again!");
            }

        }
        private void btAddArticle_Click(object sender, EventArgs e)//AddArticle                         //WORKS
        {
            int value;

            if (int.TryParse(textBoxStock.Text, out value))
            {
                Article artnew = new Article(textBoxName.Text, textBoxDescription.Text, int.Parse(textBoxStock.Text));
                Program.db.Articles.Add(artnew);
                artnew.AddFK((int)cbCategories.SelectedValue, (int)cbSupplier.SelectedValue);
                Program.db.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("Stock can only be a number, please try again!");

            }
        }
    }
}
