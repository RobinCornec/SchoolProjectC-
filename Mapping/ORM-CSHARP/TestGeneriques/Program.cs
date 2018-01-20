using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MesGeneriques;


namespace TestGeneriques
{
    class Program
    {
        static void Main(string[] args)
        {
            var liste = new ListeGenerique<int>();

            var liste2 = new List<int>();
            liste2.Add(5);

            liste.Ajouter(3);
            liste.Ajouter(-3);
            liste.Ajouter(6);
            liste.Ajouter(2);

            //délégation à une instance
            //var mimi = new Chaton();
            //liste.Trier(mimi.MinouMinou);

            //avec une méthode anonyme
            liste.Trier(delegate(int a, int b) { return a < b; });

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }

    class Chaton
    {
        //logique du chaton...
        //...

        public bool MinouMinou(int a, int b)
        {
            return a > b;
        }
    }

}
