using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesonalverwaltung
{
    public class CMitarbeitende
    {
        private string nachname; 
        private string vorname;

        public CMitarbeitende(string vn, string nn) 
        {
            SetVorname(vn);
            SetNachname(nn);
        }
        private string GetNachname()
        {
            return nachname;
        }

        private string GetVorname()
        {
            return vorname;
        }

        private void SetNachname(string nN)
        {
            this.nachname = nN;
        }

        private void SetVorname(string vN)
        {
            this.vorname= vN;
        }
    }
}
