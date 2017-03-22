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
    public partial class EditSupplier : Form
    {
        Supplier supplier = new Supplier();

        public EditSupplier()//default NOT Used                                         
        {
            InitializeComponent();
        }
        public EditSupplier(WinkelEntities db) //Add Supplier                               //WORKS
        {
            InitializeComponent();
            btUpdateSupplier.Hide();
            Program.db = db;

        }
        public EditSupplier(Supplier supplier, WinkelEntities db)// Edit Supplier          //WORKS
        {
            InitializeComponent();
            btSave.Hide();
            Program.db = db;
            this.supplier = supplier;
            tbSupID.Text = supplier.ID.ToString();
            tbCompanySupp.Text = supplier.CompanyName;
            tbSuppAdress.Text = supplier.Adress;
            tbSupplierPhone.Text = supplier.PhoneNumber.ToString();
            tbSuppMail.Text = supplier.EmailAdress;
                    }

        private void btSave_Click(object sender, EventArgs e)                               //WORKS
        {
            Supplier supplierTemp = new Supplier(tbCompanySupp.Text, tbSuppAdress.Text, int.Parse(tbSupplierPhone.Text), tbSuppMail.Text);
            Program.db.Suppliers.Add(supplierTemp);
            Program.db.SaveChanges();
            Close();
        }

        private void btUpdate_Click(object sender, EventArgs e)                             //WORKS
        {
            int outcome;

            supplier.CompanyName = tbCompanySupp.Text;
            supplier.Adress = tbSuppAdress.Text;
            int.TryParse(tbSupplierPhone.Text, out outcome);
            supplier.PhoneNumber = outcome;
            supplier.EmailAdress = tbSuppMail.Text;
            Program.db.SaveChanges();
            Close();
        }
    }
}
