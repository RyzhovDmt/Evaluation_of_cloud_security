using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuzzyLogicController;
using FuzzyLogicController.RuleEngine;

namespace WindowsFormsApp1
{
    public enum InOutType
    {
        In = 0, Out = 1
    }
    public partial class RuleItemUI : UserControl
    {
        private LingVariable _current;
        private RuleItem _item;

        public RuleItemUI(String var, InOutType Type)
        {
            this.Name = var;
            InitializeComponent();

            if (Type == InOutType.In) { _current = FuzzyApp.getVariablebyName(FuzzyApp.InputVariables, var); }
            else { _current = FuzzyApp.getVariablebyName(FuzzyApp.OutputVariables, var); }

            VarText.Text = _current.Name;
            this.Name = var;
            MFCombo.DataSource = _current.MFs;
            MFCombo.ValueMember = "Name";
            MFCombo.DisplayMember = "Name";
            MFCombo.SelectedValue = ((FuzzyLogicController.MFs.MemberShipFunction)MFCombo.Items[0]).Name;

            _item = new RuleItem(_current.Name, (String)MFCombo.SelectedValue);

        }

        public RuleItem RuleItem
        {
            get
            {
                _item = new RuleItem(VarText.Text, (String)MFCombo.SelectedValue);
                return _item;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
