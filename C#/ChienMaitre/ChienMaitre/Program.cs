using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChienMaitre
{
    public class Program
    {      
            static void Main(string[] args){
                try
                {
                    List<Maitre> lesMaitres = new List<Maitre>();

                   
                    Maitre m1 = new Maitre("Bill");
                    Maitre m2 = new Maitre("Zaar");
                    MaitreMalvoyant m3 = new MaitreMalvoyant("Loum", 56);

                    Chien c1 = new Chien("medor", false, m1);
                    Chien c2 = new Chien("rita", true, m2);
                    Chien c4 = new Chien("rita4", true, m3);              
                    ChienDAveugle c3  = new ChienDAveugle ("dina", true, m3, new DateTime(2010,12,3), "Les aides");

                
                    m1.ajouterChien(c1);
                    m2.ajouterChien(c2);
                    m3.ajouterChien(c3);

                    lesMaitres.Add(m1);
                    lesMaitres.Add(m2);
                    lesMaitres.Add(m3);

                    foreach (Maitre m in lesMaitres)
                    {
                        Console.WriteLine(" " + m.nom + " est-il protégé ? " + m.estProtege());
                    }


                }
                catch (Exception excep)
                {
                    Console.WriteLine("Erreur de maître : " + excep.Message);
                }

                Console.ReadLine();

            }      
    }
}
