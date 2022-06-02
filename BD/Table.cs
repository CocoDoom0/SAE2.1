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
            _numpassage = numpassage;
        }
        public Table(int idligne, string nomligne)
        {
            //création de la partie au début du jeu
            _idligne = idligne;
            _nomligne = nomligne;
            
        }
        public Table(int numarret, string nomarret, string horaire, int ordrepassage)
        {
            _numarret = numarret;
            _nomarret = nomarret;
            _horaire = horaire;
            _ordrepassage = ordrepassage;
        }

        public int numPassage
        {
            get
            {
                return _numpassage;
            }
        }
        public string nomLigne
        {
            get
            {
                return _nomligne;
            }
        }

        public int numArret
        {
            get
            {
                return _numarret;
            }
        }

        public string nomArret
        {
            get
            {
                return _nomarret;
            }
        }

        public string Horaire
        {
            get
            {
                return _horaire;
            }
        }

        public int ordrePassage
        {
            get
            {
                return _ordrepassage;
            }
        }
    }


}
