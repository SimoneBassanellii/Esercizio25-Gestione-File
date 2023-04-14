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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Listaprodotti = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // aggiunta
            // 
            this.aggiunta.Location = new System.Drawing.Point(49, 20);
            this.aggiunta.Name = "aggiunta";
            this.aggiunta.Size = new System.Drawing.Size(140, 31);
            this.aggiunta.TabIndex = 0;
            this.aggiunta.Text = "Aggiunta";
            this.aggiunta.UseVisualStyleBackColor = true;
            this.aggiunta.Click += new System.EventHandler(this.aggiunta_Click);
            // 
            // eliminazione
            // 
            this.eliminazione.Location = new System.Drawing.Point(204, 20);
            this.eliminazione.Name = "eliminazione";
            this.eliminazione.Size = new System.Drawing.Size(140, 31);
            this.eliminazione.TabIndex = 1;
            this.eliminazione.Text = "Eliminazione";
            this.eliminazione.UseVisualStyleBackColor = true;
            this.eliminazione.Click += new System.EventHandler(this.eliminazione_Click);
            // 
            // texagg
            // 
            this.texagg.Location = new System.Drawing.Point(49, 71);
            this.texagg.Name = "texagg";
            this.texagg.Size = new System.Drawing.Size(140, 20);
            this.texagg.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(204, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 6;
            // 
            // Listaprodotti
            // 
            this.Listaprodotti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Listaprodotti.HideSelection = false;
            this.Listaprodotti.LabelWrap = false;
            this.Listaprodotti.Location = new System.Drawing.Point(416, 20);
            this.Listaprodotti.MultiSelect = false;
            this.Listaprodotti.Name = "Listaprodotti";
            this.Listaprodotti.ShowGroups = false;
            this.Listaprodotti.Size = new System.Drawing.Size(360, 418);
            this.Listaprodotti.TabIndex = 7;
            this.Listaprodotti.UseCompatibleStateImageBehavior = false;
            this.Listaprodotti.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Prodotto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prezzo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Modifica";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Prezzo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Prodotto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(49, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 20);
            this.textBox3.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Listaprodotti);
            this.Controls.Add(this.textBox2);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView Listaprodotti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
    }
}

