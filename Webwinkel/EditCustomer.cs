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
    public partial class EditCustomer : Form
    {
        Customer customer = new Customer();
        WinkelEntities db;

        public EditCustomer()//default
        {
            InitializeComponent();
        }
        public EditCustomer(WinkelEntities db)//to add
        {
            InitializeComponent();
            btUpdate.Hide();
            this.db = db;
        }
        public EditCustomer(Customer customer, WinkelEntities db)//edit
        {
            InitializeComponent();
            btSave.Hide();
            this.db = db;
            this.customer = customer;
            tbArticleID.Text = customer.ID.ToString();
            textBoxFirstName.Text = customer.FirstName;
            textBoxLastName.Text = customer.Lastname;
            textBoxAdress.Text = customer.Adress;
            textBoxPhoneNumber.Text = customer.Phonenumber.ToString();
            textBoxBankAccount.Text = customer.Bankaccountnumber;
        }
        private void btSave_Click(object sender, EventArgs e)//save
        {
            Customer CustomerTemp = new Customer(textBoxFirstName.Text, textBoxLastName.Text, textBoxAdress.Text, Int32.Parse(textBoxPhoneNumber.Text), textBoxBankAccount.Text);
            db.Customers.Add(CustomerTemp);
            db.SaveChanges();
            Close();
        }
        private void btUpdate_Click(object sender, EventArgs e)//EditSave
        {
            int outcome;

            customer.FirstName = textBoxFirstName.Text;
            customer.Lastname = textBoxLastName.Text;
            customer.Adress = textBoxAdress.Text;
            int.TryParse(textBoxPhoneNumber.Text, out outcome);
            customer.Phonenumber = outcome;
            customer.Bankaccountnumber = textBoxBankAccount.Text;
            db.SaveChanges();
            Close();
        }
    }
}
