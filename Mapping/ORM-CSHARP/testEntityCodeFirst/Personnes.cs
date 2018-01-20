using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testEntityCodeFirst
{
    class Personnes
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public virtual Villes Ville { get; set; }
    }
}
