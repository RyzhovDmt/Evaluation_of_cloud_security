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
    public partial class Ontolog : Form
    {
        public static Ont ont = new Ont();
        public Ontolog()
        {
            InitializeComponent();
        }

        private void Dng_button_Click(object sender, EventArgs e)
        {
            ont.AddDngToDict();
            Dng f1 = new Dng();
            f1.ShowDialog();
        }

        private void Component_button_Click(object sender, EventArgs e)
        {
            ont.AddCompToDict();
            Components f2 = new Components();
            f2.ShowDialog();
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 f5 = new AboutBox1();
            f5.ShowDialog();
        }

        private void ДобавитьУгрозуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Dng f1 = new Add_Dng();
            f1.ShowDialog();
        }

        private void НовыйКомпонентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Comp f1 = new Add_Comp();
            f1.ShowDialog();
        }

        private void Ontolog_Load(object sender, EventArgs e)
        {
            if (!(File.Exists("Comp_Info.txt")))
            {
                FileStream file = new FileStream("Comp_Info.txt", FileMode.Create);
                StreamWriter fnew = new StreamWriter(file);
                fnew.Close();
            }
            ont.AddCompToDict();
            if (!(File.Exists("Dng_Info.txt")))
            {
                FileStream file = new FileStream("Dng_Info.txt", FileMode.Create);
                StreamWriter fnew = new StreamWriter(file);
                fnew.Close();
            }
            ont.AddDngToDict();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ДобавитьУгрозуToolStripMenuItem_Click(sender, e);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            НовыйКомпонентToolStripMenuItem_Click(sender, e);
        }

        private void УгрозыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.Delete("Dng_Info.txt");
            FileStream file = new FileStream("Dng_Info.txt", FileMode.Create);
            StreamWriter fnew = new StreamWriter(file);
            fnew.Close();
            ont.AddDngToDict();
        }

        private void КомпонентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.Delete("Comp_Info.txt");
            FileStream file = new FileStream("Comp_Info.txt", FileMode.Create);
            StreamWriter fnew = new StreamWriter(file);
            fnew.Close();
            ont.AddCompToDict();
        }

        private void ЗакрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ОМетодеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutOnt f10 = new AboutOnt();
            f10.ShowDialog();
        }
    }
}
