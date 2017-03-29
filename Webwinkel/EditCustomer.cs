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

        public EditCustomer()// to add                                                  //WORKS
        {
            InitializeComponent();
            btUpdate.Hide();
        }

        public EditCustomer(Customer customer)//to edit                                  //WORKS
        {
            InitializeComponent();
            btSave.Hide();
            this.customer = customer;
            tbArticleID.Text = customer.ID.ToString();
            textBoxFirstName.Text = customer.FirstName;
            textBoxLastName.Text = customer.Lastname;
            textBoxAdress.Text = customer.Adress;
            textBoxPhoneNumber.Text = customer.Phonenumber.ToString();
            textBoxBankAccount.Text = customer.Bankaccountnumber;
        }
        private void btUpdate_Click(object sender, EventArgs e)//saveEdit               //WORKS
        {
            int value;

            if (int.TryParse(textBoxPhoneNumber.Text, out value) && (int.TryParse(textBoxBankAccount.Text, out value)))
            {
                int outcome;
                customer.FirstName = textBoxFirstName.Text;
                customer.Lastname = textBoxLastName.Text;
                customer.Adress = textBoxAdress.Text;
                int.TryParse(textBoxPhoneNumber.Text, out outcome);
                customer.Phonenumber = outcome;
                customer.Bankaccountnumber = textBoxBankAccount.Text;
                Program.db.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("BankAccount and/or Phonenumber is incorrect!\n It can only be a number, please try again!");
            }

        }
        private void btSave_Click(object sender, EventArgs e)//saveNew                  //WORKS
        {
            int value;

            if (int.TryParse(textBoxPhoneNumber.Text, out value) && (int.TryParse(textBoxBankAccount.Text, out value)))
            {
                Customer customerTemp = new Customer(textBoxFirstName.Text, textBoxLastName.Text, textBoxAdress.Text, Int32.Parse(textBoxPhoneNumber.Text), textBoxBankAccount.Text);
                Program.db.Customers.Add(customerTemp);
                Program.db.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("BankAccount and/or Phonenumber is incorrect!\n It can only be a number, please try again!");
            }
        }
    }
}
