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
    public partial class Potential_dng : Form
    {
        public Potential_dng()
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

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (textBox1.Text != "")
                    textBox1.Text += ',' + listBox1.SelectedItem.ToString();
                if (textBox1.Text == "")
                    textBox1.Text = listBox1.SelectedItem.ToString();
                //добавить listBox1.SelectedItem.ToString() в список потенциальных угроз
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            Button1_Click(sender, e);
        }
    }
}
