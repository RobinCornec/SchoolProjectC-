using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChienMaitre;

namespace TUMaitresChiens
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConstructeurChienOk()
        {
            Chien leChien;
            try
            {
                leChien = new Chien("Zita", true, null);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
        
        [TestMethod]
        public void TestConstructeurChienMaitreNullOk()
        {
            Chien leChien;          
            leChien = new Chien("Zita", true, null);
            Assert.IsNull(leChien.getMaitre());
        }

        [TestMethod]
        public void TestConstructeurChienMaitreNotNullOk()
        {
            Chien leChien;
            Maitre m = new Maitre("Lulu");
            leChien = new Chien("Zita", true, m);
            Assert.IsNotNull(leChien.getMaitre());
        }

        [TestMethod]
        public void TestConstructeurMaitreOk()
        {
            Maitre m = new Maitre("Lulu");
            StringAssert.Equals("Lulu", m.nom);
        }

        [TestMethod]
        public void TestMethodeAjouterChien()
        {
            Maitre m = new Maitre("Lulu");
            Maitre m2 = new Maitre("Toto");
            Chien c = new Chien("Zita", true, m);
            try
            {
                m2.ajouterChien(c);
                Assert.Fail();
            }
            catch (MaitreDifferentException)
            {
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMethodeAjouterChienOk()
        {
            Maitre m = new Maitre("Lulu");
            Chien c = new Chien("Zita", true, m);
            try
            {
                m.ajouterChien(c);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestConstructeurMaitreMalvoyantOk()
        {
            MaitreMalvoyant m = new MaitreMalvoyant("Lulu", 56);
            StringAssert.Equals("Lulu", m.nom);
            Assert.AreEqual(56, m.niveauInfirmite);
        }

        [TestMethod]
        public void TestConstructeurChienDAveugleSansException()
        {
            ChienDAveugle leChien;

            try
            {
                leChien = new ChienDAveugle("Zita", true, null, new DateTime(2010, 12, 3), "Les aides");
            }
            catch (Exception)
            {
                Assert.Fail();
            }

        }

        [TestMethod]
        public void TestConstructeurChienDAveugleAvecException()
        {
            ChienDAveugle leChien;
            MaitreMalvoyant m1 = new MaitreMalvoyant("Lulu", 56);
            try
            {
                leChien = new ChienDAveugle("Zita", true, m1, new DateTime(2012, 12, 3), "Les aides");
                Assert.Fail();
            }
            catch (AgeInadapteException)
            {
                
            }
            catch (Exception)
            {
                Assert.Fail();
            }

        }

        [TestMethod]
        public void TestMethodeEstProtegeFalseMaitre()
        {
            Maitre m1 = new Maitre("Bill");
            Assert.IsFalse(m1.estProtege());
            
        }

        [TestMethod]
        public void TestMethodeEstProtegeTrueMaitreMalvoyant()
        {
            MaitreMalvoyant m1 = new MaitreMalvoyant("Bill", 45);
            Assert.IsFalse(m1.estProtege());
            ChienDAveugle c1 = new ChienDAveugle("Zita", true, m1, new DateTime(2010, 12, 3), "Les aides");
            m1.ajouterChien(c1);
            Assert.IsTrue(m1.estProtege());

        }

        [TestMethod]
        public void TestMethodeEstProtegeFalseMaitreMalvoyant()
        {
            MaitreMalvoyant m1 = new MaitreMalvoyant("Bill", 45);
            Assert.IsFalse(m1.estProtege());
            Chien c1 = new Chien("medor", false, m1);
            m1.ajouterChien(c1);
            Assert.IsFalse(m1.estProtege());

        }

        [TestMethod]
        public void TestPossedeChienFalse()
        {
            Maitre m1 = new MaitreMalvoyant("Bill", 45);
            Assert.IsFalse(m1.PossedeChien("Bill"));
            ChienDAveugle c1 = new ChienDAveugle("Zita", true, m1, new DateTime(2010, 12, 3), "Les aides");
            m1.ajouterChien(c1);
            Assert.IsTrue(m1.PossedeChien("Billy"));

        }


    }
}
