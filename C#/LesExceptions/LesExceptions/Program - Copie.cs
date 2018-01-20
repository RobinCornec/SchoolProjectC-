using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            //try
            //{
            //    int x;
            //    x = SaisirEntier("Saisissez un entier;");
            //    Console.WriteLine("Votre entier est : " + x);
            //}
            //catch (System.Exception excep)
            //{
            //    Console.WriteLine("Un problème majeur est survenu. Prévenez votre dépanneur avec le message suivant :");
            //    Console.WriteLine(excep.Message);

            //}
            try
            {
                string pswd;
                pswd = SaisirPassword("Saisissez votre mot de passe.");
                Console.WriteLine("Mot de passe correct");
            }
            catch (System.Exception excep)
            {
                Console.WriteLine("Un problème majeur est survenu. Prévenez votre dépanneur avec le message suivant :");
                Console.WriteLine(excep.Message);

            }


            Console.ReadLine();


        }



        static int SaisirEntier(string messageInvite)
        {
            int x = 0;
            bool saisieOK = false;

            Console.WriteLine(messageInvite);

            do

                try
                {
                    x = int.Parse(Console.ReadLine());
                    saisieOK = true;
                }

                catch (FormatException excep)
                {
                    Console.WriteLine("votre saisie ne correspond pas à un entier, recommencez.");

                }

                catch (System.OverflowException excep)
                {
                    Console.WriteLine("votre entier est hors limite, recommencez.");

                }

            while (!saisieOK);

            return x;
        }

        //------------------------------------------

        static string SaisirPassword(string messageInvite)
        {
            string pswd;

            Console.WriteLine(messageInvite);

            pswd = saisieMasquee('*');
 
            verifLongueur(4, 100, pswd);
            verifCaractere(3, 2, pswd);

            return pswd;
        }

        private static string saisieMasquee(char masque)
        {

            string saisie="";
            ConsoleKeyInfo touche;
            touche = Console.ReadKey(true);
            Console.Write(masque);

            while (touche.Key != ConsoleKey.Enter)
            {
                if (touche.KeyChar < 32 || touche.KeyChar > 125)
                    throw new FormatException("Mauvais charactère");
                saisie += touche.Key;
                touche = Console.ReadKey(true);
                
                Console.Write(masque);
            }
            Console.WriteLine();       

            return saisie;


        }

        private static void verifLongueur(int longMini, int longMax, string saisie)
        {
            if (saisie.Length < longMini)
                throw new FormatException("Mot de passe trop petit");
            if (saisie.Length > longMax)
                throw new FormatException("Mot de passe trop long");
        }

        private static void verifCaractere(int lettreMax, int chiffreMax, string saisie)
        {

            int nbLettre = 0;
            int nbChiffre = 0;

            for (int i = 0; i < saisie.Length; i++)
            {

                if (Char.IsNumber(saisie, i))
                {
                    nbChiffre = nbChiffre + 1;
                }
                if (Char.IsLetter(saisie, i))
                {
                    nbLettre = nbLettre + 1;
                }

            }

            if (nbChiffre < chiffreMax)
            {
                throw new FormatException("Il n'y a pas assez de chiffre dans votre mot de passe");
            }

            if (nbLettre < lettreMax)
            {
                throw new FormatException("Il n'y a pas assez de lettre dans votre mot de passe");
            }

         
        }
    }
}
