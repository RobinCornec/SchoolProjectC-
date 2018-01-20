using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testEntityCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db=new BoutiqueContext())
            {
                var laville = new Villes()
                {
                    Nom = "Nantes",
                    Departement = "LoireAtlantique"
                };

                var p1 = new Personnes()
                {
                    Nom = "Dupont",
                    Prenom = "Jean",
                    DateNaissance = new DateTime(1995, 1, 18),
                    Ville = laville
                };

                var p2 = new Personnes()
                {
                    Nom = "Martin",
                    Prenom = "Pierre",
                    DateNaissance = new DateTime(1990, 11, 19),
                    Ville = laville
                };

                db.Villes.Add(laville);
                db.Personnes.Add(p1);
                db.Personnes.Add(p2);

                db.SaveChanges();

            }
        }
    }
}
