using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometrie;
using MesGeneriques;

namespace TestGeometrie
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(1, 1);
            var p2 = new Point(1, 2);
            var p3 = new Point(2, 2);
            var p4 = new Point(2, 1);

            var liste = new ListeGenerique<IForme>();

            liste.Ajouter(new Cercle(2, p1));
            liste.Ajouter(new Triangle(p1, p2, p3));
            liste.Ajouter(new Quadrilatere(p1, p2, p3, p4));

            foreach (var item in liste)
            {
                Console.WriteLine("p : {0}, s : {1}"
                    , item.CalculerPerimetre().ToString()
                    , item.CalculerSurface().ToString());
            }

            Console.ReadKey();

            var quadri = new Quadrilatere(p1, p2, p3, p4);

            for (int i = 0; i < quadri.Count; i++)
            {
                Console.WriteLine(quadri[i]);
            }

            foreach (var item in quadri)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();



        }
    }
}
