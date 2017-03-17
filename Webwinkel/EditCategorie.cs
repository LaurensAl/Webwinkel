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
        WinkelEntities db = new WinkelEntities();
        Category category = new Category();

       
        public EditCategorie()
        {
            InitializeComponent();
        }
        public EditCategorie(WinkelEntities db)
        {

        }


        public EditCategorie(Category category, WinkelEntities db)//cotr
        {
            InitializeComponent();
            this.db = db;
            this.category = category;
            tbCategoryName.Text = category.Name;

        }
             
        private void btAddCategorie_Click(object sender, EventArgs e)//save
        {
            Category categoryTemp = new Category(tbCategoryName.Text);
            db.Categories.Add(categoryTemp);
            db.SaveChanges();
            Close();
        }

        private void btEditCategorie_Click(object sender, EventArgs e)//saveEdit
        {

        }
    }
}
