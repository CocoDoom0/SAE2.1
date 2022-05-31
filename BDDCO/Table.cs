using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BDDCO
{
    public class Table
    {
        private int _idligne;
        private string[] _nomligne;

        public Table(int idligne, string nomligne)
        {
            //création de la partie au début du jeu
            _idligne = idligne;
            _nomligne = new string[] {nomligne};
        }
    }

    
}
