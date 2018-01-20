using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poupee
{

    public class PoupeeParlante : Poupée
    {
        List<String> PhraseVF = new List<String>();
        List<String> PhraseVO = new List<String>();

        public PoupeeParlante(String nom, int matricule, int AnneeFabriquation, int ageEstime, bool sexe, int taille, String regionRep)
            : base(nom, matricule, AnneeFabriquation, ageEstime, sexe, taille, regionRep)
        {
        }

        public void ajouterMot(String motVO, String motVF) 
        {
            PhraseVF.Add(motVF);
            PhraseVO.Add(motVO);
        }

        public void afficher()
        {
            base.afficher();
            afficherPhrases();
        }

        public void afficherPhrases()
        {
            Console.WriteLine("\n------------ TRADUCTION(S) -------------\n");
            for(int i = 0; i<PhraseVF.Count();i++)
            {
                Console.WriteLine("- " + PhraseVF[i] + " - " + PhraseVO[i]);
            }
        }

        override public double calculPrix()
        {
            double prix;
            prix = base.calculPrix();

            return prix * 1.3;
        }
    }
}
