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
        WinkelEntities db = new WinkelEntities();//db

        public MainMenu()//init
        {
            InitializeComponent();
            ListCustomers();
        }
        private void MainMenu_Activated(object sender, EventArgs e)//refresh window
        {
            ListCustomers();
        }
        public void ListCustomers()//startup -> MainMenu
        {
            listView3.Items.Clear();
            foreach (Customer customers in db.Customers)
            {
                string[] mycustomers = { customers.ID.ToString(), customers.FirstName, customers.Lastname, customers.Adress, customers.Phonenumber.ToString(), customers.Bankaccountnumber };

                ListViewItem customerlist = new ListViewItem(mycustomers);
                customerlist.Name = customers.ID.ToString();
                listView3.Items.Add(customerlist);
            }
        }
        private void btEditCustomer_Click_1(object sender, EventArgs e)//editbuttonCus
        {
          if (listView3.SelectedItems.Count > 0)
            {
                int outcome = 1;
                int.TryParse(listView3.SelectedItems[0].Name, out outcome);
                Customer customer = db.Customers.Find(outcome);
                EditCustomer customeredit = new EditCustomer(customer, db);
                customeredit.Show();
            }
        }
        private void btAddCustomers_Click(object sender, EventArgs e)//addbuttonCus
        {
            EditCustomer customEdit = new EditCustomer(db);
            customEdit.Show();
        }

        private void btAddArticle_Click(object sender, EventArgs e)//addbuttonArt
        {
            EditArticle articleAdd = new EditArticle();
            articleAdd.Show();
        }

        private void btEditArticle_Click(object sender, EventArgs e)//editbuttonArt
        {
            int outcome = 1;
            int.TryParse(listView2.SelectedItems[0].Name, out outcome);
            
            EditArticle articleEdit = new EditArticle();
            articleEdit.Show();
        }
    }
}
