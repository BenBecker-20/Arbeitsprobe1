using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitarbeiterverwaltung
{
    class Chef : Mitarbeiter
    {



        public Chef(string name, string vorname, double gehalt, int ID):base(name, vorname,gehalt,ID)
        {
            
        }       

        public override void GehaltErhoehen(double gehalt)
        {
            gehalt += (gehalt + 500);
          
        }
    }
}