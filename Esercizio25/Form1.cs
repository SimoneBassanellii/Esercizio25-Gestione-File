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
        public string percorsoFile= @"C:\Users\bassanelli.20180\source\repos\Esercizio25";
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

        }

        private void textBoxwriter_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void writer_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(percorsoFile);
            sw.WriteLine("Hello World");
            sw.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
