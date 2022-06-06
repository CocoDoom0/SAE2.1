using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class Delais
    {
        private string _horairedepart;
        private string _delaispassage;
        private string _dernierpassage;

        public Delais(string horairedepart, string delaispassage,string dernierpassage)
        {
            _horairedepart = horairedepart; 
            _delaispassage = delaispassage;    
            _dernierpassage = dernierpassage;
        }
        
        public string Horairedepart
        { 
            get
            { 
                return _horairedepart; 
            } 
        }
        public string Delaispassage
        {
            get 
            { 
                return _delaispassage; 
            } 
        }
        public string Dernierpassage 
        { 
            get {
                return _dernierpassage;
            }
        }
    }
}
