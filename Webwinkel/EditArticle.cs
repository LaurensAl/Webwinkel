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
        WinkelEntities db = new WinkelEntities();
        public EditArticle()
        {
            InitializeComponent();
        }

        public EditArticle(Article article, WinkelEntities db, Category category)//Article,cotr
        {
            InitializeComponent();
            this.db = db;
            this.article = article;
            this.category = category; // TODO
            textBoxArticleID.Text = article.ID.ToString();
            textBoxName.Text = article.Name;
            textBoxDescription.Text = article.Description;
            textBoxStock.Text = this.article.Stock.ToString();
            cbCategories.Text = this.category.Name;// TODO

        }

        private void btUpdateArticle_Click(object sender, EventArgs e)//SaveEdit
        {

        }
    }
}
