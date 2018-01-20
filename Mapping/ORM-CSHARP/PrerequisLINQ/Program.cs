using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrerequisLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ce sont tous les ajouts au language C# nécessaires à la syntaxe de requete
            //LINQ

            //inférence de type : type implicite
            //le type est déduit automatiquement par la partie droite du =
            var i = 9;

            //initialisateur d'objet
            var mimi = new Chaton() { Age = 4, Nom = "Plume" };
            var minou = new Chaton() { Age = 9 };

            //initialisateur de tableaux et listes
            var liste = new List<int>() { 8, 0, 3, -5, 7, -9 };
            var tab = new int[] { 8, 0, 3, -5, 7, -9 };

            //type anonyme
            var voiture = new { immatriculation = "kdsjfl 77", marque = "renault" };

            //méthodes d'extension
            var s = "J'aime les chatons";
            Console.WriteLine(s.MettreEnMajusculeUneLettreSurDeux());
            Console.ReadKey();

            //expression lambda : simplification des méthodes anonymes
            //pour aller chercher les nombres négatifs de la liste
            var listeNeg = new List<int>();
            foreach (var item in liste)
            {
                if (item < 0)
                {
                    listeNeg.Add(item);
                }
            }

            //méthode anonyme
            var listeNeg2 = liste.FindAll(delegate(int a) { return a < 0; });
            //expression lambda dans une méthode existante
            var listeNeg3 = liste.FindAll(a => a < 0);

            //expression lambda dans une méthode d'extension LINQ : on y est !
            var tabNeg = tab.Where(a => a < 0);
        }
    }

    class Chaton
    {
        public int Age { get; set; }
        public String Nom { get; set; }
    }

    static class Outils
    {
        public static string MettreEnMajusculeUneLettreSurDeux(this string s)
        {
            var sb = new StringBuilder();
            var majuscule = true;
            foreach (var item in s)
            {
                if (majuscule)
                    sb.Append(item.ToString().ToUpper());
                else
                    sb.Append(item.ToString().ToLower());

                majuscule = !majuscule;
            }

            return sb.ToString();
        }
    }
}
