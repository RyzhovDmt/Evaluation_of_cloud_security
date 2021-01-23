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
    public partial class Dng : Form
    {
        public Dng()
        {
            InitializeComponent();
            refresh_listBox();
        }
        private void refresh_listBox()
        {
            foreach (string name in Ontolog.ont.getDngList())
            {
                listBox1.Items.Add(name);
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                double[] inf = Ontolog.ont.get_dng_sel_info(listBox1.SelectedItem.ToString());
                double a = AddMod.mdl.calc_res(listBox1.SelectedItem.ToString());
                //textBox_risk.Text = Convert.ToString(a); //взять минимальный компонент
                textBox1.Text = Convert.ToString(inf[0]);
                textBox2.Text = Convert.ToString(inf[1]);
                textBox3.Text = Convert.ToString(inf[2]);
                textBox4.Text = Convert.ToString(inf[3]);
                //textBox5.Text = Convert.ToString(a);
            }
        }
    }
}
