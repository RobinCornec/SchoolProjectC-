using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poupee;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUBoiteAMusique
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreationBoiteOK()
        {
            BoiteAMusique B1;
            try
            {
                B1 = new BoiteAMusique(1, 20, "France", 1995, "Rock", 3, 1000);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestVerifPrixKO()
        {

            try
            {
                BoiteAMusique Boite1 = new BoiteAMusique(1, 20, "France", 1995, "Rock", 3, 1);
              
                Assert.Fail();
            }
            catch (ProblemBoite)
            {
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestAjoutBoite()
        {
            BoiteAMusique Boite1 = new BoiteAMusique(1, 20, "France", 1995, "Rock", 3, 1000);
            List<BoiteAMusique> ListeBoite = new List<BoiteAMusique>();

            try
            {
                Boite1.ajouterBoite(Boite1, ListeBoite);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestVerifMatriculeOK()
        {
            BoiteAMusique Boite1 = new BoiteAMusique(1, 20, "France", 1995, "Rock", 3, 1000);
            BoiteAMusique Boite2 = new BoiteAMusique(2, 20, "France", 1995, "Rock", 3, 1000);
            List<BoiteAMusique> ListeBoite = new List<BoiteAMusique>();
            try
            {
                Boite1.verifMatricule(ListeBoite);
                Boite1.ajouterBoite(Boite1, ListeBoite);
                Boite2.verifMatricule(ListeBoite);
                Boite2.ajouterBoite(Boite2, ListeBoite);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestVerifMatriculeKO()
        {
            BoiteAMusique Boite1 = new BoiteAMusique(2, 20, "France", 1995, "Rock", 3, 1000);
            BoiteAMusique Boite2 = new BoiteAMusique(2, 20, "France", 1995, "Rock", 3, 1000);
            List<BoiteAMusique> ListeBoite = new List<BoiteAMusique>();
            try
            {
                Boite1.verifMatricule(ListeBoite);
                Boite1.ajouterBoite(Boite1, ListeBoite);
                Boite2.verifMatricule(ListeBoite);
                Boite2.ajouterBoite(Boite2, ListeBoite);
                Assert.Fail();
            }
            catch (ErreurMatricule e)
            {

            }
            catch (ProblemBoite e)
            {
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestVerifPrixOK()
        {
            BoiteAMusique Boite1 = new BoiteAMusique(1, 20, "France", 1995, "Rock", 3, 10000);

            try
            {
                Boite1.verifPrix();
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}