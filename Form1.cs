using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cukraszda
{
    public partial class Form1 : Form
    {
        //csinálunk a form1-nek egy statikus változót
        public static string fajlnev { get; set; }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void menuKilep_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sütenényekToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuMegnyitas_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                menuSutemenyek.Enabled = true;
                fajlnev = openFileDialog1.FileName;
                label1.Text = fajlnev;

                
            }
        }

        private void menuNevjegy_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
            box.Dispose();
        
        }
    }
}
