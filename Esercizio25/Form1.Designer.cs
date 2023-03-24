namespace Esercizio25
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.aggiunta = new System.Windows.Forms.Button();
            this.eliminazione = new System.Windows.Forms.Button();
            this.texagg = new System.Windows.Forms.TextBox();
            this.texEli = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // aggiunta
            // 
            this.aggiunta.Location = new System.Drawing.Point(12, 20);
            this.aggiunta.Name = "aggiunta";
            this.aggiunta.Size = new System.Drawing.Size(140, 31);
            this.aggiunta.TabIndex = 0;
            this.aggiunta.Text = "Aggiunta";
            this.aggiunta.UseVisualStyleBackColor = true;
            this.aggiunta.Click += new System.EventHandler(this.aggiunta_Click);
            // 
            // eliminazione
            // 
            this.eliminazione.Location = new System.Drawing.Point(12, 108);
            this.eliminazione.Name = "eliminazione";
            this.eliminazione.Size = new System.Drawing.Size(140, 31);
            this.eliminazione.TabIndex = 1;
            this.eliminazione.Text = "Eliminazione";
            this.eliminazione.UseVisualStyleBackColor = true;
            // 
            // texagg
            // 
            this.texagg.Location = new System.Drawing.Point(12, 57);
            this.texagg.Multiline = true;
            this.texagg.Name = "texagg";
            this.texagg.Size = new System.Drawing.Size(140, 31);
            this.texagg.TabIndex = 3;
            // 
            // texEli
            // 
            this.texEli.Location = new System.Drawing.Point(12, 145);
            this.texEli.Multiline = true;
            this.texEli.Name = "texEli";
            this.texEli.Size = new System.Drawing.Size(140, 31);
            this.texEli.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(481, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 379);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 57);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 31);
            this.textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.texEli);
            this.Controls.Add(this.texagg);
            this.Controls.Add(this.eliminazione);
            this.Controls.Add(this.aggiunta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aggiunta;
        private System.Windows.Forms.Button eliminazione;
        private System.Windows.Forms.TextBox texagg;
        private System.Windows.Forms.TextBox texEli;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

