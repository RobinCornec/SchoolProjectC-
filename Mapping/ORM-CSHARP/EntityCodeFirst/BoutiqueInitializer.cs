using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityCodeFirst
{
    class BoutiqueInitializer :
        System.Data.Entity.DropCreateDatabaseIfModelChanges<BoutiqueContext>
    {
        protected override void Seed(BoutiqueContext context)
        {
            base.Seed(context);

            var cat = new Category()
            {
                Nom = "Test"
                    ,
                Description = "Une catégorie de test"
            };

            var p1 = new Product()
            {
                Nom = "P1",
                Descritption = "Produit 1",
                PrixUnitaire = 12.55,
                Categorie = cat
            };

            var p2 = new Product()
            {
                Nom = "P2",
                Descritption = "Produit 2",
                PrixUnitaire = 44.76,
                Categorie = cat
            };

            context.Categories.Add(cat);

            context.SaveChanges();

        }
    }
}
