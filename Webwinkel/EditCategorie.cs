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
    public partial class EditCategorie : Form
    {
        Category category;
       //Winkelentities db;

        public EditCategorie()//default
        {
            InitializeComponent();
        }
        public EditCategorie(WinkelEntities db)// to save
        {
            InitializeComponent();
            btEditCategorie.Hide();
            Program.db = db;
        }

        public EditCategorie(Category category, WinkelEntities db)//to edit
        {
            InitializeComponent();
            Program.db = db;
            btAddCategorie.Hide();
            this.category = category;
            tbCategoryName.Text = category.Name;
        }

        private void btAddCategorie_Click(object sender, EventArgs e)//saveNew
        {
            Category categoryTemp = new Category(tbCategoryName.Text);
            Program.db.Categories.Add(categoryTemp);
            Program.db.SaveChanges();
            Close();
        }

        private void btEditCategorie_Click(object sender, EventArgs e)//saveEdit
        {
            Category categoryTemp = new Category(tbCategoryName.Text);
            Program.db.SaveChanges();
            Close();
        }
    }
}
