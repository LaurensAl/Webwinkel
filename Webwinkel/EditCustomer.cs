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
            this.db = db;
        }
        public EditCustomer(Customer customer, WinkelEntities db)//edit
        {
            InitializeComponent();
            this.db = db;
            this.customer = customer;
            textBox1.Text = this.customer.ID.ToString();
            textBoxFirstName.Text = this.customer.FirstName;
            textBoxLastName.Text = this.customer.Lastname;
            textBoxAdress.Text = this.customer.Adress;
            textBoxPhoneNumber.Text = this.customer.Phonenumber.ToString();
            textBoxBankAccount.Text = this.customer.Bankaccountnumber;
        }
        private void btSave_Click(object sender, EventArgs e)//save
        {
            Customer CustomerTemp = new Customer(textBoxFirstName.Text, textBoxLastName.Text, textBoxAdress.Text, Int32.Parse(textBoxPhoneNumber.Text), textBoxBankAccount.Text);
            db.Customers.Add(CustomerTemp);
            db.SaveChanges();
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
