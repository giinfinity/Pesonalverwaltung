using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesonalverwaltung
{
    public class CAngestellte : CMitarbeitende
    {
        private double bruttogehalt;

        public CAngestellte(string vn, string nn, double brutto) : base(vn,nn)
        {
            //SetNachname(vn);
            //etNachname(nn);
            this.bruttogehalt = brutto;
            
        }
        //public CAngestellte() {}

        public bool SetBrutto(double brutto) 
        {
            if(brutto > 0)
            {
                bruttogehalt = brutto;
                return true;
            }
            else 
            {
                return false;
            }
        }

        public double GetBrutto() 
        {
            return bruttogehalt;
        }
    }
}
