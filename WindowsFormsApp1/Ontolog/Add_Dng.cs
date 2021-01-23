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
    public partial class Add_Dng : Form
    {
        public Add_Dng()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!(Ontolog.ont.Dangers.ContainsKey(textBox_name.Text)))
            {
                FileStream file2 = new FileStream("Dng_Info.txt", FileMode.Append);
                StreamWriter fnew2 = new StreamWriter(file2);
                fnew2.WriteLine(textBox_name.Text + ' ' +
                    textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text );
                fnew2.Close();
                Ontolog.ont.AddDngToDict();
            }
        }
    }
}
