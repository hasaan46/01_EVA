
namespace _05_Energieverbrauch_HB
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
            this.txtBoxLeistungEingabe = new System.Windows.Forms.TextBox();
            this.txtBoxStundenEingabe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxTageEingabe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.txtBoxKwhAusgabe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elektrische Leistung (kw)";
            // 
            // txtBoxLeistungEingabe
            // 
            this.txtBoxLeistungEingabe.Location = new System.Drawing.Point(174, 35);
            this.txtBoxLeistungEingabe.Name = "txtBoxLeistungEingabe";
            this.txtBoxLeistungEingabe.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLeistungEingabe.TabIndex = 1;
            // 
            // txtBoxStundenEingabe
            // 
            this.txtBoxStundenEingabe.Location = new System.Drawing.Point(174, 78);
            this.txtBoxStundenEingabe.Name = "txtBoxStundenEingabe";
            this.txtBoxStundenEingabe.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStundenEingabe.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stunden je Tag";
            // 
            // txtBoxTageEingabe
            // 
            this.txtBoxTageEingabe.Location = new System.Drawing.Point(174, 119);
            this.txtBoxTageEingabe.Name = "txtBoxTageEingabe";
            this.txtBoxTageEingabe.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTageEingabe.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tage pro Jahr";
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(15, 166);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(259, 32);
            this.btnBerechnen.TabIndex = 6;
            this.btnBerechnen.Text = "Energieverbrauch berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // txtBoxKwhAusgabe
            // 
            this.txtBoxKwhAusgabe.Location = new System.Drawing.Point(174, 216);
            this.txtBoxKwhAusgabe.Name = "txtBoxKwhAusgabe";
            this.txtBoxKwhAusgabe.ReadOnly = true;
            this.txtBoxKwhAusgabe.Size = new System.Drawing.Size(100, 20);
            this.txtBoxKwhAusgabe.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Energieverbrauch (kwh)";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(15, 261);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(259, 32);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(286, 312);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtBoxKwhAusgabe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.txtBoxTageEingabe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxStundenEingabe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxLeistungEingabe);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Energieverbrauchrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxLeistungEingabe;
        private System.Windows.Forms.TextBox txtBoxStundenEingabe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxTageEingabe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.TextBox txtBoxKwhAusgabe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
    }
}

