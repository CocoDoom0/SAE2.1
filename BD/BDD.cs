using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BD
{
    public static class BDD
    {
        private static MySqlConnection maCnx;

        public static bool InitConnexion()
        {
            //ouverture de la connexion à la BD
            //retourne true si connexion ouverte
            //retourne false si echec de connexion

            // définition chaine de connexion
            string serveur = "10.1.139.236";
            string login = "f3";
            string passwd = "mdp";
            string BD = "basef3";
            string chaineDeConnexion = $"server={serveur};uid={login};pwd={passwd};database={BD}";

            bool retour = true;

            // instanciation et ouverture de la connexion à la BD
            maCnx = new MySqlConnection(chaineDeConnexion);

            try
            {
                maCnx.Open();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                retour = false;

            }
            return retour;
        }

        public static bool FermerConnexion()
        {
            // fermeture de la connexion 
            //retourne true si connexion fermée
            //retourne false si echec de fermeture

            bool retour = true;

            try
            {
                if (maCnx.State == System.Data.ConnectionState.Open)
                    maCnx.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                retour = false;

            }
            return retour;
        }
        public static List<Table> GetNomLigne()
        {
            // lecture des données de la table partie
            // retourne une liste de parties

            // instanciation d'une liste de partie
            List<Table> listeParties = new List<Table>();

            // définition de la requête d'interrogation et instanciation le la commande servant à exécuter la requête
            string sql = "select * from LIGNE;";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);

            try
            {
                // exécution de la requête et récupération des données dans un DataReader
                MySqlDataReader rdr = cmd.ExecuteReader();

                //Parcours du DataReader
                while (rdr.Read())
                {
                    // lecture d'un enregistrement

                    int idligne = (int)rdr[0];
                    string nomligne = (string)rdr[1];

                    // définition d'une partie
                    Table uneTable = new Table(idligne, nomligne);

                    // ajout de la partie définie à la liste des parties
                    listeParties.Add(uneTable);
                }

                // fermeture du reader et libération de la mémoire
                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }

            // retour de la liste des parties
            return listeParties;
        }

    }
}
