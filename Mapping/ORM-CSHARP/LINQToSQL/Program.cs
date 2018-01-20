using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQToSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contexte de données : fait la connexion à la base
            using (var db = new NorthwindDataContext())
            {
                //les propriétés de navigation évitent 
                //d'avoir à écrire des join
                var r2 = from p in db.Product
                         select new
                         {
                             p.ProductName
                             ,
                             p.Category.CategoryName
                             ,
                             p.Supplier.CompanyName
                         };

                foreach (var item in r2)
                {
                    Console.WriteLine("{0} {1}", item.ProductName
                        , item.CategoryName);
                }

                Console.ReadKey();

                //Ce qu'il ne faut pas faire avec les propriétés
                //de navigation
                var r3 = db.Product;

                foreach (var item in r3)
                {
                    //Console.WriteLine("{0} {1}", item.ProductName
                    //    , item.Category.CategoryName);
                }

                Console.ReadKey();

                //Insert
                var nouvelleCategorie =
                    new Category()
                    {
                        CategoryName = "Alan"
                       ,
                        Description = "la catégorie du prof"
                    };

                //j'attache l'objet au contexte
                db.Category.InsertOnSubmit(nouvelleCategorie);
                //je génère et envoie l'insert
                db.SubmitChanges();

                //après l'insertion, l'objet est mis à 
                //jour avec les colonnes autogénérées
                Console.WriteLine(nouvelleCategorie.CategoryID);

                //Delete
                var CategoriesDylan = db.Category
                    .Where(c => c.CategoryID > 10);

                db.Category.DeleteAllOnSubmit(CategoriesDylan);

                db.SubmitChanges();

                //Update
                //var robin = db.Category.First(c => c.CategoryID == 18);
                //robin.Description = "Il est drôle et il est breton";

                //db.SubmitChanges();

                //Tester si ça existe
                if (!db.Category.Any(c => c.CategoryName == "Alan"))
                {
                    //insert
                }
                else
                {
                    //update
                }

            }
        }
    }
}
