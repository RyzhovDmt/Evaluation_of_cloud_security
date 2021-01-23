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
    public partial class Add_Comp : Form
    {
        public Add_Comp()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!(Ontolog.ont.Dangers.ContainsKey(textBox_name.Text)))
            {
                FileStream file2 = new FileStream("Comp_Info.txt", FileMode.Append);
                StreamWriter fnew2 = new StreamWriter(file2);
                fnew2.WriteLine(textBox_name.Text + ' ' +
                     textBox2.Text + ' ' + textBox3.Text + ' ' + textBox4.Text + ' ' + textBox5.Text);
                fnew2.Close();
                Ontolog.ont.AddDngToDict();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Potential_dng f = new Potential_dng();
            f.ShowDialog();
            this.textBox5.Text = f.textBox1.Text;

        }
    }
}
