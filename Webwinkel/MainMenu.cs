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

        private void btEditCustomer_Click(object sender, EventArgs e)
        {
            EditCustomer CustomEdit = new EditCustomer(db);
            CustomEdit.Show();
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

        private void MainMenu_Activated(object sender, EventArgs e)
        {
            ListCustomers();
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
