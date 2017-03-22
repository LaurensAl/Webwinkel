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


        public EditArticle(WinkelEntities db)                                           //WORKS
        {
            InitializeComponent();
            Program.db = db;
            btUpdateArticle.Hide();
            fillCategorie();//fill cat with method
        }
        public EditArticle(WinkelEntities db, Article article)// +2                     //WORKS (does nog bring up original categorieID, fills it only!)
        {
            InitializeComponent();
            btAddArticle.Hide();
            Program.db = db;
            textBoxArticleID.Text = article.ID.ToString();
            textBoxName.Text = article.Name;
            textBoxDescription.Text = article.Description;
            textBoxStock.Text = article.Stock.ToString();
            fillCategorie();

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
        private void btUpdateArticle_Click(object sender, EventArgs e)//SaveEdit                        //TODO
        {

            article.Name = textBoxName.Text;
            article.Description = textBoxDescription.Text;
            article.Stock = int.Parse(textBoxStock.Text);
            int catID = (int)cbCategories.SelectedValue;
            //Category category = Program.db.Categories.Find(catID);
            article.CategorieID = catID;///??????does not save data
            Program.db.SaveChanges();
            Close();
        }
        private void btAddArticle_Click(object sender, EventArgs e)//AddArticle                         //WORKS
        {

            Article artnew = new Article(textBoxName.Text, textBoxDescription.Text, int.Parse(textBoxStock.Text));
            Program.db.Articles.Add(artnew);
            artnew.AddCatID((int)cbCategories.SelectedValue);
            Program.db.SaveChanges();
            Close();

        }
    }
}
