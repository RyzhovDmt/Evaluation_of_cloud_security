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

namespace WindowsFormsApp1
{
    public partial class Bayes : Form
    {
        public static Prob prob = new Prob();
        public Bayes()
        {
            InitializeComponent();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            AddVar f3 = new AddVar();
            f3.ShowDialog();
        }

        private void Bayes_Load(object sender, EventArgs e)
        {
            if (!(File.Exists("Info.txt")))
            {
                FileStream file = new FileStream("Info.txt", FileMode.Create);
                StreamWriter fnew = new StreamWriter(file);
                fnew.Close();
            }
            prob.AddDngToDict();
        }

        private void Results_button_Click(object sender, EventArgs e)
        {
            BayesResults f1 = new BayesResults();
            f1.ShowDialog();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            File.Delete("Info.txt");
            FileStream file = new FileStream("Info.txt", FileMode.Create);
            StreamWriter fnew = new StreamWriter(file);
            fnew.Close();
            prob.AddDngToDict();
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 f5 = new AboutBox1();
            f5.ShowDialog();
        }

        private void ЗакрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ОчиститьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear_button_Click(sender, e);
        }

        private void ОМетодеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBayes f8 = new AboutBayes();
            f8.ShowDialog();
        }
    }
}
