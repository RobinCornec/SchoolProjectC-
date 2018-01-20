using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poupee
{
    public class Vetement
    {
        public String nom { get; set; }
        public String couleur { get; set; } 

        public Vetement(String nom, String couleur)
        {
            this.nom = nom;
            this.couleur = couleur;
        }

        public void afficher()
        {
            Console.WriteLine(nom + " " + couleur);
        }
        
    }
}


