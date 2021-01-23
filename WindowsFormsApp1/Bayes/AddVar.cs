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
    public partial class AddVar : Form
    {
        public AddVar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(Bayes.prob.Dangers.ContainsKey(textBox_name.Text)))
            {
                FileStream file2 = new FileStream("Info.txt", FileMode.Append);
                StreamWriter fnew2 = new StreamWriter(file2);
                fnew2.WriteLine(textBox_name.Text + ' ' +
                    textBox_save_conf_g1.Text + ' ' + textBox_save_conf_g2.Text + ' ' + textBox_save_conf_g3.Text + ' ' +
                    textBox_save_integr_g1.Text + ' ' + textBox_save_integr_g2.Text + ' ' + textBox_save_integr_g3.Text + ' ' +
                    textBox_save_avail_g1.Text + ' ' + textBox_save_avail_g2.Text + ' ' + textBox_save_avail_g3.Text + ' ' +
                    textBox_prior_prob_g1.Text + ' ' + textBox_prior_prob_g2.Text + ' ' + textBox_prior_prob_g3.Text);
                fnew2.Close();
                Bayes.prob.AddDngToDict();
                //Bayes.prob.saveToFile();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
