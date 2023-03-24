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

        private void textBoxwriter_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aggiunta_Click(object sender, EventArgs e)
        {
            StreamWriter sr = new StreamWriter(path + @"\lista.txt",true);
            sr.WriteLine("Prodotto:"+ " " + texagg.Text + " " + "Prezzo: " + " " +  textBox2.Text +"€");
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
        //public void Eliminazione []
    }
}
