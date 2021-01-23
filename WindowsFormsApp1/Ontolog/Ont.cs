using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    public class Ont
    {
        public struct comp
        {
            public string name;
            public double conf;
            public double integr;
            public double availab;
            public List<string> potent_dng;
            //строка с именами потенциальных угроз

        }
        public struct dng
        {
            public string name;
            public double type;
            public double src_protection_lvl;
            public double actuality;
            public double realiz_coeff;

        }
        public Dictionary<string, comp> Resources = new Dictionary<string, comp>();
        public Dictionary<string, dng> Dangers = new Dictionary<string, dng>();
        private comp curRes = new comp();
        private dng curDng = new dng();
        public void AddCompToDict()
        {

            string str;
            int space1, space2, space3, space4, space5, space6, space7, space8, space9, space10, space11, space12, space13;
            int spaceCount;
            bool admPass = false;
            int strCount = File.ReadAllLines("Comp_Info.txt").Length;

            FileStream file = new FileStream("Comp_Info.txt", FileMode.Open);
            StreamReader fnew = new StreamReader(file);
            for (int t = 0; t < strCount; t++)
            {
                spaceCount = 0;
                space1 = space2 = space3 = space4 = space5 = space6 = space7 = space8 = space9 = space10 = space11 = space12 = space13 = 0;

                str = fnew.ReadLine();

                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (str[i] == ' ')
                    {
                        switch (spaceCount)
                        {
                            case 0:
                                {
                                    space1 = i;
                                    spaceCount++;
                                    break;
                                }

                            case 1:
                                {
                                    space2 = i;
                                    spaceCount++;
                                    break;
                                }
                            case 2:
                                {
                                    space3 = i;
                                    spaceCount++;
                                    break;
                                }
                            case 3:
                                {
                                    space4 = i;
                                    spaceCount++;
                                    break;
                                }
                            case 4:
                                {
                                    space5 = i;
                                    spaceCount++;
                                    break;
                                }
                            case 5:
                                {
                                    space6 = i;
                                    spaceCount++;
                                    break;
                                }
                            case 6:
                                {
                                    space7 = i;
                                    spaceCount++;
                                    break;
                                }
                            case 7:
                                {
                                    space8 = i;
                                    spaceCount++;
                                    break;
                                }
                            case 8:
                                {
                                    space9 = i;
                                    spaceCount++;
                                    break;
                                }
                            case 9:
                                {
                                    space10 = i;
                                    spaceCount++;
                                    break;
                                }
                            case 10:
                                {
                                    space11 = i;
                                    spaceCount++;
                                    break;
                                }
                            case 11:
                                {
                                    space12 = i;
                                    spaceCount++;
                                    break;
                                }
                            case 12:
                                {
                                    space13 = i;
                                    spaceCount++;
                                    break;
                                }

                        }

                    }
                }

                if (space4 != 0)
                {
                    curRes.name = str.Substring(0, space1);
                    curRes.conf = Convert.ToDouble(str.Substring(space1 + 1, space2 - space1 - 1));
                    curRes.integr = Convert.ToDouble(str.Substring(space2 + 1, space3 - space2 - 1));
                    curRes.availab = Convert.ToDouble(str.Substring(space3 + 1, space4 - space3 - 1));
                    curRes.potent_dng = Ontolog.ont.parser(str.Substring(space4 + 1, str.Length - space4 - 1));
                    
                    if (!(Resources.ContainsKey(curRes.name)))
                        Resources.Add(curRes.name, curRes);
                }
            }
            fnew.Close();
        }
        public List<string> parser(string str)
        {
            List<string> lst = new List<string>();
            string[] words = str.Split(',');
            foreach (var word in words)
            {
                lst.Add(word);
            }
            return lst;
        }
        public void AddDngToDict()
        {

            string str;
            int space1, space2, space3, space4, space5, space6, space7, space8, space9, space10, space11, space12, space13;
            int spaceCount;
            bool admPass = false;
            int strCount = File.ReadAllLines("Dng_Info.txt").Length;
            FileStream file = new FileStream("Dng_Info.txt", FileMode.Open);
            StreamReader fnew = new StreamReader(file);
            for (int t = 0; t < strCount; t++)
            {
                spaceCount = 0;
                space1 = space2 = space3 = space4 = space5 = space6 = space7 = space8 = space9 = space10 = space11 = space12 = space13 = 0;

                str = fnew.ReadLine();

                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (str[i] == ' ')
                    {
                        switch (spaceCount)
                        {
                            case 0:
                                {
                                    space1 = i;
                                    spaceCount++;
                                    break;
                                }

                            case 1:
                                {
                                    space2 = i;
                                    spaceCount++;
                                    break;
                                }
                            case 2:
                                {
                                    space3 = i;
                                    spaceCount++;
                                    break;
                                }
                            case 3:
                                {
                                    space4 = i;
                                    spaceCount++;
                                    break;
                                }
                            case 4:
                                {
                                    space5 = i;
                                    spaceCount++;
                                    break;
                                }
                            case 5:
                                {
                                    space6 = i;
                                    spaceCount++;
                                    break;
                                }
                            case 6:
                                {
                                    space7 = i;
                                    spaceCount++;
                                    break;
                                }
                            case 7:
                                {
                                    space8 = i;
                                    spaceCount++;
                                    break;
                                }
                            case 8:
                                {
                                    space9 = i;
                                    spaceCount++;
                                    break;
                                }
                            case 9:
                                {
                                    space10 = i;
                                    spaceCount++;
                                    break;
                                }
                            case 10:
                                {
                                    space11 = i;
                                    spaceCount++;
                                    break;
                                }
                            case 11:
                                {
                                    space12 = i;
                                    spaceCount++;
                                    break;
                                }
                            case 12:
                                {
                                    space13 = i;
                                    spaceCount++;
                                    break;
                                }

                        }

                    }
                }

                if (space3 != 0)
                {
                    curDng.name = str.Substring(0, space1);
                    curDng.type = Convert.ToDouble(str.Substring(space1 + 1, space2 - space1 - 1));
                    curDng.src_protection_lvl = Convert.ToDouble(str.Substring(space2 + 1, space3 - space2 - 1));
                    curDng.actuality = Convert.ToDouble(str.Substring(space3 + 1, str.Length - space3 - 1));
                    curDng.realiz_coeff = (curDng.src_protection_lvl + curDng.actuality)/20;
                    if (!(Dangers.ContainsKey(curDng.name)))
                        Dangers.Add(curDng.name, curDng);
                }
            }
            fnew.Close();
        }
        public List<string> getDngList()
        {
            List<string> lst = new List<string>();
            foreach (string name in Ontolog.ont.Dangers.Keys)
            {
                lst.Add(name);
            }
            return lst;
        }
        public List<string> getCompList()
        {
            List<string> lst = new List<string>();
            foreach (string name in Ontolog.ont.Resources.Keys)
            {
                lst.Add(name);
            }
            return lst;
        }
        public double[] get_comp_sel_info(string name)
        {
            double[] a = new double[3];
            if (Resources.ContainsKey(name))
            {
                a[0] = Resources[name].conf;
                a[1] = Resources[name].integr;
                a[2] = Resources[name].availab;

                return a;
            }
            else return a;

        }
        public string get_comp_potential_dng(string name)
        {
            List<string> lst = new List<string>();
            string str = "";
            if (Resources.ContainsKey(name))
            {
                lst = Resources[name].potent_dng;
                foreach (string a in lst)
                {
                    str += a + ',';
                }
                return str.Trim(new Char[] { ',' });
            }
            else return str;

        }
        public double[] get_dng_sel_info(string name)
        {
            double[] a = new double[4];
            if (Dangers.ContainsKey(name))
            {
                a[0] = Dangers[name].type;
                a[1] = Dangers[name].src_protection_lvl;
                a[2] = Dangers[name].actuality;
                a[3] = Dangers[name].realiz_coeff;

                return a;
            }
            else return a;

        }
        
        public double calc_res(string name)
        {
            List<string> lst = new List<string>();
            double dng_realiz = 0, res = 0;
            double[] a = get_comp_sel_info(name);
            if (Resources.ContainsKey(name))
            {
                lst = Resources[name].potent_dng;
                foreach (string str in lst)
                {
                    if (Dangers.ContainsKey(str))
                        dng_realiz += Dangers[str].realiz_coeff * Dangers[str].type;
                }
                res = Resources[name].conf + Resources[name].integr + Resources[name].availab + dng_realiz;
            }
            return res;
        }
        
    }
}
