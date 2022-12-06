using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_ZinsBerechnung_Hasan_Barak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRechnen_Click(object sender, EventArgs e)
        {
             // Try
            try
            {
                // Variabeln Deklarieren
                // Variabeln Intialisieren
                // Convert.To - Formoberfläche eingegeben datentyp umwandeln
                double Kapital = Convert.ToDouble(txtEingabeKapital.Text);
                double zinsSatz = Convert.ToDouble(txtEingabeProzent.Text);
                double Zinsen = 0;

                // Zinsen Rechnen
                Zinsen = Kapital * (zinsSatz / 100);

                // Ausgeben
                // Zurückkonvertiert werden in string, für die ausgabe
                txtKapitalAusgabe.Text = Zinsen.ToString();
            }
            // Catch
            catch
            {
                // Fehler abfangen
                // Wenn der Code nicht funktioniert wird ein Absturz verhindert
                MessageBox.Show("Bitte geben sie Zahlenwerte in die eingabe ein.");
            }
        }
    }
}
