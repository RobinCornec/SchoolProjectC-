using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SyntaxeLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ : Language INtegrated Query
            using (var db = new NorthwindDataContext())
            {
                //select *
                var r1 = from c in db.Customers
                         select c;
                var r1bis = db.Customers.Select(c => c);
                //en vrai, il suffit de ça
                var r1ter = db.Customers;

                //select d'une colonne
                var r2 = from c in db.Customers
                         select c.CompanyName;
                var r2bis = db.Customers.Select(c => c.CompanyName);

                //select de plusieurs colonnes
                var r3 = from c in db.Customers
                         select new { c.CompanyName, c.Country };
                var r3bis = db.Customers.Select(c => new
                {
                    c.CompanyName,
                    c.Country
                });
                var r3ter = db.Customers.Select(c => new ChatonPublicitaire()
                {
                    Nom = c.CompanyName,
                    Pays = c.Country
                });

                //where
                var r4 = from c in db.Customers
                         where c.Country == "France"
                         select c;
                var r4bis = db.Customers.Where(c => c.Country == "France");

                //un where et select en meme temps :
                //Le nom des clients en France
                var r5 = from c in db.Customers
                         where c.Country == "France"
                         select c.CompanyName;
                var r5bis = db.Customers
                            .Where(c => c.Country == "France")
                            .Select(c => c.CompanyName);

                //numéro de commande et date pour le client ALFKI
                var r6 = from o in db.Orders
                         where o.CustomerID == "ALFKI"
                         select new { o.OrderID, o.OrderDate };
                var r6bis = db.Orders.Where(o => o.CustomerID == "ALFKI")
                            .Select(o => new { o.OrderID, o.OrderDate });

                //Order by
                var r7 = from c in db.Customers
                         orderby c.Country ascending
                         select c;
                var r7bis = db.Customers.OrderBy(c => c.Country);

                var r8 = from c in db.Customers
                         orderby c.Country descending
                         orderby c.City descending
                         select c;
                var r8bis = db.Customers
                            .OrderByDescending(c => c.Country)
                            .ThenByDescending(c => c.City);

                //Jointures
                var r9 = from o in db.Orders
                         join c in db.Customers
                         on o.CustomerID equals c.CustomerID
                         select new { o.OrderID, c.CompanyName };
                var r9bis = db.Orders.Join(
                    db.Customers
                    , o => o.CustomerID
                    , c => c.CustomerID
                    , (o, c) => new { o.OrderID, c.CompanyName });

                //CONNAITRE LES DEUX SYNTAXES JUSQUE LA !! (du select au join)

                //group by
                var r10 = from c in db.Customers
                          group c by c.Country into g
                          select new
                          {
                              Pays = g.Key,
                              Nombre = g.Count(),
                              Clients = g
                          };

                var r10bis = db.Customers.GroupBy(c => c.Country);

                foreach (var item in r10)
                {
                    Console.WriteLine("{0} {1} ****************************"
                        , item.Pays, item.Nombre);

                    foreach (var client in item.Clients)
                    {
                        Console.WriteLine(client.CompanyName);
                    }
                }

                foreach (var item in r10bis)
                {
                    Console.WriteLine("{0} {1} ****************************"
                        , item.Key, item.Count());

                    foreach (var client in item)
                    {
                        Console.WriteLine(client.CompanyName);
                    }
                }

                //En vrac 
                //Union : 
                var r11 = r1.Union(r1bis);
                //Except
                var r12 = r1.Except(r1bis);
                //intersect
                var r13 = r1.Intersect(r1bis);

                //On peut cumuler des requêtes
                var r14 = from c in r1
                          where c.Country == "France"
                          select c;

                Console.ReadKey();
            }

            //Essayons la syntaxe sur des choses hors SQL
            var listeDeChatons = new List<ChatonPublicitaire>()
            {
                new ChatonPublicitaire(){Nom="Toto", Pays="France"}
                , new ChatonPublicitaire(){Nom="Titi", Pays="France"}
                , new ChatonPublicitaire(){Nom="Tata", Pays="Belgique"}
            };

            var rChatons = from chaton in listeDeChatons
                           where chaton.Nom.StartsWith("T")
                           group chaton by chaton.Pays into g
                           select new { Pays = g.Key, Nombre = g.Count() };

            var s = "Toto est beau";
            var voyelles = "aeiou";

            var voyellesUtilisees = s.Intersect(voyelles);

            foreach (var item in voyellesUtilisees)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    class ChatonPublicitaire
    {
        public string Nom { get; set; }
        public string Pays { get; set; }
    }
}
