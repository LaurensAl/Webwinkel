﻿using System;
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
        Article article;
        Category category;

        public EditArticle()
        {
            InitializeComponent();
        }
        public EditArticle(WinkelEntities db)
        {
            InitializeComponent();
            Program.db = db;
            btUpdateArticle.Hide();

            var cat = from category in Program.db.Categories
                      where category == article.Category
                      select category;

            fillCategorie(category);//fill category with method
        }

        private void fillCategorie(Category category)// look @ EditArticle + 1
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

        public EditArticle(Article article, WinkelEntities db, Category category)// +3
        {
            //todo

            fillCategorie(category);
        }
        private void btUpdateArticle_Click(object sender, EventArgs e)//SaveEdit
        {
            int outcome;

            article.Name = textBoxName.Text;
            article.Description = textBoxDescription.Text;
            int.TryParse(textBoxStock.Text, out outcome);
            article.Stock = outcome;
            category.ID = (int)cbCategories.SelectedValue;
            
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
