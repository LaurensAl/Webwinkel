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


        public EditArticle(WinkelEntities db)                                           //WORKS
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Program.db = db;
            btUpdateArticle.Hide();
            tbCurrentCat.Hide();
            lbCurrentCat.Hide();
            fillCategorie();//fill cat with method
            fillSupplier();
        }
        public EditArticle(Article article, Category category, Supplier supplier, WinkelEntities db)// +4                     //WORKS
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            btAddArticle.Hide();
            Program.db = db;
            this.category = category;
            this.article = article;
            this.supplier = supplier;
            textBoxArticleID.Text = article.ID.ToString();
            textBoxName.Text = article.Name;
            textBoxDescription.Text = article.Description;
            textBoxStock.Text = article.Stock.ToString();
            tbCurrentCat.Text = category.Name;
            fillCategorie();//fill cat with method
        }

        private void fillCategorie()//method filler cat                                               //WORKS
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
                artnew.AddCatID((int)cbCategories.SelectedValue);
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
