
namespace _02_HB_UST
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
            this.txtEingabeNetto = new System.Windows.Forms.TextBox();
            this.lblNetto = new System.Windows.Forms.Label();
            this.lblBrutto = new System.Windows.Forms.Label();
            this.txtAusgabeBetrag = new System.Windows.Forms.TextBox();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEingabeNetto
            // 
            this.txtEingabeNetto.Location = new System.Drawing.Point(81, 31);
            this.txtEingabeNetto.Name = "txtEingabeNetto";
            this.txtEingabeNetto.Size = new System.Drawing.Size(100, 20);
            this.txtEingabeNetto.TabIndex = 0;
            // 
            // lblNetto
            // 
            this.lblNetto.AutoSize = true;
            this.lblNetto.Location = new System.Drawing.Point(12, 34);
            this.lblNetto.Name = "lblNetto";
            this.lblNetto.Size = new System.Drawing.Size(63, 13);
            this.lblNetto.TabIndex = 1;
            this.lblNetto.Text = "Nettobetrag";
            // 
            // lblBrutto
            // 
            this.lblBrutto.AutoSize = true;
            this.lblBrutto.Location = new System.Drawing.Point(12, 80);
            this.lblBrutto.Name = "lblBrutto";
            this.lblBrutto.Size = new System.Drawing.Size(65, 13);
            this.lblBrutto.TabIndex = 3;
            this.lblBrutto.Text = "Bruttobetrag";
            // 
            // txtAusgabeBetrag
            // 
            this.txtAusgabeBetrag.Location = new System.Drawing.Point(81, 77);
            this.txtAusgabeBetrag.Name = "txtAusgabeBetrag";
            this.txtAusgabeBetrag.ReadOnly = true;
            this.txtAusgabeBetrag.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeBetrag.TabIndex = 2;
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(187, 49);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(90, 44);
            this.btnBerechnen.TabIndex = 4;
            this.btnBerechnen.Text = "Bruttobetrag berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 125);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 22);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 158);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.lblBrutto);
            this.Controls.Add(this.txtAusgabeBetrag);
            this.Controls.Add(this.lblNetto);
            this.Controls.Add(this.txtEingabeNetto);
            this.Name = "Form1";
            this.Text = "02_Umsatzsteuer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEingabeNetto;
        private System.Windows.Forms.Label lblNetto;
        private System.Windows.Forms.Label lblBrutto;
        private System.Windows.Forms.TextBox txtAusgabeBetrag;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Button btnClose;
    }
}

