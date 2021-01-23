using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public class Model
    {
        public struct comp
        {
            public string name;
            public double safety;
            public double trans_protection;
            public double auth_index;
            public double users_isol_index;
            public double incident_resp;
            public double regulatory_coeff;
        }
        public struct gen_ind
        {
            public double safety;
            public double trans_protection;
            public double auth_index;
            public double users_isol_index;
            public double incident_resp;
            public double regulatory_coeff;
        }

        public Dictionary<string, comp> Resources = new Dictionary<string, comp>();
        private comp curRes = new comp();
        public gen_ind genInd = new gen_ind();
        public void DefaultInd()
        {
            genInd.safety = 0.03;
            genInd.trans_protection = 0.04;
            genInd.auth_index = 0.04;
            genInd.users_isol_index = 0.03;
            genInd.incident_resp = 0.04;
            genInd.regulatory_coeff = 0.02;

        }
        public void CustomInd(string ind1, string ind2, string ind3, string ind4, string ind5, string ind6)
        {
            genInd.safety = Convert.ToDouble(ind1);
            genInd.trans_protection = Convert.ToDouble(ind2);
            genInd.auth_index = Convert.ToDouble(ind3);
            genInd.users_isol_index = Convert.ToDouble(ind4);
            genInd.incident_resp = Convert.ToDouble(ind5);
            genInd.regulatory_coeff = Convert.ToDouble(ind6);

        }
        public void AddDngToDict()
        {

            string str;
            int space1, space2, space3, space4, space5, space6, space7, space8, space9, space10, space11, space12, space13;
            int spaceCount;
            bool admPass = false;
            int strCount = File.ReadAllLines("Model_Info.txt").Length;

            FileStream file = new FileStream("Model_Info.txt", FileMode.Open);
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

                if (space6 != 0)
                {
                    curRes.name = str.Substring(0, space1);
                    curRes.safety = Convert.ToDouble(str.Substring(space1 + 1, space2 - space1 - 1));
                    curRes.trans_protection = Convert.ToDouble(str.Substring(space2 + 1, space3 - space2 - 1));
                    curRes.auth_index = Convert.ToDouble(str.Substring(space3 + 1, space4 - space3 - 1));
                    curRes.users_isol_index = Convert.ToDouble(str.Substring(space4 + 1, space5 - space4 - 1));
                    curRes.incident_resp = Convert.ToDouble(str.Substring(space5 + 1, space6 - space5 - 1));
                    curRes.regulatory_coeff = Convert.ToDouble(str.Substring(space6 + 1, str.Length - space6 - 1));
                    if (!(Resources.ContainsKey(curRes.name)))
                        Resources.Add(curRes.name, curRes);
                }


            }
            fnew.Close();
        }
        public List<string> getDngList()
        {
            List<string> lst = new List<string>();
            foreach (string name in AddMod.mdl.Resources.Keys)
            {
                lst.Add(name);
            }
            return lst;
        }
        public double[] get_sel_info(string name)
        {
            double[] a = new double[6];
            if (Resources.ContainsKey(name))
            {

                a[0] = Resources[name].safety;
                a[1] = Resources[name].trans_protection;
                a[2] = Resources[name].auth_index;
                a[3] = Resources[name].users_isol_index;
                a[4] = Resources[name].incident_resp;
                a[5] = Resources[name].regulatory_coeff;

                return a;
            }
            else return a;

        }
        public double calc_res(string name)
        {
            double[] a = AddMod.mdl.get_sel_info(name);
            double res = a[0]*genInd.safety + a[1]*genInd.trans_protection + a[2]* genInd.auth_index + a[3]* genInd.users_isol_index + a[4]* genInd.incident_resp + a[5]* genInd.regulatory_coeff;
            
            return res;
        }
    }
}
