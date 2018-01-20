using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace testEntityCodeFirst
{
    class BoutiqueContext : DbContext
    {
        public BoutiqueContext() : base("Boutique") { }

        public DbSet<Personnes> Personnes { get; set; }
        public DbSet<Villes> Villes { get; set; }

    }
}
