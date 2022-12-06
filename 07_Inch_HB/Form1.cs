using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Inch_HB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Versuchen
            try
            {
                // Deklarieren und Initialisieren
                double InchEingabe = Convert.ToDouble(txtBoxInchEingabe.Text);
                double CmEingabe = Convert.ToDouble(txtBoxEingabeCM.Text);
                double InchAusgabe;
                double CmAusgabe;

                // Berechnen
                InchAusgabe = CmEingabe * 2.54;
                CmAusgabe = InchEingabe / 2.54;

                // Ausgeben
                txtBoxCMAusgabe.Text = CmAusgabe.ToString();
                txtBoxAusgabeInch.Text = InchAusgabe.ToString();
            }
            catch
            {
                MessageBox.Show("Bitte geben sie Zahlen werte ein!", "Fehler aufgetreten!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
