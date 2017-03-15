using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webwinkel
{
    public partial class Customer
    {
        public Customer(string firstname, string lastname, string adress, int phonenumber, string bankaccountnumber)
        {
            FirstName = firstname;
            Lastname = lastname;
            Adress = adress;
            Phonenumber = phonenumber;
            Bankaccountnumber = bankaccountnumber;
        }
    }
}
