using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poupee
{
    public class ProblemBoite : Exception {
        public ProblemBoite (String mess) : base (mess) { }
        public ProblemBoite() { }
    }

    public class ErreurMatricule : Exception
    {
        public ErreurMatricule(String mess) : base(mess) { }
        public ErreurMatricule() { }
    }

    class Program
    {

        static void Main(string[] args)
        {

            try
            {

            List<BoiteAMusique> ListeBoite = new List<BoiteAMusique>();

            Vetement fichuNoir, robeGrise, pantalonRouge, chemiseJaune, giletBleuFonce;

            fichuNoir = new Vetement("Fichu", "Noir");
            robeGrise = new Vetement("Robe", "Gris");
            pantalonRouge = new Vetement("Pantalon", "Rouge");
            chemiseJaune = new Vetement("Chemise", "Jaune");
            giletBleuFonce = new Vetement("Gilet", "Bleu Foncé");

            Poupée p1 = new Poupée("Mary", 43, 1853, 70, false, 15, "Ecosse");
            Poupée p2 = new Poupée("Michka", 76, 1920, 10, true, 20, "Russie");

            PoupeeParlante p3 = new PoupeeParlante("Léon", 121, 1917, 80, true, 40, "Russie");
            Poupée p4 = new PoupeeParlante("Adolf", 122, 1937, 30, true, 60, "Allemand");

            p1.ajouterVetement(fichuNoir);
            p1.ajouterVetement(robeGrise);

            p2.ajouterVetement(pantalonRouge);
            p2.ajouterVetement(chemiseJaune);
            p2.ajouterVetement(giletBleuFonce);

            p3.ajouterMot("da", "oui");
            p3.ajouterMot("vodka", "pastis");

            //p4.ajouterMot("Heil", "Salut");
            //p4.ajouterMot("gut", "Bien");

            p1.afficher();
            p2.afficher();
            p3.afficher();
            p4.afficher();

            Console.WriteLine("Adolf :" + p4.calculPrix());

            p1.VerifVetement("Fichu", "Noir");
            p1.VerifVetement("Robe");
            p1.VerifVetement("blabla");

            BoiteAMusique b1 = new BoiteAMusique(1, 20, "France", 1995, "Rock", 3, 1000);
            b1.verifMatricule(ListeBoite);
            b1.ajouterBoite(b1, ListeBoite);
            b1.afficher();

            BoiteAMusique b2 = new BoiteAMusique(2, 20, "France", 1995, "Rock", 3, 10000);
            b2.verifMatricule(ListeBoite);
            b2.ajouterBoite(b2, ListeBoite);
            b2.verifPrix();
            b2.afficher();


            }
            catch (ProblemBoite e)
            {
                Console.WriteLine("\n\nERROR : " + e.Message);
            }
            catch (ErreurMatricule e)
            {
                Console.WriteLine("\n\nERROR : " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\nERROR : " + e.Message);
            }
            Console.ReadLine();
            
        }
    }
}
