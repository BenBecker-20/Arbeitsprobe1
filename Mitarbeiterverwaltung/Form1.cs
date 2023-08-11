using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitarbeiterverwaltung
{
   public partial class Form1 : Form
   {
      // Liste für die Mitarbeiterliste.

      private List<Mitarbeiter> personalliste;
      int index = 0;

        public Form1()
      {
         InitializeComponent();

            //Combobox
            comboBox_Position.Items.Add("Chef");
            comboBox_Position.Items.Add("Lehrling");
            comboBox_Position.Items.Add("Mitarbeiter");


            // Initialisierung
            personalliste = new List<Mitarbeiter>() ;
            personalliste.Add(new Mitarbeiter("Marx", "Groucho", 8000, 1));
            personalliste.Add(new Mitarbeiter("Marx", "Chico", 7000, 2));
            personalliste.Add(new Chef("Marx", "Harpo", 9000, 1));
            personalliste.Add(new Lehrling(true,"Marx", "Zeppo", 7000, 1));
            

      }

      private void btn_Ausgeben_Click(object sender, EventArgs e)
      {
         // Daten der Mitarbeiter anzeigen
         lb_Ausgabe.Text = "";
         foreach(var daten in personalliste)
            lb_Ausgabe.Text += daten.DatenAbfragen() + "\n";
      }

      private void btn_GehaltErhoehen_Click(object sender, EventArgs e)
      {
         // Gehälter aller Mitarbeiter erhöhen
         foreach (var daten in personalliste)
         {
            daten.GehaltErhoehen(250);
         }

         btn_Ausgeben.PerformClick();
      }

        private void button1_Click(object sender, EventArgs e) //vor button
        {
            if(index < personalliste.Count - 1)
            {
                index++;
                lb_Ausgabe.Text = personalliste[index].DatenAbfragen();
                
            }
        }

        private void button3_Click(object sender, EventArgs e) //zurück taste
        {
            if(index > 0)
            {
                index--;

                lb_Ausgabe.Text = personalliste[index].DatenAbfragen();
            }
        }

        private void button2_Click(object sender, EventArgs e) //Anlegen
        {
            int zahl = personalliste.Count();
           
               if (comboBox_Position.SelectedIndex == 0)
                {
                    personalliste.Add(new Chef(textBox_Vorname.Text, textBox_Nachname.Text, Convert.ToDouble(textBox_Gehalt.Text), Convert.ToInt32(textBox_ID.Text)));
                }


                if (comboBox_Position.SelectedIndex == 1)
                {
                   personalliste.Add(new Lehrling(checkBox1.Checked,textBox_Vorname.Text, textBox_Nachname.Text, Convert.ToDouble(textBox_Gehalt.Text), Convert.ToInt32(textBox_ID.Text)));
                }
                if (comboBox_Position.SelectedIndex == 2)
                {
                    personalliste.Add(new Mitarbeiter(textBox_Vorname.Text, textBox_Nachname.Text, Convert.ToDouble(textBox_Gehalt.Text), Convert.ToInt32(textBox_ID.Text)));
                }

            }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Position_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Position.SelectedIndex == 1)
            {
                checkBox1.Enabled = true;
            }
            else
            {
                checkBox1.Enabled = false;
            }
        }
    }
    }

