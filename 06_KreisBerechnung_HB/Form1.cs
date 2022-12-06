using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_KreisBerechnung_HB
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
            try
            {
                // Deklarieren und Initalisieren
                double Radius = Convert.ToDouble(txtBoxRadiuseingabe.Text);
                double Umfang;
                double Fläche;

                // Rechnen
                Umfang = 2 * Math.PI * Radius;
                Fläche = Math.PI * Math.Pow(Radius, 2);

                // Ausgeben
                txtBoxFlächeAusgabe.Text = Fläche.ToString();
                txtBoxUmfangAusgabe.Text = Umfang.ToString();
            }
            catch
            {
                // Fehler abfangen
                MessageBox.Show("Bitte geben sie gültige Werte ein!", "Ein fehler ist aufgetreten!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
