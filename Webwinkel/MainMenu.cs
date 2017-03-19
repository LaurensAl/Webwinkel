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
    public partial class MainMenu : Form
    {

        //WinkelEntities db = new WinkelEntities();


        public MainMenu()//init
        {
            InitializeComponent();
            ListCustomers();
        }
        private void MainMenu_Activated(object sender, EventArgs e)//refresh/Refocus MainMenu
        {
            ListCustomers();
            ListCategories();
            ListArticles();
            //ListOrders();  

        }
        public void ListCategories()//startup/refresh
        {
            Dictionary<int, string> items = new Dictionary<int, string>();

            foreach (Category category in Program.db.Categories)
            {
                items.Add(category.ID, category.Name);
                cbCategoriesPr.DataSource = new BindingSource(items, null);
                cbCategoriesPr.ValueMember = "Key";
                cbCategoriesPr.DisplayMember = "Value";

            }
        }

        public void ListCustomers()//startup/refresh
        {
            listView3.Items.Clear();
            foreach (Customer customers in Program.db.Customers)
            {
                string[] mycustomers = { customers.ID.ToString(), customers.FirstName, customers.Lastname, customers.Adress, customers.Phonenumber.ToString(), customers.Bankaccountnumber };

                ListViewItem customerlist = new ListViewItem(mycustomers);
                customerlist.Name = customers.ID.ToString();
                listView3.Items.Add(customerlist);
            }
        }
        public void ListArticles()
        {
            listView2.Items.Clear();
            foreach (Article articles in Program.db.Articles)
            {
                string[] myarticles = { articles.ID.ToString(), articles.Name, articles.Stock.ToString()};

                ListViewItem articleslist = new ListViewItem(myarticles);
                articleslist.Name = articles.ID.ToString();
                listView2.Items.Add(articleslist);
            }
        }


        private void btEditCustomer_Click_1(object sender, EventArgs e)//editbuttonCus
        {
            if (listView3.SelectedItems.Count > 0)
            {
                int outcome = 1;
                int.TryParse(listView3.SelectedItems[0].Name, out outcome);
                Customer customer = Program.db.Customers.Find(outcome);
                EditCustomer customeredit = new EditCustomer(customer, Program.db);
                customeredit.Show();
            }
        }
        private void btAddCustomers_Click(object sender, EventArgs e)//addbuttonCus
        {
            EditCustomer customEdit = new EditCustomer();
            customEdit.Show();
        }

        private void btAddArticle_Click(object sender, EventArgs e)//addbuttonArt
        {
            EditArticle articleAdd = new EditArticle();
            articleAdd.Show();
        }

        private void btEditArticle_Click(object sender, EventArgs e)//editbuttonArt
        {
            // TO DOO is onzin!

            if (listView2.SelectedItems.Count > 0)
            {
                int outcome = 1;
                int.TryParse(listView2.SelectedItems[0].Name, out outcome);
                Article article = Program.db.Articles.Find(outcome);
                Category category = Program.db.Categories.Find(outcome);//kan dit met FK?
                EditArticle articleEdit = new EditArticle(article, Program.db, category);
                articleEdit.Show();
            }
        }

        private void btAddCategory_Click(object sender, EventArgs e)//addbuttonCat
        {
            EditCategorie categorieAdd = new EditCategorie();
            categorieAdd.Show();
        }
        private void btEditCategory_Click(object sender, EventArgs e)//editbuttonCat
        {
            EditCategorie categorieEdit = new EditCategorie();
            categorieEdit.Show();
        }

    }
}
