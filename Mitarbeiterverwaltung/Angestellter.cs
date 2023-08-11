using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitarbeiterverwaltung
{
    class Angestellter : Mitarbeiter
    {




        public Angestellter(string Position, string name, string vorname, double gehalt, int ID) : base(name, vorname, gehalt,ID)
        {
            
        }

    }
}
