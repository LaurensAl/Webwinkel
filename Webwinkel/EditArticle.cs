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

        public EditArticle()
        {
            InitializeComponent();
        }
        public EditArticle(WinkelEntities db)
        {
            InitializeComponent();
            Program.db = db;
            btUpdateArticle.Hide();
                     
            fillCategorie();//fill category with method
        }
        public EditArticle(WinkelEntities db, Category category, Article article)// +2
        {
            InitializeComponent();
            btAddArticle.Hide();
            Program.db = db;
            this.article = article;
            textBoxArticleID.Text = article.ID.ToString();
            textBoxName.Text = article.Name;
            textBoxDescription.Text = article.Description;
            textBoxDescription.Text = article.Stock.ToString();
            this.category = category;
            cbCategories.Text = category.Name;

        }


        private void fillCategorie()// look @ EditArticle + 1
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

       
        private void btUpdateArticle_Click(object sender, EventArgs e)//SaveEdit
        {
            article.Name = textBoxName.Text;
            article.Description = textBoxDescription.Text;
            article.Stock = int.Parse(textBoxStock.Text);
            category.ID = (int)cbCategories.SelectedItem;

            Program.db.SaveChanges();
            Close();
        }
        private void btAddArticle_Click(object sender, EventArgs e)//AddArticle
        {

            Article artnew = new Article(textBoxName.Text, textBoxDescription.Text, int.Parse(textBoxStock.Text));
            Program.db.Articles.Add(artnew);
            artnew.AddCatID((int)cbCategories.SelectedValue);
            Program.db.SaveChanges();
            Close();

        }
    }
}
