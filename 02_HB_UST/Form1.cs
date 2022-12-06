using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_HB_UST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            // Versuchen
            try
            {
            // Konstante für den Umsatzsteuersatz deklarieren
            const double mwSt = 1.19;

            // Variabeln Initialiseren
            // Variabeln Deklarieren
            double nettoBetrag = Convert.ToDouble(txtEingabeNetto.Text);
            double bruttoBetrag = 0;

            // Brechnen
            bruttoBetrag = nettoBetrag * mwSt;

            // Brutto ausgeben
            txtAusgabeBetrag.Text = bruttoBetrag.ToString("0.00" + " €");
            }
            // Fehler abfangen
            catch(FormatException)
            {
                MessageBox.Show("Bitte geben sie ein Richtiges Zahlenwert ein");
            }
            catch(OverflowException)
            {
                MessageBox.Show("Bitte geben sie eine kleinere Zahl ein");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Prorgramm schließen
            Close();
        }
    }
}
