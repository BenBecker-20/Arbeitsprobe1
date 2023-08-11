using System;
using System.Collections.Generic;
using System.Text;

namespace Mitarbeiterverwaltung //verbessert
{
   class Mitarbeiter
   {
      private string name;
      private string vorname;
      protected double gehalt;       // Monatsgehalt
      private int ID { get; set; }

      public Mitarbeiter(string name, string vorname, double gehalt, int ID)
      {
         this.name = name;
         this.vorname = vorname;
         this.gehalt = gehalt;
         this.ID = ID;
      }

      public virtual string DatenAbfragen()
      {
         string daten = "Name : " + name;
         daten += ", Vorname : " + vorname;
         daten += ", Gehalt : " + gehalt + " Euro";
         daten += ", ID : " + ID;

         return daten;
      }

      public virtual void GehaltErhoehen(double gehalt)
      {
         this.gehalt += gehalt;
      }
        
   }
}
