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
    public partial class RuleUI : UserControl
    {
        public RuleUI()
        {
            InitializeComponent();
        }
        public void loadVariables()
        {
            VarTree.Nodes.Clear();
            int InputCount = FuzzyApp.InputVariables.Count;
            TreeNode[] INnodes = new TreeNode[InputCount];
            for (int i = 0; i < InputCount; i++)
            {
                INnodes[i] = new TreeNode(FuzzyApp.InputVariables[i].Name);
            }
            TreeNode root = new TreeNode("Inputs", INnodes);
            VarTree.Nodes.Add(root);

            int OutputCount = FuzzyApp.OutputVariables.Count;
            TreeNode[] Outnodes = new TreeNode[OutputCount];
            for (int i = 0; i < OutputCount; i++)
            {
                Outnodes[i] = new TreeNode(FuzzyApp.OutputVariables[i].Name);
            }
            TreeNode root2 = new TreeNode("Outputs", Outnodes);
            VarTree.Nodes.Add(root2);

        }

        public void loadRules()
        {

            List<FuzzyLogicController.RuleEngine.Rule> rules = FuzzyApp.Rules;

            RulePan.Controls.Clear();
            RulePan.RowCount = rules.Count;

            for (int i = 0; i < rules.Count; i++)
            {
                String rule = "IF ";
                for (int j = 0; j < rules[i].InputRules.Count; j++)
                {
                    rule = rule + rules[i].InputRules[j].Variable + " is " + rules[i].InputRules[j].MemberShipValue;
                    if (j != rules[i].InputRules.Count - 1)
                    {
                        rule = rule + " And ";
                    }
                }
                rule = rule + " Then ";
                for (int j = 0; j < rules[i].OutputRules.Count; j++)
                {
                    rule = rule + rules[i].OutputRules[j].Variable + " is " + rules[i].OutputRules[j].MemberShipValue;
                    if (j != rules[i].OutputRules.Count - 1)
                    {
                        rule = rule + " And ";
                    }
                }

                Label Temp = new Label();
                Temp.Text = rule;
                Temp.Name = FuzzyApp.Rules.IndexOf(rules[i]).ToString();
                Temp.Click += new EventHandler(ClickRule);
                Temp.Font = new Font("san serif", 10, FontStyle.Bold);
                Temp.Dock = DockStyle.Fill;
                RulePan.Controls.Add(Temp, 0, i);
            }
        }

        private void ClickRule(object sender, EventArgs e)
        {
            Label owner = (Label)sender;
            owner.Dispose();
            FuzzyApp.Rules.RemoveAt(Convert.ToInt32(owner.Name));
            loadRules();
        }

        private bool checkNodeNotRoot(TreeNode node)
        {
            return !(node.Text == "Inputs" || node.Text == "Outputs");
        }

        private void VarTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (checkNodeNotRoot(e.Node))
            {
                if (e.Node.Parent.Text.Equals("Inputs"))
                {
                    RuleItemUI item = new RuleItemUI(e.Node.Text, InOutType.In);
                    if (InRulePan.Controls.Find(item.Name, false).Length == 0)
                    {
                        InRulePan.Controls.Add(item);
                    }
                }
                else
                {
                    RuleItemUI item = new RuleItemUI(e.Node.Text, InOutType.Out);
                    if (OutRulePan.Controls.Find(item.Name, false).Length == 0)
                    {
                        OutRulePan.Controls.Add(item);
                    }
                }
            }
            else
            {
                for (int i = 0; i < e.Node.Nodes.Count; i++)
                {
                    if (e.Node.Text.Equals("Inputs"))
                    {
                        RuleItemUI item = new RuleItemUI(e.Node.Nodes[i].Text, InOutType.In);
                        InRulePan.Controls.Add(item);
                    }
                    else
                    {
                        RuleItemUI item = new RuleItemUI(e.Node.Nodes[i].Text, InOutType.Out);
                        OutRulePan.Controls.Add(item);
                    }
                }
            }
        }

        private void AddRuleBtn_Click(object sender, EventArgs e)
        {
            List<RuleItem> inrules = new List<RuleItem>();
            for (int i = 0; i < InRulePan.Controls.Count; i++)
            {
                inrules.Add(((RuleItemUI)InRulePan.Controls[i]).RuleItem);
            }

            List<RuleItem> outrules = new List<RuleItem>();
            for (int i = 0; i < OutRulePan.Controls.Count; i++)
            {
                outrules.Add(((RuleItemUI)OutRulePan.Controls[i]).RuleItem);
            }

            FuzzyApp.Rules.Add(new FuzzyLogicController.RuleEngine.Rule(inrules, outrules, FuzzyLogicController.RuleEngine.Connector.And));
            loadRules();
            InRulePan.Controls.Clear();
            OutRulePan.Controls.Clear();
        }

        private void ClearRuleBtn_Click(object sender, EventArgs e)
        {
            InRulePan.Controls.Clear();
            OutRulePan.Controls.Clear();
        }
    }
}
