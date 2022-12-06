using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_HB_BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Versuchen
            try
            {
                // Initialiseren
                // Deklarieren
                double meter = Convert.ToDouble(txtEingabeM.Text);
                double kg = Convert.ToDouble(txtEingabeKG.Text);
                double BMI;

                // Berechnen
                BMI = kg / (Math.Pow(meter, 2));

                // Werte Runden
                BMI = Math.Round(BMI, 2);

                // Ausgeben
                txtAusgabeBMI.Text = BMI.ToString();
            }
            // Catchen
            catch
            {
                MessageBox.Show("Geben sie bitte gültigte werte ein!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
