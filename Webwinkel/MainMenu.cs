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
        public MainMenu()//init
        {
            InitializeComponent();
            ListCustomers();
        }
        private void MainMenu_Activated(object sender, EventArgs e)//refresh/Refocus MainMenu       //WORKS
        {
            ListCustomers();
            ListCategories();
            ListArticles();
           // ListOrders();

        }
        public void ListCategories()//startup/refresh                                   //WORKS
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

        public void ListCustomers()//startup/refresh                                    //WORKS
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
        public void ListArticles()                                                      //WORKS
        {
            listViewArticles.Items.Clear();
            foreach (Article articles in Program.db.Articles)
            {
                string[] myarticles = { articles.ID.ToString(), articles.Name, articles.Description, articles.Stock.ToString(), articles.CategorieID.ToString() };
                ListViewItem articleslist = new ListViewItem(myarticles);
                articleslist.Name = articles.ID.ToString();
                listViewArticles.Items.Add(articleslist);
            }
        }
        public void ListOrders()
        {
            //TO DOOOOOOOOOOOOOOOOOOOOOOOOOOOO
            //listViewOrders.Items.Clear();
            //foreach (Order orders in Program.db.Orders)
            //{
            //    string[] myorders = { orders.ID.ToString(), orders.OrdersArticles.ToString() };
            //    ListViewItem orderslist = new ListViewItem(myorders);
            //    orderslist.Name = orders.ID.ToString();
            //    listViewArticles.Items.Add(orderslist);
            //}

        }

        private void btEditCustomer_Click_1(object sender, EventArgs e)//editbuttonCus              //WORKS
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
        private void btAddCustomers_Click(object sender, EventArgs e)//addbuttonCus                     //WORKS
        {
            EditCustomer customEdit = new EditCustomer();
            customEdit.Show();
        }

        private void btAddArticle_Click(object sender, EventArgs e)//addbuttonArt                       //WORKS
        {
            EditArticle articleAdd = new EditArticle(Program.db);
            articleAdd.Show();
        }

        private void btEditArticle_Click(object sender, EventArgs e)//editbuttonArt
        {
            if (listViewArticles.SelectedItems.Count > 0)
            {
                int outcome = 1;
                int.TryParse(listView3.SelectedItems[0].Name, out outcome);
                Customer customer = Program.db.Customers.Find(outcome);
                EditCustomer customeredit = new EditCustomer(customer, Program.db);
                customeredit.Show();
                //TO DO


                int catID = (int)cbCategoriesPr.SelectedValue;// int var -> typ(int) ->combobox value
                Category category = Program.db.Categories.Find(catID);

                //     EditArticle articleAdd = new EditArticle(Program.db, category, article);
                // articleAdd.Show();
            }
        }

        private void btAddCategory_Click(object sender, EventArgs e)//addbuttonCat                        //WORKS
        {
            EditCategorie categorieAdd = new EditCategorie(Program.db);
            categorieAdd.Show();
        }
        private void btEditCategory_Click(object sender, EventArgs e)//editbuttonCat                       //WORKS
        {
            int catID = (int)cbCategoriesPr.SelectedValue;// int var -> typ(int) ->combobox value
            Category category = Program.db.Categories.Find(catID); // find value ->catID
            EditCategorie categorieEdit = new EditCategorie(category, Program.db);// obj(catID) + db
            categorieEdit.Show(cbCategoriesPr);// show form
        }

        private void btAddToOrder_Click(object sender, EventArgs e)
        {
            ////// Add order + articles





        }
    }
}

