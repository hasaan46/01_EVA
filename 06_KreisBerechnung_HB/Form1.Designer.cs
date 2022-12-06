
namespace _06_KreisBerechnung_HB
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxRadiuseingabe = new System.Windows.Forms.TextBox();
            this.txtBoxUmfangAusgabe = new System.Windows.Forms.TextBox();
            this.txtBoxFlächeAusgabe = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geben sie den Radius an:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Der Kreisumgfang beträgt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Die Fläche des kreises beträgt:";
            // 
            // txtBoxRadiuseingabe
            // 
            this.txtBoxRadiuseingabe.Location = new System.Drawing.Point(171, 42);
            this.txtBoxRadiuseingabe.Name = "txtBoxRadiuseingabe";
            this.txtBoxRadiuseingabe.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRadiuseingabe.TabIndex = 3;
            // 
            // txtBoxUmfangAusgabe
            // 
            this.txtBoxUmfangAusgabe.Location = new System.Drawing.Point(171, 91);
            this.txtBoxUmfangAusgabe.Name = "txtBoxUmfangAusgabe";
            this.txtBoxUmfangAusgabe.ReadOnly = true;
            this.txtBoxUmfangAusgabe.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUmfangAusgabe.TabIndex = 4;
            // 
            // txtBoxFlächeAusgabe
            // 
            this.txtBoxFlächeAusgabe.Location = new System.Drawing.Point(171, 140);
            this.txtBoxFlächeAusgabe.Name = "txtBoxFlächeAusgabe";
            this.txtBoxFlächeAusgabe.ReadOnly = true;
            this.txtBoxFlächeAusgabe.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFlächeAusgabe.TabIndex = 5;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(301, 91);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(94, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Berechnen";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(301, 186);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 221);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtBoxFlächeAusgabe);
            this.Controls.Add(this.txtBoxUmfangAusgabe);
            this.Controls.Add(this.txtBoxRadiuseingabe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kreisberechnung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxRadiuseingabe;
        private System.Windows.Forms.TextBox txtBoxUmfangAusgabe;
        private System.Windows.Forms.TextBox txtBoxFlächeAusgabe;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClose;
    }
}

