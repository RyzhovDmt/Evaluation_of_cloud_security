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
    public partial class Components : Form
    {
        public Components()
        {
            InitializeComponent();
            refresh_listBox();
        }
        private void refresh_listBox()
        {
            foreach (string name in Ontolog.ont.getCompList())
            {
                listBox1.Items.Add(name);
            }
        }
        private void refresh_risk()
        {
            double risk = 0;
            for (int i=0; i < listBox2.Items.Count;i++)
            {

                risk += Convert.ToDouble(Ontolog.ont.calc_res(listBox2.Items[i].ToString()));
            }
            textBox_sum_risk.Text = Convert.ToString(risk);
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                double[] inf = Ontolog.ont.get_comp_sel_info(listBox1.SelectedItem.ToString());
                //double a = Ontolog.ont.calc_res(listBox1.SelectedItem.ToString());
                //textBox_risk.Text = Convert.ToString(a); //взять минимальный компонент
                
                textBox2.Text = Convert.ToString(inf[0]);
                textBox3.Text = Convert.ToString(inf[1]);
                textBox4.Text = Convert.ToString(inf[2]);
                textBox5.Text = Convert.ToString(Ontolog.ont.calc_res(listBox1.SelectedItem.ToString()));
                textBox6.Text = Ontolog.ont.get_comp_potential_dng(listBox1.SelectedItem.ToString());
                //textBox5.Text = Convert.ToString(a);
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem.ToString());
                refresh_risk();
            }

            }

        private void Delbutton_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox2.Items.Remove(listBox2.SelectedItem.ToString());
                refresh_risk();
            }
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
                        sw.WriteLine("Выбраные компоненты");
                        sw.WriteLine("========================================");
                        for (int i = 0; i < listBox2.Items.Count; i++)
                        {
                            double[] inf = Ontolog.ont.get_comp_sel_info(listBox2.Items[i].ToString());
                            
                            sw.WriteLine("Название:" + listBox2.Items[i].ToString());
                            sw.WriteLine("Показатель конфиденциальности: " + inf[0]);
                            sw.WriteLine("Показатель целостности: " + inf[1]);
                            sw.WriteLine("Показатель доступности: " + inf[2]);
                            sw.WriteLine("Потенциальные угрозы: " + Ontolog.ont.get_comp_potential_dng(listBox2.Items[i].ToString()));
                            sw.WriteLine("Показатель доступности: " + Ontolog.ont.calc_res(listBox2.Items[i].ToString()));
                            
                            sw.WriteLine("========================================") ;
                        }
                        sw.WriteLine("Риск для набора: " + textBox_sum_risk.Text);
                    }
                    myStream.Close();
                }
            }

        }
    }
}
