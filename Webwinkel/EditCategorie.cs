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


    public partial class EditCategorie : Form
    {
        Category category = new Category();

        public EditCategorie()                                                                  //WORKS
        {
            InitializeComponent();
            btUpdateCategorie.Hide();
        }

        public EditCategorie(Category category)//to edit                     //WORKS
        {
            InitializeComponent();
            btAddCategorie.Hide();
            this.category = category;
            tbCategoryName.Text = category.Name;
        }

        private void btAddCategorie_Click(object sender, EventArgs e)//saveNew                  //WORKS
        {
            Category categoryTemp = new Category(tbCategoryName.Text);
            Program.db.Categories.Add(categoryTemp);
            Program.db.SaveChanges();
            Close();
        }

        private void btEditCategorie_Click(object sender, EventArgs e)//saveEdit                //WORKS
        {
            category.Name = tbCategoryName.Text;
            Program.db.SaveChanges();
            Close();
        }
    }
}
