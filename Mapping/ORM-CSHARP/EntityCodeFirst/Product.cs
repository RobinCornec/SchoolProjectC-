using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityCodeFirst
{
    class Product
    {
        //id crée auto un id avec AI et primary key
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Descritption { get; set; }
        public double PrixUnitaire { get; set; }

        //virtual : pour préciser une clé étrangère produit-categ
        public virtual Category Categorie { get; set; }
    }
}
