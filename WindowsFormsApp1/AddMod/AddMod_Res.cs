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
    public partial class AddMod_Res : Form
    {
        public AddMod_Res()
        {
            InitializeComponent();
            refresh_listBox();
        }
        private void refresh_listBox()
        {
            foreach (string name in AddMod.mdl.getDngList())
            {
                listBox1.Items.Add(name);
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                double[] inf = AddMod.mdl.get_sel_info(listBox1.SelectedItem.ToString());
                double a = AddMod.mdl.calc_res(listBox1.SelectedItem.ToString());
                textBox1.Text = Convert.ToString(inf[0]);
                textBox2.Text = Convert.ToString(inf[1]);
                textBox3.Text = Convert.ToString(inf[2]);
                textBox4.Text = Convert.ToString(inf[3]);
                textBox5.Text = Convert.ToString(inf[4]);
                textBox6.Text = Convert.ToString(inf[5]);
                textBox7.Text = Convert.ToString(a);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ЗакрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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
                        sw.WriteLine("Компанент: " + listBox1.SelectedItem.ToString());
                        sw.WriteLine("Показатель сохранности данных: " + textBox1.Text);
                        sw.WriteLine("Показатель защиты данных при передаче: " + textBox2.Text);
                        sw.WriteLine("Показатель аутентификации: " + textBox3.Text);
                        sw.WriteLine("Показатель изоляции пользователей: " + textBox4.Text);
                        sw.WriteLine("Показатель реакции на происшествия: " + textBox5.Text);
                        sw.WriteLine("Коэффициент использования нормативно-правовых вопросов: " + textBox6.Text);
                        sw.WriteLine("Результаты");
                        sw.WriteLine("Риск: " + textBox7.Text);
                    }
                    myStream.Close();
                }
            }
        }
    }
}
