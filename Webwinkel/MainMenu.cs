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

        public MainMenu()//init without data                                                        //WORKS, DUH!
        {
            InitializeComponent();
        }
        /////////////////////////////////////////////////////////////////////////////////////////refresh/Refocus MainMenu
        private void MainMenu_Activated(object sender, EventArgs e)                                     //WORKS
        {
            ListCustomers();
            ListCategories();
            ListArticles();
            ListSuppliers();
            ListOrders();

        }
        //////////////////////////////////////////////////////////////////////////////////Methods for fillingup data -> MainMenu
        public void ListCategories()//startup/refresh                                                        //WORKS
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
        public void ListCustomers()//startup/refresh                                                         //WORKS
        {
            listViewCust.Items.Clear();
            foreach (Customer customers in Program.db.Customers)
            {
                string[] mycustomers = { customers.ID.ToString(), customers.FirstName, customers.Lastname, customers.Adress, customers.Phonenumber.ToString(), customers.Bankaccountnumber };

                ListViewItem customerlist = new ListViewItem(mycustomers);
                customerlist.Name = customers.ID.ToString();
                listViewCust.Items.Add(customerlist);
            }

            Dictionary<int, string> items = new Dictionary<int, string>(); // cb @orders                   //WORKS

            foreach (Customer customer in Program.db.Customers)
            {
                items.Add(customer.ID, customer.FirstName);
                cbCustomers.DataSource = new BindingSource(items, null);
                cbCustomers.ValueMember = "Key";
                cbCustomers.DisplayMember = "Value";
            }

        }
        public void ListArticles()//startup/refresh                                                      //WORKS
        {
            listViewArticles.Items.Clear();
            foreach (Article articles in Program.db.Articles)
            {
                string[] myarticles = { articles.ID.ToString(), articles.Name, articles.Description, articles.Stock.ToString(), articles.CategorieID.ToString(), articles.SupplierID.ToString() };
                ListViewItem articleslist = new ListViewItem(myarticles);
                articleslist.Name = articles.ID.ToString();
                listViewArticles.Items.Add(articleslist);
            }
        }
        public void ListSuppliers()//startup/refresh                                                      //WORKS
        {
            listViewSupplier.Items.Clear();
            foreach (Supplier suppliers in Program.db.Suppliers)
            {
                string[] mysuppliers = { suppliers.ID.ToString(), suppliers.CompanyName, suppliers.Adress, suppliers.PhoneNumber.ToString(), suppliers.EmailAdress };
                ListViewItem supplierlist = new ListViewItem(mysuppliers);
                supplierlist.Name = suppliers.ID.ToString();
                listViewSupplier.Items.Add(supplierlist);
            }
        }
        public void ListOrders()                                                                        //Untested, but should work
        {
            Dictionary<int, string> items = new Dictionary<int, string>();

            foreach (Order order in Program.db.Orders)
            {
                items.Add(order.ID, order.ID.ToString());//only need ID
                cbOrders.DataSource = new BindingSource(items, null);
                cbOrders.ValueMember = "Key";
                cbOrders.DisplayMember = "Value";
            }

            lvOrders.Items.Clear();

            //if (cbOrders == null)
            //{ /// fills Orders Listview if available
            //    int OrderID = (int)cbOrders.SelectedValue;
            //    Order tempOrder = Program.db.Orders.Find(OrderID);

            //    if (tempOrder != null)
            //    {

            //        //fill list
            //        foreach (??)
            //        {
            //            string[] data = {??

            //    };
            //            ListViewItem item = new ListViewItem(data);
            //            lvOrders.Items.Add(item);
            //        }
            //    }
            //}
        }

        /////////////////////////////////////////////////////////////////////////////////////////Buttons Customer

        private void btEditCustomer_Click_1(object sender, EventArgs e)//editbuttonCus                           //WORKS
        {
            if (listViewCust.SelectedItems.Count > 0)
            {
                int outcome = 1;
                int.TryParse(listViewCust.SelectedItems[0].Name, out outcome);
                Customer customer = Program.db.Customers.Find(outcome);
                EditCustomer customeredit = new EditCustomer(customer, Program.db);
                customeredit.Show();
            }
        }
        private void btAddCustomers_Click(object sender, EventArgs e)//addbuttonCus                             //WORKS
        {
            EditCustomer customEdit = new EditCustomer();
            customEdit.Show();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////Buttons Articles
        private void btAddArticle_Click(object sender, EventArgs e)//addbuttonArt                               //WORKS
        {
            EditArticle articleAdd = new EditArticle(Program.db);
            articleAdd.Show();
        }

        private void btEditArticle_Click(object sender, EventArgs e)//editbuttonArt                                 //WORKS
        {
            if (listViewArticles.SelectedItems.Count > 0)
            {
                int outcome = 1;
                int.TryParse(listViewArticles.SelectedItems[0].Name, out outcome);
                Article article = Program.db.Articles.Find(outcome);
                Category category = Program.db.Categories.Find(article.CategorieID);
                Supplier supplier = Program.db.Suppliers.Find(article.SupplierID);
                EditArticle articleedit = new EditArticle(article, category, supplier, Program.db);
                articleedit.Show();
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////Buttons Category
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
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Buttons Suppliers
        private void btSuppAdd_Click(object sender, EventArgs e)                                            //WORKS
        {
            EditSupplier supplierAdd = new EditSupplier(Program.db);
            supplierAdd.Show();
        }
        private void btSuppEdit_Click(object sender, EventArgs e)                                           //WORKS
        {
            if (listViewSupplier.SelectedItems.Count > 0)
            {
                int outcome = 1;
                int.TryParse(listViewSupplier.SelectedItems[0].Name, out outcome);
                Supplier supplier = Program.db.Suppliers.Find(outcome);
                EditSupplier supplieredit = new EditSupplier(supplier, Program.db);
                supplieredit.Show();
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Buttons Order
        private void btCreateOrder_Click(object sender, EventArgs e)
        {

        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Buttons Search

        private void btsearch_Click(object sender, EventArgs e)                                     //WORKS
        {
            listviewSearch.Items.Clear();
            if (tbArticle != null)
            {
                string artsearchterm = tbArticle.Text;

                var vararticle = from article in Program.db.Articles
                                 where article.Name.Contains(artsearchterm)
                                 select article;


                if (!artsearchterm.Any())
                {
                    listviewSearch.Items.Clear();
                    MessageBox.Show("No Article under that name!");
                    btsearch.Text = "Search Article Name";
                }
                else
                {

                    foreach (Article article in vararticle)
                    {

                        string[] myarticle = { article.ID.ToString(), article.Name, article.Description, article.Stock.ToString() };

                        ListViewItem searcharticle = new ListViewItem(myarticle);
                        searcharticle.Name = article.ID.ToString();
                        listviewSearch.Items.Add(searcharticle);
                        btsearch.Text = "Search Other Article";
                    }

                }
            }
        }
    }

}




