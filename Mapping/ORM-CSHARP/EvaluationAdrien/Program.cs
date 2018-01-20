using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvaluationAdrien
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindDataContext())
            {
                //select * from categories
                var r1 = db.Categories;
                var r1bis = from c in db.Categories
                            select c;

                foreach (var item in r1)
                {
                    Console.WriteLine("{0} {1} {2}"
                        , item.CategoryID, item.CategoryName
                        , item.Description);
                }
                Console.ReadKey();
                //Afficher le ProductName, le CategoryName de la catégorie à laquelle il appartient
                var r2 = db.Products.Join(db.Categories
                    , p => p.CategoryID, c => c.CategoryID
                    , (p, c) => new { p.ProductName, c.CategoryName });
                var r2bis = from p in db.Products
                            join c in db.Categories
                              on p.CategoryID equals c.CategoryID
                            select new { p.ProductName, c.CategoryName };

                foreach (var item in r2)
                {
                    Console.WriteLine("{0} {1}", item.ProductName
                        , item.CategoryName);
                }
                Console.ReadKey();
                //Afficher le ProductName, le CategoryName de la catégorie à laquelle il appartient, et le CompanyName du Supplier correspondant
                var r3 = db.Products.Join(db.Categories
                    , p => p.CategoryID, c => c.CategoryID
                    , (p, c) => new { p.ProductName, c.CategoryName, p.SupplierID })
                    .Join(db.Suppliers, p => p.SupplierID, s => s.SupplierID,
                    (p, s) => new { p.ProductName, p.CategoryName, s.CompanyName });

                var r3bis = from p in db.Products
                            join c in db.Categories
                              on p.CategoryID equals c.CategoryID
                            join s in db.Suppliers
                              on p.SupplierID equals s.SupplierID
                            select new
                            {
                                p.ProductName,
                                c.CategoryName,
                                s.CompanyName
                            };
                //Afficher les produits classé par CategoryName ascendant et Prix ascendant
                var r4 = db.Products.Join(db.Categories
                    , p => p.CategoryID, c => c.CategoryID
                    , (p, c) => new { p.ProductName, c.CategoryName, p.UnitPrice })
                    .OrderBy(p => p.CategoryName)
                    .ThenBy(p => p.UnitPrice);

                var r4bis = from p in db.Products
                            join c in db.Categories
                              on p.CategoryID equals c.CategoryID
                            orderby c.CategoryName ascending
                            orderby p.UnitPrice ascending
                            select new { p.ProductName, c.CategoryName, p.UnitPrice };

                //Afficher les produits de plus de $20 de coût unitaire vendu par un Supplier en France
                var r5 = db.Products.Join(db.Suppliers, p => p.SupplierID
                    , s => s.SupplierID, (p, s) => new
                    {
                        p.ProductName,
                        p.UnitPrice,
                        s.CompanyName,
                        s.Country
                    })
                    .Where(p => p.UnitPrice > 20 && p.Country == "France");
                var r5bis = from p in db.Products
                            join s in db.Suppliers
                            on p.SupplierID equals s.SupplierID
                            where p.UnitPrice > 20
                                && s.Country == "France"
                            select new { p.ProductName, s.CompanyName };
                //BONUS POINT : un group by
                //Afficher le prix du produit le plus cher de chaque Supplier
                var r6 = from p in db.Products
                         join s in db.Suppliers
                         on p.SupplierID equals s.SupplierID
                         group p by s into g
                         select new
                         {
                             g.Key.CompanyName,
                             PrixMax = g.Max(p => p.UnitPrice)
                         };
            }
        }
    }
}
