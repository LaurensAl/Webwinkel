﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webwinkel
{
    public partial class Article
    {
        
        public Article(string name, string description, int stock)//cotr
        {
            Name = name;
            Description = description;
            Stock = stock;
        }
        public void AddFK(int CatID, int SupID)                                     //WORKS
        {
            Category category = Program.db.Categories.Find(CatID);
            CategorieID = category.ID;
            
            Supplier supplier = Program.db.Suppliers.Find(SupID);
            SupplierID = supplier.ID;

            Program.db.SaveChanges();

        }



    }
}
