using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Fuzzy f2 = new Fuzzy();
            f2.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Bayes f1 = new Bayes();
            f1.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Ontolog f3 = new Ontolog();
            f3.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AddMod f4 = new AddMod();
            f4.ShowDialog();
        }

        private void НечеткаяЛогикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button1_Click(sender, e);
        }

        private void БайесовскийПодходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button2_Click(sender, e);
        }

        private void АддитивнаяМодельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button3_Click(sender, e);
        }

        private void ОнтологическаяМодельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button4_Click(sender, e);
        }

        private void СправкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 f5 = new AboutBox1();
            f5.ShowDialog(); 
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void НечеткаяЛогикаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutFuzzy f7 = new AboutFuzzy();
            f7.ShowDialog();
        }

        private void БайесовскийПодходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBayes f8 = new AboutBayes();
            f8.ShowDialog();   
        }

        private void АддитивнаяМодельToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutAddMod f9 = new AboutAddMod();
            f9.ShowDialog();
        }

        private void ОнтологическаяМодельToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutOnt f10 = new AboutOnt();
            f10.ShowDialog();

        }

        private void ОбИнформационныхРискахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutRisks f11 = new AboutRisks();
            f11.ShowDialog();
        }
    }
}
