using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace LesExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string pswd;
                pswd = SaisirPassword("Saisissez votre mot de passe.");
                Console.WriteLine("Mot de passe correct");
            }
            catch (PasswordException excep)
            {
                Console.WriteLine(excep.Message + " : " + excep.infoComplementaire);
                excep.Data;
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

                catch (PasswordException excep)
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
                    throw new PasswordException("Mauvais charactère");
                saisie += touche.KeyChar;
                touche = Console.ReadKey(true);
                
                Console.Write(masque);
            }


            Console.WriteLine();       

            return saisie;


        }

        private static void verifLongueur(int longMini, int longMax, string saisie)
        {
            if (saisie.Length < longMini)
                throw new PasswordException("Mot de passe trop petit", saisie.Length);
            if (saisie.Length > longMax)
                throw new PasswordException("Mot de passe trop long", saisie.Length);
        }

        private static void verifCaractere(int lettreMax, int chiffreMax, string saisie)
        {

            int nbLettre = 0;
            int nbChiffre = 0;

            for (int i = 0; i < saisie.Length; i++)
            {

                if (Char.IsNumber(saisie, i))
                    nbChiffre++;
                
                if (Char.IsLetter(saisie, i))
                    nbLettre++;

            }

            if (nbChiffre < chiffreMax)
            {
                throw new PasswordException("Il n'y a pas assez de chiffre dans votre mot de passe", nbChiffre);
            }

            if (nbLettre < lettreMax)
            {
                throw new PasswordException("Il n'y a pas assez de lettre dans votre mot de passe", nbLettre);
            }
      
        }

        

    }

    public class PasswordException : Exception
    {
        public int infoComplementaire;

        public PasswordException(String message, int info) : base(message) 
        {

        }
        public PasswordException() : base("Problème avec le mot de passe") { }
        public PasswordException(String message) : base(message) { }
    }
}
