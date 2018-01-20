using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityBaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db=new Northwind_Entities())
            {
                //insert
                var categorie = new Category()
                {
                    CategoryName="test"
                    , Description="un test"
                };

                categorie.Enregistrer(db);

                categorie.CategoryName = "Dylan";
                
                //update
                var beverages = db.Categories.First(c => c.CategoryID == 1);

                beverages.Description = "ldfksjflk";


                beverages.Enregistrer(db);

            }
        }
    }
}
