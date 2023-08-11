using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitarbeiterverwaltung
{
    class Lehrling : Mitarbeiter
    {

        private bool pruefungBestanden { get; set; }

        public Lehrling(bool pruefungBestanden, string name, string vorname, double gehalt, int ID) : base(name, vorname, gehalt, ID)
        {
            this.pruefungBestanden = pruefungBestanden;
        }
        public void  PruefungAblegen(bool erfolgreich)
        {
            if (erfolgreich == true)
                pruefungBestanden = true;
        }

        public override string DatenAbfragen()
        {
            return base.DatenAbfragen() + "Prüfung wurde " + pruefungBestanden;
        }

    } 
}
