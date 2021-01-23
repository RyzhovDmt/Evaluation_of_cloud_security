using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuzzyLogicController.RuleEngine;

namespace WindowsFormsApp1
{
    public partial class ConfigurationUI : UserControl
    {
        public ConfigurationUI()
        {
            InitializeComponent();
        }



        private void AndCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AndCombo.SelectedIndex == 0)
            {
                FuzzyApp.Configuration.Logic = ConnMethod.Min;
            }
            else
            {
                FuzzyApp.Configuration.Logic = ConnMethod.Prod;
            }
        }

        private void ImplCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ImplCombo.SelectedIndex == 0)
            {
                FuzzyApp.Configuration.Implication = ImpMethod.Min;
            }
            else
            {
                FuzzyApp.Configuration.Implication = ImpMethod.Prod;
            }
        }

        private void DefuzCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DefuzCombo.SelectedIndex == 0)
            {
                FuzzyApp.Configuration.DefuzzificationType = DefuzzifcationType.ModifiedHeight;
            }
            else
            {
                FuzzyApp.Configuration.DefuzzificationType = DefuzzifcationType.Centroid;
            }
        }
    }
}
