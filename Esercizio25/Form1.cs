using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            StreamWriter sr = new StreamWriter(path + @"\lista.txt",true);
            sr.WriteLine("Prodotto:"+ " " + texagg.Text + ";" + " " + "Prezzo: " + " " +  textBox2.Text +"€");
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
            String line;
            string s;
            line = sr.ReadLine();
            string[] vs = line.Split(';');

            while ((s = sr.ReadLine()) != null)
            {
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
    }
}
