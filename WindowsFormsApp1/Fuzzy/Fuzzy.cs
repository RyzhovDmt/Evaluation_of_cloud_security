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
    public partial class Fuzzy : Form
    {
        public Fuzzy()
        {
            InitializeComponent();
        }

        private void Fuzzy_Load(object sender, EventArgs e)
        {
            if (FuzzyApp.InputVariables.Count > 0)
            {
                variable1.Current = FuzzyApp.InputVariables[0];
                variable1.Populate();
                populateVariables();
            }
            reloadStrip();
            //configurationUI1.loadData();
        }
        private void reloadStrip()
        {
            toolStripStatusLabel1.Text = "Inputs : " + FuzzyApp.InputVariables.Count.ToString();
            toolStripStatusLabel2.Text = "Outputs : " + FuzzyApp.OutputVariables.Count.ToString();
            toolStripStatusLabel3.Text = "Rules : " + FuzzyApp.Rules.Count.ToString();
        }

        private void populateVariables()
        {
            for (int i = 0; i < FuzzyApp.InputVariables.Count; i++)
            {
                if (InputView.Items.ContainsKey(FuzzyApp.InputVariables[i].Name) == false)
                {
                    InputView.Items.Add(FuzzyApp.InputVariables[i].Name, FuzzyApp.InputVariables[i].Name, 1);
                }
            }

            for (int i = 0; i < FuzzyApp.OutputVariables.Count; i++)
            {
                if (OutputView.Items.ContainsKey(FuzzyApp.OutputVariables[i].Name) == false)
                {
                    OutputView.Items.Add(FuzzyApp.OutputVariables[i].Name, FuzzyApp.OutputVariables[i].Name, 1);
                }
            }
        }

        private void AddVariable_Click(object sender, EventArgs e)
        {
            NewVariable var = new NewVariable();
            var.ParentTab = InOutTabs;
            var.ShowDialog();
            populateVariables();
        }

        private void InputView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InputView.SelectedIndices.Count > 0)
            {
                int index = InputView.SelectedIndices[0];
                variable1.ClearVariable();
                variable1.Current = FuzzyApp.InputVariables[index];
                variable1.Populate();
            }
        }

        private void OutputView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OutputView.SelectedIndices.Count > 0)
            {
                int index = OutputView.SelectedIndices[0];
                variable1.ClearVariable();
                variable1.Current = FuzzyApp.OutputVariables[index];
                variable1.Populate();
            }
        }

        private void MainPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainPanel.SelectedTab.Text.Equals("Правила"))
            {
                rule1.loadVariables();
                rule1.loadRules();
            }
            else if (MainPanel.SelectedTab.Text.Equals("Результаты"))
            {
                reultsUI1.loadVariables();
            }

            reloadStrip();
        }

        private void Test1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuzzyApp.Initalize();
            variable1.ClearVariable();
            InputView.Clear();
            OutputView.Clear();
            FuzzyApp.defaultSettings1();
            if (FuzzyApp.InputVariables.Count > 0)
            {
                variable1.Current = FuzzyApp.InputVariables[0];
                variable1.Populate();
                populateVariables();
            }
        }

        private void Test2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuzzyApp.Initalize();
            variable1.ClearVariable();
            InputView.Clear();
            OutputView.Clear();
            FuzzyApp.defaultSettings2();
            if (FuzzyApp.InputVariables.Count > 0)
            {
                variable1.Current = FuzzyApp.InputVariables[0];
                variable1.Populate();
                populateVariables();
            }
        }

        private void CloseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuzzyApp.Initalize();
            variable1.ClearVariable();
            InputView.Clear();
            OutputView.Clear();
            reultsUI1.loadVariables();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (InOutTabs.SelectedTab.Text == "Input")
            {
                FuzzyApp.InputVariables.RemoveAt(InputView.SelectedIndices[0]);
                InputView.Items.RemoveAt(InputView.SelectedIndices[0]);
            }
            else
            {
                FuzzyApp.OutputVariables.RemoveAt(InputView.SelectedIndices[0]);
                OutputView.Items.RemoveAt(InputView.SelectedIndices[0]);
            }
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 f3 = new AboutBox1();
            f3.ShowDialog();
        }

        private void Конфигурация1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ПеременныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutTests1Par f5 = new AboutTests1Par();
            f5.ShowDialog();
        }

        private void ПравилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutTests1Rules f6 = new AboutTests1Rules();
            f6.ShowDialog();
        }

        private void ОМетодеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutFuzzy f7 = new AboutFuzzy();
            f7.ShowDialog();
        }
    }
}
