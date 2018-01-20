using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccesBases
{
    class bdd
    {
        public enum typeBdd  {MySql, SqlServer}; 

        System.Data.Odbc.OdbcConnection connexion;
        System.Data.Odbc.OdbcCommand commande;


        public bdd(typeBdd typeBase)
        {
            connexion = new System.Data.Odbc.OdbcConnection();
            commande = new System.Data.Odbc.OdbcCommand();
            

            String sConnexion;
            if (typeBase == typeBdd.MySql)
            {
                sConnexion = 
                    "Driver={MySQL ODBC 5.3 Driver};"
                   + "Server=localhost;"
                   + "Database=" + "bijouterie" + ";"
                   + " UID=root;"
                   + "PASSWORD="
                   ;
            }
            else
            {
                sConnexion = 
                    "Driver={SQL Server};"
                    + "Server=NATHALIE-PCPORT;"
                    + "Database=" + "foiesgras" + ";"
                    + "Trusted_Connection=YES;  UID=bts2;"
                    + "PWD=bts2bts2;"
                    ; 
            }
            connexion.ConnectionString = sConnexion;
            commande.Connection = connexion;
        }


        public void ouvrir ()
        {
            if ( this.connexion.State != System.Data.ConnectionState.Open)
                this.connexion.Open();
        }

        public void fermer()
        {
            if (this.connexion.State != System.Data.ConnectionState.Closed)
                this.connexion.Close();
        }

        public void executerCmd(string chaine)
        {

            ouvrir();
            commande.CommandText = chaine;
            commande.ExecuteNonQuery();
            fermer();
        }

        public System.Data.Odbc.OdbcDataReader executerQuery(string chaine)
        {
            System.Data.Odbc.OdbcDataReader resultat;

            commande.CommandText = chaine;
            resultat = commande.ExecuteReader();
            return resultat;
        }
    }
}
