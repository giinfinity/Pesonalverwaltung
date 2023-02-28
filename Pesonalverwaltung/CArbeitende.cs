using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesonalverwaltung
{
    public class CArbeitende : CMitarbeitende
    {
        private int stunden;
        private double stundenlohn; 

        public CArbeitende(string vn, string nn, int std, double stdLohn)
        {
            SetVorname(vn);
            SetNachname(nn);
            this.stunden = std;
            this.stundenlohn = stdLohn;
        }

        public CArbeitende() { }

        public bool SetStunden(int std) 
        { 
            if(std >= 0) 
            {
                std = stunden;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SetStundenlohn(double stdLohn)
        {
            if(stdLohn > 0) 
            { 
                stdLohn = stundenlohn;
                return true;
            }
            else
            { 
                return false; 
            }
        }

        public double GetBrutto()
        {
            return stundenlohn;
        }
    }
}
