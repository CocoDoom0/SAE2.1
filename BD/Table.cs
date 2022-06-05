using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BD
{
    public class Table
    {
        private int _idligne;
        private string _nomligne;
        private int _numarret;
        private string _nomarret;
        private string _horaire;
        private int _ordrepassage;
        private int _numpassage;
        public Table(int numpassage)
        {
            //création de la table pour les num de passage
            _numpassage = numpassage;
        }
        public Table(int idligne, string nomligne)
        {
            //création de la table pour les id et nom de ligne
            _idligne = idligne;
            _nomligne = nomligne;
            
        }
        public Table(int numarret, string nomarret, string horaire, int ordrepassage)
        {
            //création de la table pour les num arret, nom arret, horaire, ordre de passage
            _numarret = numarret;
            _nomarret = nomarret;
            _horaire = horaire;
            _ordrepassage = ordrepassage;
        }

        public int numPassage
        {
            //Getters num passage
            get
            {
                return _numpassage;
            }
        }
        public string nomLigne
        {
            //Getters nom ligne
            get
            {
                return _nomligne;
            }
        }

        public int numArret
        {
            //Getters num arret
            get
            {
                return _numarret;
            }
        }

        public string nomArret
        {
            //Getters nom arret
            get
            {
                return _nomarret;
            }
        }

        public string Horaire
        {
            //Getters horaire
            get
            {
                return _horaire;
            }
        }

        public int ordrePassage
        {
            //Getters ordre de passage
            get
            {
                return _ordrepassage;
            }
        }
    }


}
