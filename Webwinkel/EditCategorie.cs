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
        Categories category = new Categories();
        WinkelEntities db = new WinkelEntities();
        public EditCategorie()
        {
            InitializeComponent();
        }
        private void EditCategorie_Load(object sender, EventArgs e)
        {
            comboBox1.Text = this.category.Name;
        }
        private void tbCategoriesName_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btUpdateCategories_Click(object sender, EventArgs e)
        {

        }

        private void btAddCategorie_Click(object sender, EventArgs e)
        {

        }

       
    }
}
