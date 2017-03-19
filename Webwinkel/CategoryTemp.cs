using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webwinkel
{
    public partial class Category
    {
        public Article articleitem = new Article();
       
        public Category(string name)
        {
            Name = name;
        }

    }
 
}
