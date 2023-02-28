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

        public string GetNachname()
        {
            return nachname;
        }

        public string GetVorname()
        {
            return vorname;
        }

        public void SetNachname(string nN)
        {
            this.nachname = nN;
        }

        public void SetVorname(string vN)
        {
            this.vorname= vN;
        }
    }
}
