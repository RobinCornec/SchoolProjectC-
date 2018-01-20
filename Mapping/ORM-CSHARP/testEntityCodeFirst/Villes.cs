using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace testEntityCodeFirst
{
    class Villes
    {
        public int Id { get; set; }
        public string Nom { get; set; }     
        public string Departement { get; set; }
        public virtual ICollection<Personnes> Personnes { get; set; }
    }
}
