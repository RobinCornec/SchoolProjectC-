using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace RappelADO
{
    class Program
    {
        static void Main(string[] args)
        {
            var monDataSet = new DataSet();

            //mode connecté
            using (var connexion=new SqlConnection(
                ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString))
            {
                connexion.Open();

                using (var commande=new SqlCommand("select * from customers", connexion))
                {
                    //lecture mode connecté : le SqlDataReader
                    var reader = commande.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine(reader["CompanyName"]);
                    }

                    Console.ReadKey();


                    reader.Close();

                    //mode déconnecté : on met les lignes dans un objet .NET pur
                    
                    var adapteur = new SqlDataAdapter(commande);

                    adapteur.Fill(monDataSet, "Clients");
                }

                connexion.Close();
            }

            //la connexion est fermée

            foreach (var item in monDataSet.Tables["Clients"].Rows.OfType<DataRow>())
            {
                Console.WriteLine(item["CompanyName"]);        
            }

            Console.ReadKey();


        }
    }
}
