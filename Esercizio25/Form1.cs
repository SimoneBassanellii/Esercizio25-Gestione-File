using System;
using System.IO;
using System.Windows.Forms;

namespace Esercizio25
{
    public partial class Form1 : Form
    {
        public string path;

        public Form1()
        {
            InitializeComponent();
            path = Path.GetFullPath(".");
            path = Path.GetDirectoryName(path);
            path = Path.GetDirectoryName(path);
            path = Path.GetDirectoryName(path);
            path += @"\liste";
            Directory.CreateDirectory(path);
            StreamWriter sr = new StreamWriter(path + @"\lista.txt");
            sr.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aggiunta_Click(object sender, EventArgs e)
        {
            StreamWriter sr = new StreamWriter(path + @"\lista.txt", true);
            sr.WriteLine("Prodotto:" + " " + texagg.Text + ";" + " " + "Prezzo: " + " " + textBox2.Text + "€");
            sr.Close();
            Listaprodotti.Items.Clear();
            Lista();
        }

        //funzione lista 
        private void Lista()
        {
            string[] lines = File.ReadAllLines(path + @"\lista.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                Listaprodotti.Items.Add(lines[i]);
            }
        }


        //funzione eliminazione
        public void Elimina(string nome)
        {
            StreamWriter sw = new StreamWriter(path + @"\eliminazione.txt");
            StreamReader sr = new StreamReader(path + @"\lista.txt");
            //String line;
            string s;

            while ((s = sr.Equals()) != null)
            {
                string[] vs = s.Split(';');

                //se il nome appartiene alla stringa 
                if (s.Contains(nome))
                {
                    sw.WriteLine();
                }
                else
                {
                    sw.WriteLine(s);
                }
            }
            sr.Close();
            sw.Close();
            File.Delete(path + @"/lista.txt");

            //e rinomino il file momentaneo, rendendolo il nuovo principale
            File.Move(path + @"/eliminazione.txt", path + @"/lista.txt");
        }

        private void eliminazione_Click(object sender, EventArgs e)
        {
            Elimina(texagg.Text);
            texagg.Text = "";
            texagg.Focus();
        }

        public void Modifica(string nomevecchio, string prezzo, string nomemodificato)

        {
            //File di lettura
            using (StreamReader sw = File.OpenText(path + @"/lista.txt"))
            {
                string s;

                //File di scrittura
                using (StreamWriter sw2 = new StreamWriter(path + @"/eliminazione.txt", false))
                {

                    while ((s = sw.ReadLine()) != null)
                    { 
                        if (s.Contains(nomevecchio))
                        {
                            sw2.WriteLine("Prodotto: " + nomemodificato + " , Prezzo: " + prezzo + " $");
                        }
                        else
                        {
                            sw2.WriteLine(s);
                        }

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
