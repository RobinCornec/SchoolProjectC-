using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace EntityCodeFirst
{
    class Category
    {
        public int Id { get; set; }

        [MaxLength(200), StringLength(200)]
        public string Nom { get; set; }     
        public string Description { get; set; }

        //Et mettre un ICollection pour dire que Category possède une collection de produits clé étrangère produit-categ
        public virtual ICollection<Product> Produits { get; set; }
    }
}
