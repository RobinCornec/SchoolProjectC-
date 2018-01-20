using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poupee
{
    public class BoiteAMusique
    {
        public int matricule;
        int taille;
        public String paysOrigine;
        int anneeFabriquation;
        String style;
        int nbAirs;
        double prix;
        

        public BoiteAMusique(int matricule, int taille, String paysOrigine, int anneeFabriquation, String style, int nbAirs, double prix)
        {
            this.matricule = matricule;
            this.taille = taille;
            this.paysOrigine = paysOrigine;
            this.anneeFabriquation = anneeFabriquation;
            this.style = style;
            this.nbAirs = nbAirs;
            this.prix = prix;
            this.verifPrix();
        }

        public void verifPrix()
        {
            if (prix < taille * (DateTime.Now.Year - anneeFabriquation) / 10 * nbAirs)
            {
                throw new ProblemBoite("Les prix de la boîte à musique sont trop bas");
            }
            
        }

        public void ajouterBoite(BoiteAMusique LaBoite, List<BoiteAMusique>ListeBoite)
        {
            ListeBoite.Add(LaBoite);
        }


        public void afficher()
        {
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("------------ BOITE A MUSIQUE -----------");
            Console.WriteLine("----------------------------------------\n");
            Console.WriteLine("Boite à musique " + matricule + " : \nTaille = " + taille + "cm \nPays d'origine = " + 
                paysOrigine + " \nFabriquée en = " + anneeFabriquation + "\nStyle = " + 
                style + " \nNombre d'airs quelle sait joués = " + nbAirs + " air(s)\nprix = " + prix + " euros");
        }

        public void verifMatricule(List<BoiteAMusique> ListeBoite)
        {
            foreach (BoiteAMusique b in ListeBoite)
            {
                if (b.matricule == matricule)
                {
                    throw new ErreurMatricule("Le matricule " + b.matricule + " existe déjà");
                }
            }
        }

    }
}
