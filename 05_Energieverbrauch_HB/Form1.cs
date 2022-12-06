using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Energieverbrauch_HB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            // Versuchen
            try
            {
                /* 
                 deklarieren = eine Variable wird "bekannt gemacht"
                 Datentyp Variablenname;
                 z.B. double zahl;
                 Initialisieren = der Variablen wird ein Wert zugewiesen
                 deklarieren und initialiseren in einem Schritt:
                 z.B. double zahl = 10; */

                /* 
                 Variaben deklarieren und Nutzereingaben als
                 Initialwerte zu speichern
                 Die nutzereingabe muss von string in double konvertiert werden,
                 da eingaben auf der oberflöche immer den Datentyp string haben */
                
                double KW = Convert.ToDouble(txtBoxLeistungEingabe.Text);
                int Tage = Convert.ToInt16(txtBoxTageEingabe.Text);
                int Stunden = Convert.ToInt16(txtBoxStundenEingabe.Text);
                double Energieverbrauch;

                // Rechnen
                Energieverbrauch = KW * Stunden * Tage;

                // Ausgeben
                txtBoxKwhAusgabe.Text = Energieverbrauch.ToString();
            }
            // Abfangen
            catch (FormatException)
            {
                // Fehler abfangen
                MessageBox.Show("Bitte geben sie nur Gültige werte ein! Stunden und Tage müssen in gnaze Zahlen eingegeben werden!", "Fehler aufgetreten");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Die von ihnen eingegebenen Werte sind zu groß!", "Fehler aufgetreten");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Programm schließen
            Close();
        }
    }
}
