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
        WinkelEntities db = new WinkelEntities();

        public MainMenu()
        {
            InitializeComponent();
            ListCustomers();
        }
        private void MainMenu_Activated(object sender, EventArgs e)
        {
            ListCustomers();
        }
        public void ListCustomers()
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
        private void btEditCustomer_Click_1(object sender, EventArgs e)
        {
            if (listView3.SelectedItems[0].Name != null)
            {
                int outcome = 1;
                int.TryParse(listView3.SelectedItems[0].Name, out outcome);
                Customer customer = db.Customers.Find(outcome);
                EditCustomer form = new EditCustomer(customer, db);
                form.Show();
            }
        }
        private void btAddCustomers_Click(object sender, EventArgs e)
        {
            EditCustomer CustomEdit = new EditCustomer(db);
            CustomEdit.Show();
        }
    }
}
