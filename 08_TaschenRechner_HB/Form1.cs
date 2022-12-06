using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_TaschenRechner_HB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialiseren und deklarieren
                double Zahl1 = Convert.ToDouble(txtBoxZahl1.Text);
                double Zahl2 = Convert.ToDouble(txtBoxZahl2.Text);
                double Ergebniss;

                // Rechnen
                Ergebniss = Zahl1 + Zahl2;

                // Ausgeben
                txtErgebniss.Text = Ergebniss.ToString();
            }
            catch
            {
                MessageBox.Show("Bitte geben sie gültige werte ein!");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialiseren und deklarieren
                double Zahl1 = Convert.ToDouble(txtBoxZahl1.Text);
                double Zahl2 = Convert.ToDouble(txtBoxZahl2.Text);
                double Ergebniss;

                // Rechnen
                Ergebniss = Zahl1 - Zahl2;

                // Ausgeben
                txtErgebniss.Text = Ergebniss.ToString();
            }
            catch
            {
                MessageBox.Show("Bitte geben sie gültige werte ein!");
            }
        }

        private void btnMal_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialiseren und deklarieren
                double Zahl1 = Convert.ToDouble(txtBoxZahl1.Text);
                double Zahl2 = Convert.ToDouble(txtBoxZahl2.Text);
                double Ergebniss;

                // Rechnen
                Ergebniss = Zahl1 * Zahl2;

                // Ausgeben
                txtErgebniss.Text = Ergebniss.ToString();
            }
            catch
            {
                MessageBox.Show("Bitte geben sie gültige werte ein!");
            }
        }

        private void btnGeteilt_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialiseren und deklarieren
                double Zahl1 = Convert.ToDouble(txtBoxZahl1.Text);
                double Zahl2 = Convert.ToDouble(txtBoxZahl2.Text);
                double Ergebniss;

                // Rechnen
                Ergebniss = Zahl1 / Zahl2;

                // Ausgeben
                txtErgebniss.Text = Ergebniss.ToString();
            }
            catch
            {
                MessageBox.Show("Bitte geben sie gültige werte ein!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
