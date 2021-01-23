using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class BayesResults : Form
    {
        bool is_conf_save, is_integ_save, is_avail_save;

        public BayesResults()
        {
            InitializeComponent();
            refresh_listBox();
        }
        private void refresh_listBox()
        {
            foreach (string name in Bayes.prob.getDngList())
            {
                listBox1.Items.Add(name);
            }
        }

        private void ListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedItem != null)
            {
                double[] a = Bayes.prob.calc_res(listBox1.SelectedItem.ToString(), checkBox1.Checked, checkBox2.Checked, checkBox3.Checked);
                textBox1.Text = Convert.ToString(a[0]);
                textBox2.Text = Convert.ToString(a[1]);
                textBox3.Text = Convert.ToString(a[2]);

            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            double[] a = Bayes.prob.calc_res(listBox1.SelectedItem.ToString(), checkBox1.Checked, checkBox2.Checked, checkBox3.Checked);
            textBox1.Text = Convert.ToString(a[0]);
            textBox2.Text = Convert.ToString(a[1]);
            textBox3.Text = Convert.ToString(a[2]);
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            double[] a = Bayes.prob.calc_res(listBox1.SelectedItem.ToString(), checkBox1.Checked, checkBox2.Checked, checkBox3.Checked);
            textBox1.Text = Convert.ToString(a[0]);
            textBox2.Text = Convert.ToString(a[1]);
            textBox3.Text = Convert.ToString(a[2]);
        }

        private void СохранитьРезультатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";
            saveFileDialog1.RestoreDirectory = true;
            double[] a = Bayes.prob.get_sel_info(listBox1.SelectedItem.ToString());
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {

                    using (StreamWriter sw = new StreamWriter(myStream))
                    {
                        sw.WriteLine("Входные данные");
                        if (checkBox1.Checked)
                            sw.WriteLine("Конфиденциальность сохранена");
                        else sw.WriteLine("Конфиденциальность нарушена");
                        if (checkBox2.Checked)
                            sw.WriteLine("Целостность сохранена");
                        else sw.WriteLine("Целостность нарушена");
                        if (checkBox3.Checked)
                            sw.WriteLine("Доступность сохранена");
                        else sw.WriteLine("Доступность нарушена");
                        sw.WriteLine("Вероятность сохранения конфиденциальности для группы 1,2,3: " + a[0] + " " + a[1] + " " + a[2]);
                        sw.WriteLine("Вероятность сохранения целостности для группы 1,2,3: " + a[3] + " " + a[4] + " " + a[5]);
                        sw.WriteLine("Вероятность сохранения доступности для группы 1,2,3: " + a[6] + " " + a[7] + " " + a[8]);
                        sw.WriteLine("Априорная вероятность принадлежности к группе 1,2,3: " + a[9] + " " + a[10] + " " + a[11]);
                        sw.WriteLine("Результаты");
                        sw.WriteLine("Вероятность принадлежности к группе 1,2,3: " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
                    }
                    myStream.Close();
                }
            }
        }

        private void ЗакрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            double[] a = Bayes.prob.calc_res(listBox1.SelectedItem.ToString(), checkBox1.Checked, checkBox2.Checked, checkBox3.Checked);
            textBox1.Text = Convert.ToString(a[0]);
            textBox2.Text = Convert.ToString(a[1]);
            textBox3.Text = Convert.ToString(a[2]);
        }
    }
}
