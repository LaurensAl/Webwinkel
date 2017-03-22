using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webwinkel
{
    public partial class Supplier
    {
        public Supplier(string companyname, string adress, int phonenumber, string email )
        {
            CompanyName = companyname;
            Adress = adress;
            PhoneNumber = phonenumber;
            EmailAdress= email;

        }

    }
}
