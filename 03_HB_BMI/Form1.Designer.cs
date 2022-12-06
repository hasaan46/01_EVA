
namespace _03_HB_BMI
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
            this.lblGrosseM = new System.Windows.Forms.Label();
            this.txtEingabeM = new System.Windows.Forms.TextBox();
            this.txtEingabeKG = new System.Windows.Forms.TextBox();
            this.lblGewichtKG = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAusgabeBMI = new System.Windows.Forms.TextBox();
            this.lblBMI = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGrosseM
            // 
            this.lblGrosseM.AutoSize = true;
            this.lblGrosseM.Location = new System.Drawing.Point(12, 9);
            this.lblGrosseM.Name = "lblGrosseM";
            this.lblGrosseM.Size = new System.Drawing.Size(58, 13);
            this.lblGrosseM.TabIndex = 0;
            this.lblGrosseM.Text = "Größe in m";
            // 
            // txtEingabeM
            // 
            this.txtEingabeM.Location = new System.Drawing.Point(88, 6);
            this.txtEingabeM.Name = "txtEingabeM";
            this.txtEingabeM.Size = new System.Drawing.Size(100, 20);
            this.txtEingabeM.TabIndex = 1;
            // 
            // txtEingabeKG
            // 
            this.txtEingabeKG.Location = new System.Drawing.Point(88, 45);
            this.txtEingabeKG.Name = "txtEingabeKG";
            this.txtEingabeKG.Size = new System.Drawing.Size(100, 20);
            this.txtEingabeKG.TabIndex = 3;
            // 
            // lblGewichtKG
            // 
            this.lblGewichtKG.AutoSize = true;
            this.lblGewichtKG.Location = new System.Drawing.Point(12, 48);
            this.lblGewichtKG.Name = "lblGewichtKG";
            this.lblGewichtKG.Size = new System.Drawing.Size(75, 13);
            this.lblGewichtKG.TabIndex = 2;
            this.lblGewichtKG.Text = "Gewicht in KG";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "BMI Berechnen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAusgabeBMI
            // 
            this.txtAusgabeBMI.Location = new System.Drawing.Point(88, 139);
            this.txtAusgabeBMI.Name = "txtAusgabeBMI";
            this.txtAusgabeBMI.ReadOnly = true;
            this.txtAusgabeBMI.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeBMI.TabIndex = 6;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(12, 142);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(54, 13);
            this.lblBMI.TabIndex = 5;
            this.lblBMI.Text = "Ihr BMI ist";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(15, 165);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(173, 32);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 208);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtAusgabeBMI);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEingabeKG);
            this.Controls.Add(this.lblGewichtKG);
            this.Controls.Add(this.txtEingabeM);
            this.Controls.Add(this.lblGrosseM);
            this.Name = "Form1";
            this.Text = "03_BMI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrosseM;
        private System.Windows.Forms.TextBox txtEingabeM;
        private System.Windows.Forms.TextBox txtEingabeKG;
        private System.Windows.Forms.Label lblGewichtKG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAusgabeBMI;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Button btnClose;
    }
}

