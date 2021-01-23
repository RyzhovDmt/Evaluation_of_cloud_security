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
    public partial class New_Comp : Form
    {
        public New_Comp()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!(AddMod.mdl.Resources.ContainsKey(textBox_name.Text)))
            {
                FileStream file2 = new FileStream("Model_Info.txt", FileMode.Append);
                StreamWriter fnew2 = new StreamWriter(file2);
                fnew2.WriteLine(textBox_name.Text + ' ' +
                    textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text + ' ' + textBox4.Text + ' ' + textBox5.Text + ' ' + textBox6.Text);
                fnew2.Close();
                AddMod.mdl.AddDngToDict();
            }
        }
    }
}
