
namespace _07_Inch_HB
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxEingabeCM = new System.Windows.Forms.TextBox();
            this.txtBoxAusgabeInch = new System.Windows.Forms.TextBox();
            this.txtBoxCMAusgabe = new System.Windows.Forms.TextBox();
            this.txtBoxInchEingabe = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inch:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Inch:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "CM:";
            // 
            // txtBoxEingabeCM
            // 
            this.txtBoxEingabeCM.Location = new System.Drawing.Point(55, 35);
            this.txtBoxEingabeCM.Name = "txtBoxEingabeCM";
            this.txtBoxEingabeCM.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEingabeCM.TabIndex = 4;
            // 
            // txtBoxAusgabeInch
            // 
            this.txtBoxAusgabeInch.Location = new System.Drawing.Point(55, 91);
            this.txtBoxAusgabeInch.Name = "txtBoxAusgabeInch";
            this.txtBoxAusgabeInch.ReadOnly = true;
            this.txtBoxAusgabeInch.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAusgabeInch.TabIndex = 5;
            // 
            // txtBoxCMAusgabe
            // 
            this.txtBoxCMAusgabe.Location = new System.Drawing.Point(241, 91);
            this.txtBoxCMAusgabe.Name = "txtBoxCMAusgabe";
            this.txtBoxCMAusgabe.ReadOnly = true;
            this.txtBoxCMAusgabe.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCMAusgabe.TabIndex = 7;
            // 
            // txtBoxInchEingabe
            // 
            this.txtBoxInchEingabe.Location = new System.Drawing.Point(241, 35);
            this.txtBoxInchEingabe.Name = "txtBoxInchEingabe";
            this.txtBoxInchEingabe.Size = new System.Drawing.Size(100, 20);
            this.txtBoxInchEingabe.TabIndex = 6;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(15, 136);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(326, 23);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Berechnen";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(241, 209);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 244);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtBoxCMAusgabe);
            this.Controls.Add(this.txtBoxInchEingabe);
            this.Controls.Add(this.txtBoxAusgabeInch);
            this.Controls.Add(this.txtBoxEingabeCM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CM to Inch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxEingabeCM;
        private System.Windows.Forms.TextBox txtBoxAusgabeInch;
        private System.Windows.Forms.TextBox txtBoxCMAusgabe;
        private System.Windows.Forms.TextBox txtBoxInchEingabe;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClose;
    }
}

