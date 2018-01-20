using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace EntityCodeFirst
{
    class BoutiqueContext : DbContext
    {
        //J'appelle le constructeur parent avec le
        //nom de la chaine de connexion
        public BoutiqueContext() : base("Boutique") { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
