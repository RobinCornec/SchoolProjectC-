using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccesBases
{
    class Client
    {
        private const String nomTable = "CLIENT";
        private int num_client;
        private string nom;
        private string adresse;


        public Client(int num_client, string nom, string adresse)
        {
            this.num_client = num_client;
            this.nom = nom;
            this.adresse = adresse;
        }

        public Client(int num_client)
        {
            this.num_client = num_client;
        }

        public void creerNouveau (bdd labase)
        {
            String chaine = "INSERT INTO " + nomTable
                            + " (num_client, nom_client, adresse_client) VALUES ("
                            + num_client
                            + " , '" + nom + "'"
                            + " , '" + adresse + "'"
                            + ")";

            labase.executerCmd(chaine);




        }

        public void supprimer(bdd laBase)
        {
            String chaine = "DELETE FROM " + nomTable
                                       + " WHERE num_client = "
                                       + num_client
                                      ;

            laBase.executerCmd(chaine);


           
        }

        public static List<int> listeDesNumeros(bdd laBase)
        {
            List<int> lNumClient = new List<int>();
            int tmp;
            String chaine = "SELECT num_client FROM " + nomTable;
            System.Data.Odbc.OdbcDataReader resultats;
            laBase.ouvrir();
            resultats = laBase.executerQuery(chaine);
            while (resultats.Read())
            {
                tmp = int.Parse(resultats.GetValue(0).ToString());
                lNumClient.Add(tmp);
            }
            
            laBase.fermer();
            return lNumClient;  
        }
    }
}
