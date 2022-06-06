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
            string serveur = "127.0.0.1";
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
        public static List<Table> GetLigne(int numLigne,int numTrajet)
        {
            // lecture des données de la table partie
            // retourne une liste de parties

            // instanciation d'une liste de partie
            List<Table> listeParties = new List<Table>();

            // définition de la requête d'interrogation et instanciation le la commande servant à exécuter la requête
            string sql = $"SELECT ARRET.N_Arret,NomArret,DelaisArret,OrdrePassage from LIGNE,PASSAGE,ARRET WHERE LIGNE.N_Ligne=PASSAGE.N_Ligne AND ARRET.N_Arret=PASSAGE.N_Arret AND LIGNE.N_Ligne={numLigne} AND N_Trajet={numTrajet} ORDER BY OrdrePassage;";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);
            
            try
            {
                // exécution de la requête et récupération des données dans un DataReader
                MySqlDataReader rdr = cmd.ExecuteReader();

                //Parcours du DataReader
                while (rdr.Read())
                {
                    // lecture d'un enregistrement
                    
                    int numarret = (int)rdr[0];
                    string nomarret = (string)rdr[1];
                    string horaire = Convert.ToString(rdr[2]);
                    int ordrepassage = (int)rdr[3];
                    // définition d'une partie
                    Table uneTable = new Table(numarret,nomarret,horaire,ordrepassage);
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
        public static int SuppLigne(int numLigne,int numTrajet)
        {
            int retour=-1;
            string sql = $"DELETE FROM PASSAGE WHERE N_Ligne={numLigne} AND N_Trajet={numTrajet}";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);
            try
            {
                cmd.ExecuteNonQuery();
                retour = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return retour;
        }
        public static int SuppDepart(int numLigne,int numTrajet)
        {
            int retour = -1;
            string sql = $"DELETE FROM DEPART WHERE N_Ligne={numLigne} AND N_Trajet={numTrajet}";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);
            try
            {
                cmd.ExecuteNonQuery();
                retour = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return retour;
        }
        public static List<Table> CheckPassage(int numLigne, int numTrajet)
        {
            List<Table> listeParties = new List<Table>();
            string sql = $"SELECT OrdrePassage FROM PASSAGE WHERE N_Trajet={numTrajet} AND N_Ligne={numLigne};";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    // lecture d'un enregistrement
                    int numpassage = (int)rdr[0];
                    Table uneTable = new Table(numpassage);
                    listeParties.Add(uneTable);
                }
                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return listeParties;
        }
        public static List<Arret> GetArret()
        {
            List<Arret> arretList = new List<Arret>();
            string sql = "SELECT * FROM ARRET ORDER BY NomArret";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    // lecture d'un enregistrement
                    int numArret = (int)rdr[0];
                    string nomArret = (string)rdr[1];
                    Arret uneTable = new Arret(numArret,nomArret);
                    arretList.Add(uneTable);
                }
                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return arretList;
        }
        public static int AddPassage(int nLigne,int nTrajet,int nArret,string delai,int numPassage)
        {
            int retour = -1;
            string sql = $"INSERT INTO PASSAGE (N_Ligne,N_Trajet,N_Arret,DelaisArret,OrdrePassage) VALUES ({nLigne},{nTrajet},{nArret},'{delai}',{numPassage});";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);
            try
            {
                cmd.ExecuteNonQuery();
                retour = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return retour;
        }
        public static int AddLigne(int nLigne,string nomLigne)
        {
            int retour = -1;
            string sql = $"INSERT INTO LIGNE (N_Ligne,NomLigne) VALUES ({nLigne},'{nomLigne}');";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);
            try
            {
                cmd.ExecuteNonQuery();
                retour = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return retour;
        }
        public static int AddDepart(int nLigne,int nTrajet,string HeureDepart,string Delais,string DerniereHeure)
        {
            int retour = -1;
            string sql = $"INSERT INTO DEPART (N_Ligne,N_Trajet,HeureDepart,DelaiNvDepart,DernierDepart) VALUES ({nLigne},{nTrajet},'{HeureDepart}','{Delais}','{DerniereHeure}');";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);
            try
            {
                cmd.ExecuteNonQuery();
                retour = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return retour;
        }
        public static List<Delais> GetDelais(int numLigne, int numTrajet)
        {
            // lecture des données de la table partie
            // retourne une liste de parties

            // instanciation d'une liste de partie
            List<Delais> listeDelais = new List<Delais>();

            // définition de la requête d'interrogation et instanciation le la commande servant à exécuter la requête
            string sql = $"SELECT HeureDepart,DelaiNvDepart,DernierDepart FROM DEPART WHERE N_Ligne = {numLigne} AND N_Trajet = {numTrajet};";
            MySqlCommand cmd = new MySqlCommand(sql, maCnx);

            try
            {
                // exécution de la requête et récupération des données dans un DataReader
                MySqlDataReader rdr = cmd.ExecuteReader();

                //Parcours du DataReader
                while (rdr.Read())
                {
                    // lecture d'un enregistrement

                    string horairedepart = (string)rdr[0];
                    string delaispassage = (string)rdr[1];
                    string dernierpassage = (string)rdr[2];
                    // définition d'une partie
                    Delais uneTable = new Delais(horairedepart, delaispassage, dernierpassage);
                    // ajout de la partie définie à la liste des parties
                    listeDelais.Add(uneTable);
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
            return listeDelais;
        }
    }
}
