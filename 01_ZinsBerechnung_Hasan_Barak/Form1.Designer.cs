
namespace _01_ZinsBerechnung_Hasan_Barak
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKapital = new System.Windows.Forms.Label();
            this.txtEingabeKapital = new System.Windows.Forms.TextBox();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblZinssatz = new System.Windows.Forms.Label();
            this.txtEingabeProzent = new System.Windows.Forms.TextBox();
            this.lblProzent = new System.Windows.Forms.Label();
            this.btnRechnen = new System.Windows.Forms.Button();
            this.lblEuro1 = new System.Windows.Forms.Label();
            this.txtKapitalAusgabe = new System.Windows.Forms.TextBox();
            this.lblZinsen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKapital
            // 
            this.lblKapital.AutoSize = true;
            this.lblKapital.Location = new System.Drawing.Point(12, 33);
            this.lblKapital.Name = "lblKapital";
            this.lblKapital.Size = new System.Drawing.Size(39, 13);
            this.lblKapital.TabIndex = 0;
            this.lblKapital.Text = "Kapital";
            // 
            // txtEingabeKapital
            // 
            this.txtEingabeKapital.Location = new System.Drawing.Point(57, 30);
            this.txtEingabeKapital.Name = "txtEingabeKapital";
            this.txtEingabeKapital.Size = new System.Drawing.Size(100, 20);
            this.txtEingabeKapital.TabIndex = 1;
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(163, 33);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(29, 13);
            this.lblEuro.TabIndex = 2;
            this.lblEuro.Text = "Euro";
            // 
            // lblZinssatz
            // 
            this.lblZinssatz.AutoSize = true;
            this.lblZinssatz.Location = new System.Drawing.Point(12, 78);
            this.lblZinssatz.Name = "lblZinssatz";
            this.lblZinssatz.Size = new System.Drawing.Size(46, 13);
            this.lblZinssatz.TabIndex = 3;
            this.lblZinssatz.Text = "Zinssatz";
            // 
            // txtEingabeProzent
            // 
            this.txtEingabeProzent.Location = new System.Drawing.Point(57, 75);
            this.txtEingabeProzent.Name = "txtEingabeProzent";
            this.txtEingabeProzent.Size = new System.Drawing.Size(100, 20);
            this.txtEingabeProzent.TabIndex = 4;
            // 
            // lblProzent
            // 
            this.lblProzent.AutoSize = true;
            this.lblProzent.Location = new System.Drawing.Point(163, 78);
            this.lblProzent.Name = "lblProzent";
            this.lblProzent.Size = new System.Drawing.Size(43, 13);
            this.lblProzent.TabIndex = 5;
            this.lblProzent.Text = "Prozent";
            // 
            // btnRechnen
            // 
            this.btnRechnen.Location = new System.Drawing.Point(15, 115);
            this.btnRechnen.Name = "btnRechnen";
            this.btnRechnen.Size = new System.Drawing.Size(177, 23);
            this.btnRechnen.TabIndex = 6;
            this.btnRechnen.Text = "Zins berechnen";
            this.btnRechnen.UseVisualStyleBackColor = true;
            this.btnRechnen.Click += new System.EventHandler(this.btnRechnen_Click);
            // 
            // lblEuro1
            // 
            this.lblEuro1.AutoSize = true;
            this.lblEuro1.Location = new System.Drawing.Point(163, 163);
            this.lblEuro1.Name = "lblEuro1";
            this.lblEuro1.Size = new System.Drawing.Size(29, 13);
            this.lblEuro1.TabIndex = 9;
            this.lblEuro1.Text = "Euro";
            // 
            // txtKapitalAusgabe
            // 
            this.txtKapitalAusgabe.Location = new System.Drawing.Point(57, 160);
            this.txtKapitalAusgabe.Name = "txtKapitalAusgabe";
            this.txtKapitalAusgabe.ReadOnly = true;
            this.txtKapitalAusgabe.Size = new System.Drawing.Size(100, 20);
            this.txtKapitalAusgabe.TabIndex = 8;
            // 
            // lblZinsen
            // 
            this.lblZinsen.AutoSize = true;
            this.lblZinsen.Location = new System.Drawing.Point(12, 163);
            this.lblZinsen.Name = "lblZinsen";
            this.lblZinsen.Size = new System.Drawing.Size(39, 13);
            this.lblZinsen.TabIndex = 7;
            this.lblZinsen.Text = "Zinsen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 206);
            this.Controls.Add(this.lblEuro1);
            this.Controls.Add(this.txtKapitalAusgabe);
            this.Controls.Add(this.lblZinsen);
            this.Controls.Add(this.btnRechnen);
            this.Controls.Add(this.lblProzent);
            this.Controls.Add(this.txtEingabeProzent);
            this.Controls.Add(this.lblZinssatz);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.txtEingabeKapital);
            this.Controls.Add(this.lblKapital);
            this.Name = "Form1";
            this.Text = "01_Zinsrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKapital;
        private System.Windows.Forms.TextBox txtEingabeKapital;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblZinssatz;
        private System.Windows.Forms.TextBox txtEingabeProzent;
        private System.Windows.Forms.Label lblProzent;
        private System.Windows.Forms.Button btnRechnen;
        private System.Windows.Forms.Label lblEuro1;
        private System.Windows.Forms.TextBox txtKapitalAusgabe;
        private System.Windows.Forms.Label lblZinsen;
    }
}

