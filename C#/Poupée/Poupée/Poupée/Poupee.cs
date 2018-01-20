using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poupee
{
    public class Poupée
    {
        public String nom;
        public int matricule;
        public int AnneeFabriquation { get; set; }
        public int ageEstime;
        public bool sexe; // true = garçon ; false = fille
        public int taille { get; set; }
        public String regionRep;
        List<Vetement> vetements = new List<Vetement>();

        public Poupée(String nom, int matricule, int AnneeFabriquation, int ageEstime, bool sexe, int taille, String regionRep) 
        {
            this.nom = nom;
            this.matricule = matricule;
            this.AnneeFabriquation = AnneeFabriquation;
            this.ageEstime = ageEstime;
            this.sexe = sexe;
            this.taille = taille;
            this.regionRep = regionRep;           
            
        }

        public void afficher() 
        {
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("---------------- POUPEE ----------------");
            Console.WriteLine("----------------------------------------\n");
            Console.WriteLine("Poupee " + matricule + " : \nNom = " + nom + " \nFabriquée en " + AnneeFabriquation + " \nAge = " + ageEstime + " ans \nTaille = " + taille + 
                "cm \nRegion = " + regionRep + " \nPrix = " + calculPrix() + " euros");
            afficherVetements();
        }

        public void afficherVetements()
        {
            if (vetements.Count() != 0)
            {
                Console.WriteLine("\n------------- VETEMENT(S) --------------\n");
                foreach (Vetement v in vetements)
                {
                    Console.Write("- ");
                    v.afficher();
                }
            }
                    
        }



        virtual public double calculPrix()
        {
            double prix;
            double AgeEnAnnee = DateTime.Now.Year - AnneeFabriquation;

            if (AgeEnAnnee > 30)
            {
                prix = taille * (AgeEnAnnee - 20) / 10;
            }
            else
            {
                prix = taille;
            }

            return prix;
        }

        public void ajouterVetement (Vetement leVetement)
        {
            vetements.Add(leVetement);
        }

        public bool VerifVetement(String VetementSaisie)
        {
            foreach (Vetement v in vetements)
            {
                if (v.nom == VetementSaisie)
                {
                    Console.WriteLine("\n => La poupée possède bien le vêtement : " + VetementSaisie);
                    return true;
                }
                
            }

            Console.WriteLine("\n => La poupée ne possède pas le vêtement : " + VetementSaisie);
            return false;
        }




        public bool VerifVetement(String VetementSaisie, String CouleurSaisie)
        {
            foreach (Vetement v in vetements)
            {
                if (v.nom == VetementSaisie && v.couleur == CouleurSaisie)
                {
                    Console.WriteLine("\n => La poupée possède bien le vêtement : " + VetementSaisie + " " + CouleurSaisie);
                    return true;
                }

            }
            Console.WriteLine("\n - La poupée ne possède pas le vêtement : " + VetementSaisie + " " + CouleurSaisie);
            return false;
        }

    }
}
