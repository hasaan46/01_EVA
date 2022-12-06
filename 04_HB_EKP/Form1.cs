using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_HB_EKP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            // Verscuhen
            try
            {
                // Variabeln deklarieren und mit Nutzereingaben initialisieren
                // dazu werte von string in double konventieren

                double listenPreis = Convert.ToDouble(txtBoxEingabeListenpreis.Text);
                double transportKosten = Convert.ToDouble(txtBoxTransportEingabe.Text);
                double rabattProzent = Convert.ToDouble(txtBoxRabattEingabe.Text) / 100;
                double skontoProzent = Convert.ToDouble(txtBoxSkontoEingabe.Text) / 100;

                // Deklarieren der Variabeln, deren Werte berechnet werden müssen
                double rabattEuro = 0;
                double zek = 0; // Zieleinkaufspreis
                double skontoEuro = 0;
                double barEK = 0;
                double einstPreis = 0;

                // Berechnung der Variabelnwerte
                rabattEuro = listenPreis * rabattProzent;
                zek = listenPreis - rabattEuro;
                skontoEuro = zek * skontoProzent;
                barEK = zek - skontoEuro;
                einstPreis = barEK + transportKosten;

                // Alles ausgeben
                txtBoxRabattAusgabe.Text = Math.Round(rabattEuro,2).ToString("0.00" + " €");
                txtBoxAusgabeBareinkaufs.Text = Math.Round(barEK, 2).ToString("0.00" + " €");
                txtBoxSkonto.Text = Math.Round(skontoEuro, 2).ToString("0.00" + " €");
                txtBoxZielEinkaufAusgabe.Text = Math.Round(zek, 2).ToString("0.00" + " €");
                txtBoxEinstandAusgabe.Text = Math.Round(einstPreis, 2).ToString("0.00" + " €");
            }
            // Catchen
            catch
            {
                // Fehler ausgeben
                MessageBox.Show("Bitte geben sie in allen Eingabetextfeldern gültige werte ein!", "Fehler aufgetreten");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Programm schließen
            Close();
        }
    }
}
