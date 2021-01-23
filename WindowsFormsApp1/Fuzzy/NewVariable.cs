using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuzzyLogicController;
using FuzzyLogicController.MFs;

namespace WindowsFormsApp1
{

    public partial class NewVariable : Form
    {
        private TabControl _parent;
        public NewVariable()
        {
            InitializeComponent();
        }
        public TabControl ParentTab
        {
            get { return _parent; }
            set { _parent = value; }
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            LingVariable temp;
            if (TypeCombo.SelectedItem.Equals("Input"))
            {
                temp = new LingVariable(NameTxT.Text, VarType.Input);
                List<double> rang = FuzzyApp.tokString(RangeTxT.Text);
                temp.setRange(rang[0], rang[1]);
                double value = (rang[1] - rang[0]) * 0.5;
                temp.addMF(new Trimf("mf", rang[0], (rang[0] + value), rang[1]));
                FuzzyApp.InputVariables.Add(temp);
                ParentTab.SelectedTab = ParentTab.TabPages[0];
            }
            else
            {
                temp = new LingVariable(NameTxT.Text, VarType.Output);
                List<double> rang = FuzzyApp.tokString(RangeTxT.Text);
                temp.setRange(rang[0], rang[1]);
                double value = (rang[1] - rang[0]) * 0.5;
                temp.addMF(new Trimf("mf", rang[0], (rang[0] + value), rang[1]));
                FuzzyApp.OutputVariables.Add(temp);
                ParentTab.SelectedTab = ParentTab.TabPages[1];
            }
            this.Close();
        }
    }
}
