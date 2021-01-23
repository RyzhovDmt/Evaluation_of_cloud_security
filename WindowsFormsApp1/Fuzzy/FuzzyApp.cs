using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogicController;
using FuzzyLogicController.FLC;
using FuzzyLogicController.RuleEngine;
using StringTok;
using FuzzyLogicController.MFs;
namespace WindowsFormsApp1
{
    public static class FuzzyApp
    {
        public static List<LingVariable> InputVariables;
        public static List<LingVariable> OutputVariables;
        public static List<Rule> Rules;
        public static FLC FuzzyControl;
        public static Config Configuration;

        public static void Initalize()
        {
            InputVariables = new List<LingVariable>();
            OutputVariables = new List<LingVariable>();
            Rules = new List<Rule>();
            Configuration = new Config(ImpMethod.Prod, ConnMethod.Min);
            Configuration.DefuzzificationType = DefuzzifcationType.ModifiedHeight;
            FuzzyControl = new FLC(Configuration);
        }

        public static void defaultSettings1()
        {
            LingVariable FSS = new LingVariable("Conf", VarType.Input);
            FSS.setRange(0, 35);
            FSS.addMF(new Trapmf("Low", -10, 0, 10, 15));
            FSS.addMF(new Trapmf("Medium", 10, 15, 25, 30));
            FSS.addMF(new Trapmf("High", 25, 30, 35, 40));

            LingVariable BSS = new LingVariable("Integ", VarType.Input);
            BSS.setRange(0, 65);
            BSS.addMF(new Trapmf("Low", -10, 0, 20, 40));
            BSS.addMF(new Trimf("Medium", 20, 40, 60));
            BSS.addMF(new Trapmf("High", 40, 60, 65, 70));

            FuzzyApp.InputVariables.Add(FSS);
            FuzzyApp.InputVariables.Add(BSS);

            //output
            LingVariable Speed = new LingVariable("Risk", VarType.Output);
            Speed.setRange(10, 70);
            Speed.addMF(new Trimf("Low", 20, 30, 40));
            Speed.addMF(new Trimf("Medium", 40, 50, 55));
            Speed.addMF(new Trimf("High", 55, 60, 70));


            FuzzyApp.OutputVariables.Add(Speed);


            //Rules
            #region Rules init
            List<RuleItem> rule1in = new List<RuleItem>();
            List<RuleItem> rule1out = new List<RuleItem>();
            List<RuleItem> rule2in = new List<RuleItem>();
            List<RuleItem> rule2out = new List<RuleItem>();
            List<RuleItem> rule3in = new List<RuleItem>();
            List<RuleItem> rule3out = new List<RuleItem>();
            List<RuleItem> rule4in = new List<RuleItem>();
            List<RuleItem> rule4out = new List<RuleItem>();
            List<RuleItem> rule5in = new List<RuleItem>();
            List<RuleItem> rule5out = new List<RuleItem>();
            List<RuleItem> rule6in = new List<RuleItem>();
            List<RuleItem> rule6out = new List<RuleItem>();
            List<RuleItem> rule7in = new List<RuleItem>();
            List<RuleItem> rule7out = new List<RuleItem>();
            List<RuleItem> rule8in = new List<RuleItem>();
            List<RuleItem> rule8out = new List<RuleItem>();
            #endregion

            //Rule 8 in out
            rule8in.AddRange(new RuleItem[2] { new RuleItem("Conf", "Low"), new RuleItem("Integ", "High") });
            rule8out.AddRange(new RuleItem[1] { new RuleItem("Risk", "High")});

            //rule 7 in out
            rule7in.AddRange(new RuleItem[2] { new RuleItem("Conf", "Low"), new RuleItem("Integ", "Medium") });
            rule7out.AddRange(new RuleItem[1] { new RuleItem("Risk", "Medium") });

            //rule 6 in out
            rule6in.AddRange(new RuleItem[2] { new RuleItem("Conf", "Low"), new RuleItem("Integ", "Low") });
            rule6out.AddRange(new RuleItem[1] { new RuleItem("Risk", "Low") });

            //rule 5 in out
            rule5in.AddRange(new RuleItem[2] { new RuleItem("Conf", "Medium"), new RuleItem("Integ", "Low") });
            rule5out.AddRange(new RuleItem[1] { new RuleItem("Risk", "Medium")});

            //Rule 4 in out
            rule4in.AddRange(new RuleItem[2] { new RuleItem("Conf", "Medium"), new RuleItem("Integ", "High") });
            rule4out.AddRange(new RuleItem[1] { new RuleItem("Risk", "Medium") });

            //rule 3 in out
            rule3in.AddRange(new RuleItem[2] { new RuleItem("Conf", "High"), new RuleItem("Integ", "Low") });
            rule3out.AddRange(new RuleItem[1] { new RuleItem("Risk", "Low") });

            //rule 2 in out
            rule2in.AddRange(new RuleItem[2] { new RuleItem("Conf", "High"), new RuleItem("Integ", "Medium") });
            rule2out.AddRange(new RuleItem[1] { new RuleItem("Risk", "Medium")});

            //rule 1 in out
            rule1in.AddRange(new RuleItem[2] { new RuleItem("Conf", "High"), new RuleItem("Integ", "High") });
            rule1out.AddRange(new RuleItem[1] { new RuleItem("Risk", "High") });

            List<Rule> rules = new List<Rule>();
            FuzzyApp.Rules.Add(new Rule(rule1in, rule1out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule2in, rule2out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule3in, rule3out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule4in, rule4out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule5in, rule5out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule6in, rule6out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule7in, rule7out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule8in, rule8out, Connector.And));

        }

        public static void defaultSettings2()
        {
            LingVariable conf = new LingVariable("Conf", VarType.Input);
            conf.setRange(1, 10);
            conf.addMF(new Trapmf("low", -1, 1, 2, 4));
            conf.addMF(new Trapmf("med", 3, 4, 6, 8));
            conf.addMF(new Trapmf("high", 7, 9, 10, 11));

            LingVariable integ = new LingVariable("Integ", VarType.Input);
            integ.setRange(1, 10);
            integ.addMF(new Trapmf("low", -1, 1, 2, 4));
            integ.addMF(new Trapmf("med", 3, 5, 6, 8));
            integ.addMF(new Trapmf("high", 7, 9, 10, 11));

            LingVariable avail = new LingVariable("Avail", VarType.Input);
            avail.setRange(1, 10);
            avail.addMF(new Trapmf("low", -1, 1, 2, 4));
            avail.addMF(new Trapmf("med", 3, 5, 6, 8));
            avail.addMF(new Trapmf("high", 7, 9, 10, 11));

            FuzzyApp.InputVariables.Add(conf);
            FuzzyApp.InputVariables.Add(integ);
            FuzzyApp.InputVariables.Add(avail);

            //output
            LingVariable risk = new LingVariable("Risk", VarType.Output);
            risk.setRange(1, 10);
            risk.addMF(new Trimf("low", -1, 1, 5));
            risk.addMF(new Trimf("med", 3, 5, 8));
            risk.addMF(new Trimf("high", 6, 10, 11));


            FuzzyApp.OutputVariables.Add(risk);


            //Rules
            #region Rules init
            List<RuleItem> rule1in = new List<RuleItem>();
            List<RuleItem> rule1out = new List<RuleItem>();
            List<RuleItem> rule2in = new List<RuleItem>();
            List<RuleItem> rule2out = new List<RuleItem>();
            List<RuleItem> rule3in = new List<RuleItem>();
            List<RuleItem> rule3out = new List<RuleItem>();
            List<RuleItem> rule4in = new List<RuleItem>();
            List<RuleItem> rule4out = new List<RuleItem>();
            List<RuleItem> rule5in = new List<RuleItem>();
            List<RuleItem> rule5out = new List<RuleItem>();
            List<RuleItem> rule6in = new List<RuleItem>();
            List<RuleItem> rule6out = new List<RuleItem>();
            List<RuleItem> rule7in = new List<RuleItem>();
            List<RuleItem> rule7out = new List<RuleItem>();
            List<RuleItem> rule8in = new List<RuleItem>();
            List<RuleItem> rule8out = new List<RuleItem>();
            List<RuleItem> rule9in = new List<RuleItem>();
            List<RuleItem> rule9out = new List<RuleItem>();
            List<RuleItem> rule10in = new List<RuleItem>();
            List<RuleItem> rule10out = new List<RuleItem>();
            List<RuleItem> rule11in = new List<RuleItem>();
            List<RuleItem> rule11out = new List<RuleItem>();
            List<RuleItem> rule12in = new List<RuleItem>();
            List<RuleItem> rule12out = new List<RuleItem>();
            List<RuleItem> rule13in = new List<RuleItem>();
            List<RuleItem> rule13out = new List<RuleItem>();
            List<RuleItem> rule14in = new List<RuleItem>();
            List<RuleItem> rule14out = new List<RuleItem>();
            List<RuleItem> rule15in = new List<RuleItem>();
            List<RuleItem> rule15out = new List<RuleItem>();
            List<RuleItem> rule16in = new List<RuleItem>();
            List<RuleItem> rule16out = new List<RuleItem>();
            List<RuleItem> rule17in = new List<RuleItem>();
            List<RuleItem> rule17out = new List<RuleItem>();
            List<RuleItem> rule18in = new List<RuleItem>();
            List<RuleItem> rule18out = new List<RuleItem>();
            List<RuleItem> rule19in = new List<RuleItem>();
            List<RuleItem> rule19out = new List<RuleItem>();
            List<RuleItem> rule20in = new List<RuleItem>();
            List<RuleItem> rule20out = new List<RuleItem>();
            List<RuleItem> rule21in = new List<RuleItem>();
            List<RuleItem> rule21out = new List<RuleItem>();
            List<RuleItem> rule22in = new List<RuleItem>();
            List<RuleItem> rule22out = new List<RuleItem>();
            List<RuleItem> rule23in = new List<RuleItem>();
            List<RuleItem> rule23out = new List<RuleItem>();
            List<RuleItem> rule24in = new List<RuleItem>();
            List<RuleItem> rule24out = new List<RuleItem>();
            List<RuleItem> rule25in = new List<RuleItem>();
            List<RuleItem> rule25out = new List<RuleItem>();
            List<RuleItem> rule26in = new List<RuleItem>();
            List<RuleItem> rule26out = new List<RuleItem>();
            List<RuleItem> rule27in = new List<RuleItem>();
            List<RuleItem> rule27out = new List<RuleItem>();
            #endregion



            //rule 1 in out
            rule1in.AddRange(new RuleItem[3] { new RuleItem("Conf", "low"), new RuleItem("Integ", "low"), new RuleItem("Avail", "low") });
            rule1out.AddRange(new RuleItem[1] { new RuleItem("Risk", "low") });
            rule2in.AddRange(new RuleItem[3] { new RuleItem("Conf", "low"), new RuleItem("Integ", "low"), new RuleItem("Avail", "med") });
            rule2out.AddRange(new RuleItem[1] { new RuleItem("Risk", "low") });
            rule3in.AddRange(new RuleItem[3] { new RuleItem("Conf", "low"), new RuleItem("Integ", "low"), new RuleItem("Avail", "high") });
            rule3out.AddRange(new RuleItem[1] { new RuleItem("Risk", "med") });

            rule4in.AddRange(new RuleItem[3] { new RuleItem("Conf", "low"), new RuleItem("Integ", "med"), new RuleItem("Avail", "low") });
            rule4out.AddRange(new RuleItem[1] { new RuleItem("Risk", "low") });
            rule5in.AddRange(new RuleItem[3] { new RuleItem("Conf", "low"), new RuleItem("Integ", "med"), new RuleItem("Avail", "med") });
            rule5out.AddRange(new RuleItem[1] { new RuleItem("Risk", "med") });
            rule6in.AddRange(new RuleItem[3] { new RuleItem("Conf", "low"), new RuleItem("Integ", "med"), new RuleItem("Avail", "high") });
            rule6out.AddRange(new RuleItem[1] { new RuleItem("Risk", "med") });

            rule7in.AddRange(new RuleItem[3] { new RuleItem("Conf", "low"), new RuleItem("Integ", "high"), new RuleItem("Avail", "low") });
            rule7out.AddRange(new RuleItem[1] { new RuleItem("Risk", "med") });
            rule8in.AddRange(new RuleItem[3] { new RuleItem("Conf", "low"), new RuleItem("Integ", "high"), new RuleItem("Avail", "med") });
            rule8out.AddRange(new RuleItem[1] { new RuleItem("Risk", "med") });
            rule9in.AddRange(new RuleItem[3] { new RuleItem("Conf", "low"), new RuleItem("Integ", "high"), new RuleItem("Avail", "high") });
            rule9out.AddRange(new RuleItem[1] { new RuleItem("Risk", "high") });

            rule10in.AddRange(new RuleItem[3] { new RuleItem("Conf", "med"), new RuleItem("Integ", "low"), new RuleItem("Avail", "low") });
            rule10out.AddRange(new RuleItem[1] { new RuleItem("Risk", "med") });
            rule11in.AddRange(new RuleItem[3] { new RuleItem("Conf", "med"), new RuleItem("Integ", "low"), new RuleItem("Avail", "med") });
            rule11out.AddRange(new RuleItem[1] { new RuleItem("Risk", "med") });
            rule12in.AddRange(new RuleItem[3] { new RuleItem("Conf", "med"), new RuleItem("Integ", "low"), new RuleItem("Avail", "high") });
            rule12out.AddRange(new RuleItem[1] { new RuleItem("Risk", "high") });

            rule13in.AddRange(new RuleItem[3] { new RuleItem("Conf", "med"), new RuleItem("Integ", "med"), new RuleItem("Avail", "low") });
            rule13out.AddRange(new RuleItem[1] { new RuleItem("Risk", "med") });
            rule14in.AddRange(new RuleItem[3] { new RuleItem("Conf", "med"), new RuleItem("Integ", "med"), new RuleItem("Avail", "med") });
            rule14out.AddRange(new RuleItem[1] { new RuleItem("Risk", "med") });
            rule15in.AddRange(new RuleItem[3] { new RuleItem("Conf", "med"), new RuleItem("Integ", "med"), new RuleItem("Avail", "high") });
            rule15out.AddRange(new RuleItem[1] { new RuleItem("Risk", "high") });

            rule16in.AddRange(new RuleItem[3] { new RuleItem("Conf", "med"), new RuleItem("Integ", "high"), new RuleItem("Avail", "low") });
            rule16out.AddRange(new RuleItem[1] { new RuleItem("Risk", "high") });
            rule17in.AddRange(new RuleItem[3] { new RuleItem("Conf", "med"), new RuleItem("Integ", "high"), new RuleItem("Avail", "med") });
            rule17out.AddRange(new RuleItem[1] { new RuleItem("Risk", "high") });
            rule18in.AddRange(new RuleItem[3] { new RuleItem("Conf", "med"), new RuleItem("Integ", "high"), new RuleItem("Avail", "high") });
            rule18out.AddRange(new RuleItem[1] { new RuleItem("Risk", "high") });

            rule19in.AddRange(new RuleItem[3] { new RuleItem("Conf", "high"), new RuleItem("Integ", "low"), new RuleItem("Avail", "low") });
            rule19out.AddRange(new RuleItem[1] { new RuleItem("Risk", "high") });
            rule20in.AddRange(new RuleItem[3] { new RuleItem("Conf", "high"), new RuleItem("Integ", "low"), new RuleItem("Avail", "med") });
            rule20out.AddRange(new RuleItem[1] { new RuleItem("Risk", "high") });
            rule21in.AddRange(new RuleItem[3] { new RuleItem("Conf", "high"), new RuleItem("Integ", "low"), new RuleItem("Avail", "high") });
            rule21out.AddRange(new RuleItem[1] { new RuleItem("Risk", "high") });

            rule22in.AddRange(new RuleItem[3] { new RuleItem("Conf", "high"), new RuleItem("Integ", "med"), new RuleItem("Avail", "low") });
            rule22out.AddRange(new RuleItem[1] { new RuleItem("Risk", "high") });
            rule23in.AddRange(new RuleItem[3] { new RuleItem("Conf", "high"), new RuleItem("Integ", "med"), new RuleItem("Avail", "med") });
            rule23out.AddRange(new RuleItem[1] { new RuleItem("Risk", "high") });
            rule24in.AddRange(new RuleItem[3] { new RuleItem("Conf", "high"), new RuleItem("Integ", "med"), new RuleItem("Avail", "high") });
            rule24out.AddRange(new RuleItem[1] { new RuleItem("Risk", "high") });

            rule25in.AddRange(new RuleItem[3] { new RuleItem("Conf", "high"), new RuleItem("Integ", "high"), new RuleItem("Avail", "low") });
            rule25out.AddRange(new RuleItem[1] { new RuleItem("Risk", "high") });
            rule26in.AddRange(new RuleItem[3] { new RuleItem("Conf", "high"), new RuleItem("Integ", "high"), new RuleItem("Avail", "med") });
            rule26out.AddRange(new RuleItem[1] { new RuleItem("Risk", "high") });
            rule27in.AddRange(new RuleItem[3] { new RuleItem("Conf", "high"), new RuleItem("Integ", "high"), new RuleItem("Avail", "high") });
            rule27out.AddRange(new RuleItem[1] { new RuleItem("Risk", "high") });




            List<Rule> rules = new List<Rule>();
            FuzzyApp.Rules.Add(new Rule(rule1in, rule1out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule2in, rule2out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule3in, rule3out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule4in, rule4out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule5in, rule5out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule6in, rule6out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule7in, rule7out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule8in, rule8out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule9in, rule9out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule10in, rule10out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule11in, rule11out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule12in, rule12out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule13in, rule13out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule14in, rule14out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule15in, rule15out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule16in, rule16out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule17in, rule17out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule18in, rule18out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule19in, rule19out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule20in, rule20out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule21in, rule21out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule22in, rule22out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule23in, rule23out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule24in, rule24out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule25in, rule25out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule26in, rule26out, Connector.And));
            FuzzyApp.Rules.Add(new Rule(rule27in, rule27out, Connector.And));
        }

        public static LingVariable getVariablebyName(List<LingVariable> variable, String name)
        {
            return variable.Find(delegate (LingVariable n) { return n.Name == name; });
        }

        public static List<double> tokString(String Text)
        {
            List<double> list = new List<double>();
            StringTokenizer tok = new StringTokenizer(Text);
            tok.NewDelim(new char[] { ',' });

            String token;
            do
            {
                token = tok.NextToken();
                list.Add(Convert.ToDouble(token));

            } while (tok.HasMoreTokens());

            return list;
        }

    }
}
