
namespace _04_HB_EKP
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
            this.lblEuroWert = new System.Windows.Forms.Label();
            this.lblListenpreis = new System.Windows.Forms.Label();
            this.txtBoxEingabeListenpreis = new System.Windows.Forms.TextBox();
            this.txtBoxRabattAusgabe = new System.Windows.Forms.TextBox();
            this.lblRabatt = new System.Windows.Forms.Label();
            this.txtBoxZielEinkaufAusgabe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxSkonto = new System.Windows.Forms.TextBox();
            this.lblSkonto = new System.Windows.Forms.Label();
            this.txtBoxAusgabeBareinkaufs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxTransportEingabe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxEinstandAusgabe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxRabattEingabe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxSkontoEingabe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEuroWert
            // 
            this.lblEuroWert.AutoSize = true;
            this.lblEuroWert.Location = new System.Drawing.Point(110, 85);
            this.lblEuroWert.Name = "lblEuroWert";
            this.lblEuroWert.Size = new System.Drawing.Size(56, 13);
            this.lblEuroWert.TabIndex = 0;
            this.lblEuroWert.Text = "Werte in €";
            // 
            // lblListenpreis
            // 
            this.lblListenpreis.AutoSize = true;
            this.lblListenpreis.Location = new System.Drawing.Point(12, 117);
            this.lblListenpreis.Name = "lblListenpreis";
            this.lblListenpreis.Size = new System.Drawing.Size(57, 13);
            this.lblListenpreis.TabIndex = 1;
            this.lblListenpreis.Text = "Listenpreis";
            // 
            // txtBoxEingabeListenpreis
            // 
            this.txtBoxEingabeListenpreis.Location = new System.Drawing.Point(113, 114);
            this.txtBoxEingabeListenpreis.Name = "txtBoxEingabeListenpreis";
            this.txtBoxEingabeListenpreis.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEingabeListenpreis.TabIndex = 2;
            // 
            // txtBoxRabattAusgabe
            // 
            this.txtBoxRabattAusgabe.Location = new System.Drawing.Point(113, 151);
            this.txtBoxRabattAusgabe.Name = "txtBoxRabattAusgabe";
            this.txtBoxRabattAusgabe.ReadOnly = true;
            this.txtBoxRabattAusgabe.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRabattAusgabe.TabIndex = 4;
            // 
            // lblRabatt
            // 
            this.lblRabatt.AutoSize = true;
            this.lblRabatt.Location = new System.Drawing.Point(12, 158);
            this.lblRabatt.Name = "lblRabatt";
            this.lblRabatt.Size = new System.Drawing.Size(45, 13);
            this.lblRabatt.TabIndex = 3;
            this.lblRabatt.Text = "- Rabatt";
            // 
            // txtBoxZielEinkaufAusgabe
            // 
            this.txtBoxZielEinkaufAusgabe.Location = new System.Drawing.Point(113, 196);
            this.txtBoxZielEinkaufAusgabe.Name = "txtBoxZielEinkaufAusgabe";
            this.txtBoxZielEinkaufAusgabe.ReadOnly = true;
            this.txtBoxZielEinkaufAusgabe.Size = new System.Drawing.Size(100, 20);
            this.txtBoxZielEinkaufAusgabe.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "= Zieleinkaufspreis";
            // 
            // txtBoxSkonto
            // 
            this.txtBoxSkonto.Location = new System.Drawing.Point(113, 238);
            this.txtBoxSkonto.Name = "txtBoxSkonto";
            this.txtBoxSkonto.ReadOnly = true;
            this.txtBoxSkonto.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSkonto.TabIndex = 8;
            // 
            // lblSkonto
            // 
            this.lblSkonto.AutoSize = true;
            this.lblSkonto.Location = new System.Drawing.Point(12, 241);
            this.lblSkonto.Name = "lblSkonto";
            this.lblSkonto.Size = new System.Drawing.Size(47, 13);
            this.lblSkonto.TabIndex = 7;
            this.lblSkonto.Text = "- Skonto";
            // 
            // txtBoxAusgabeBareinkaufs
            // 
            this.txtBoxAusgabeBareinkaufs.Location = new System.Drawing.Point(113, 281);
            this.txtBoxAusgabeBareinkaufs.Name = "txtBoxAusgabeBareinkaufs";
            this.txtBoxAusgabeBareinkaufs.ReadOnly = true;
            this.txtBoxAusgabeBareinkaufs.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAusgabeBareinkaufs.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "= Bareinkausfspreis";
            // 
            // txtBoxTransportEingabe
            // 
            this.txtBoxTransportEingabe.Location = new System.Drawing.Point(113, 316);
            this.txtBoxTransportEingabe.Name = "txtBoxTransportEingabe";
            this.txtBoxTransportEingabe.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTransportEingabe.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "- Transportkosten";
            // 
            // txtBoxEinstandAusgabe
            // 
            this.txtBoxEinstandAusgabe.Location = new System.Drawing.Point(113, 353);
            this.txtBoxEinstandAusgabe.Name = "txtBoxEinstandAusgabe";
            this.txtBoxEinstandAusgabe.ReadOnly = true;
            this.txtBoxEinstandAusgabe.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEinstandAusgabe.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "= Einstandspreis";
            // 
            // txtBoxRabattEingabe
            // 
            this.txtBoxRabattEingabe.Location = new System.Drawing.Point(274, 12);
            this.txtBoxRabattEingabe.Name = "txtBoxRabattEingabe";
            this.txtBoxRabattEingabe.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRabattEingabe.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Rabatt in %";
            // 
            // txtBoxSkontoEingabe
            // 
            this.txtBoxSkontoEingabe.Location = new System.Drawing.Point(274, 47);
            this.txtBoxSkontoEingabe.Name = "txtBoxSkontoEingabe";
            this.txtBoxSkontoEingabe.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSkontoEingabe.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Skonto in %";
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(15, 401);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(198, 23);
            this.btnBerechnen.TabIndex = 19;
            this.btnBerechnen.Text = "Berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(232, 401);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 23);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 448);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.txtBoxSkontoEingabe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxRabattEingabe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxEinstandAusgabe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxTransportEingabe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxAusgabeBareinkaufs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxSkonto);
            this.Controls.Add(this.lblSkonto);
            this.Controls.Add(this.txtBoxZielEinkaufAusgabe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxRabattAusgabe);
            this.Controls.Add(this.lblRabatt);
            this.Controls.Add(this.txtBoxEingabeListenpreis);
            this.Controls.Add(this.lblListenpreis);
            this.Controls.Add(this.lblEuroWert);
            this.Name = "Form1";
            this.Text = "EKP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEuroWert;
        private System.Windows.Forms.Label lblListenpreis;
        private System.Windows.Forms.TextBox txtBoxEingabeListenpreis;
        private System.Windows.Forms.TextBox txtBoxRabattAusgabe;
        private System.Windows.Forms.Label lblRabatt;
        private System.Windows.Forms.TextBox txtBoxZielEinkaufAusgabe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxSkonto;
        private System.Windows.Forms.Label lblSkonto;
        private System.Windows.Forms.TextBox txtBoxAusgabeBareinkaufs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxTransportEingabe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxEinstandAusgabe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxRabattEingabe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxSkontoEingabe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Button btnClose;
    }
}

