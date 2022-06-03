using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class Arret
    {
        private int _numarret;
        private string _nomarret;

        public Arret(int numarret, string nomarret)
        {
            _numarret = numarret;
            _nomarret = nomarret;
        }
         
        public int numArret
        {
            get { return _numarret; }   
        }

        public string nomArret
        {
            get { return _nomarret; }
        }
    }
}
