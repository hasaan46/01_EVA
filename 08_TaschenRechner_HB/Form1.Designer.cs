
namespace _08_TaschenRechner_HB
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
            this.txtBoxZahl1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxZahl2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtErgebniss = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMal = new System.Windows.Forms.Button();
            this.btnGeteilt = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxZahl1
            // 
            this.txtBoxZahl1.Location = new System.Drawing.Point(71, 26);
            this.txtBoxZahl1.Name = "txtBoxZahl1";
            this.txtBoxZahl1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxZahl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zahl 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zahl 2:";
            // 
            // txtBoxZahl2
            // 
            this.txtBoxZahl2.Location = new System.Drawing.Point(71, 70);
            this.txtBoxZahl2.Name = "txtBoxZahl2";
            this.txtBoxZahl2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxZahl2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ergebniss:";
            // 
            // txtErgebniss
            // 
            this.txtErgebniss.Location = new System.Drawing.Point(71, 119);
            this.txtErgebniss.Name = "txtErgebniss";
            this.txtErgebniss.ReadOnly = true;
            this.txtErgebniss.Size = new System.Drawing.Size(100, 20);
            this.txtErgebniss.TabIndex = 4;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(233, 26);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(24, 23);
            this.btnPlus.TabIndex = 6;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(286, 26);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(24, 23);
            this.btnMinus.TabIndex = 7;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMal
            // 
            this.btnMal.Location = new System.Drawing.Point(233, 67);
            this.btnMal.Name = "btnMal";
            this.btnMal.Size = new System.Drawing.Size(24, 23);
            this.btnMal.TabIndex = 8;
            this.btnMal.Text = "*";
            this.btnMal.UseVisualStyleBackColor = true;
            this.btnMal.Click += new System.EventHandler(this.btnMal_Click);
            // 
            // btnGeteilt
            // 
            this.btnGeteilt.Location = new System.Drawing.Point(286, 68);
            this.btnGeteilt.Name = "btnGeteilt";
            this.btnGeteilt.Size = new System.Drawing.Size(24, 23);
            this.btnGeteilt.TabIndex = 9;
            this.btnGeteilt.Text = "/";
            this.btnGeteilt.UseVisualStyleBackColor = true;
            this.btnGeteilt.Click += new System.EventHandler(this.btnGeteilt_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(303, 157);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 192);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGeteilt);
            this.Controls.Add(this.btnMal);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtErgebniss);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxZahl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxZahl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxZahl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxZahl2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtErgebniss;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMal;
        private System.Windows.Forms.Button btnGeteilt;
        private System.Windows.Forms.Button btnClose;
    }
}

