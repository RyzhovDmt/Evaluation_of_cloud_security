using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class AddMod : Form
    {
        public static Model mdl = new Model();
        public AddMod()
        {
            InitializeComponent();
            mdl.DefaultInd();
        }

        private void Coof_button_Click(object sender, EventArgs e)
        {
            Coeff f1 = new Coeff();
            f1.ShowDialog();
        }

        private void New_button_Click(object sender, EventArgs e)
        {
            New_Comp f2 = new New_Comp();
            f2.ShowDialog();
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            File.Delete("Model_Info.txt");
            FileStream file = new FileStream("Model_Info.txt", FileMode.Create);
            StreamWriter fnew = new StreamWriter(file);
            fnew.Close();
        }

        private void Res_button_Click(object sender, EventArgs e)
        {
            AddMod_Res f3 = new AddMod_Res();
            f3.ShowDialog();
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 f5 = new AboutBox1();
            f5.ShowDialog();
        }

        private void AddMod_Load(object sender, EventArgs e)
        {
            if (!(File.Exists("Model_Info.txt")))
            {
                FileStream file = new FileStream("Model_Info.txt", FileMode.Create);
                StreamWriter fnew = new StreamWriter(file);
                fnew.Close();
            }
            mdl.AddDngToDict();
        }

        private void ЗакрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ОчиститьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear_button_Click(sender, e);
        }

        private void ОМетодеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutAddMod f8 = new AboutAddMod();
            f8.ShowDialog();
        }
    }
}
