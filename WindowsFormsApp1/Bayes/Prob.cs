using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    public class Prob
    {
        public struct res
        {
            public string name;
            public double save_conf_g1;
            public double save_integr_g1;
            public double save_avail_g1;
            public double prior_prob_g1;
            public double save_conf_g2;
            public double save_integr_g2;
            public double save_avail_g2;
            public double prior_prob_g2;
            public double save_conf_g3;
            public double save_integr_g3;
            public double save_avail_g3;
            public double prior_prob_g3;
        }

        public Dictionary<string, res> Dangers = new Dictionary<string, res>();
        private res curRes = new res();

        public void AddDngToDict()
        {

            string str;
            int space1, space2, space3, space4, space5, space6, space7, space8, space9, space10, space11, space12, space13;
            int spaceCount;
            bool admPass = false;
            int strCount = File.ReadAllLines("Info.txt").Length;

            FileStream file = new FileStream("Info.txt", FileMode.Open);
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
                if (space12 != 0)
                {
                    curRes.name = str.Substring(0, space1);
                    curRes.save_conf_g1 = Convert.ToDouble(str.Substring(space1 + 1, space2 - space1 - 1));
                    curRes.save_conf_g2 = Convert.ToDouble(str.Substring(space2 + 1, space3 - space2 - 1));
                    curRes.save_conf_g3 = Convert.ToDouble(str.Substring(space3 + 1, space4 - space3 - 1));
                    curRes.save_integr_g1 = Convert.ToDouble(str.Substring(space4 + 1, space5 - space4 - 1));
                    curRes.save_integr_g2 = Convert.ToDouble(str.Substring(space5 + 1, space6 - space5 - 1));
                    curRes.save_integr_g3 = Convert.ToDouble(str.Substring(space6 + 1, space7 - space6 - 1));
                    curRes.save_avail_g1 = Convert.ToDouble(str.Substring(space7 + 1, space8 - space7 - 1));
                    curRes.save_avail_g2 = Convert.ToDouble(str.Substring(space8 + 1, space9 - space8 - 1));
                    curRes.save_avail_g3 = Convert.ToDouble(str.Substring(space9 + 1, space10 - space9 - 1));
                    curRes.prior_prob_g1 = Convert.ToDouble(str.Substring(space10 + 1, space11 - space10 - 1));
                    curRes.prior_prob_g2 = Convert.ToDouble(str.Substring(space11 + 1, space12 - space11 - 1));
                    curRes.prior_prob_g3 = Convert.ToDouble(str.Substring(space12 + 1, str.Length - space12 - 1));
                    if (!(Dangers.ContainsKey(curRes.name)))
                        Dangers.Add(curRes.name, curRes);
                }


            }
            fnew.Close();
        }
        public List<string> getDngList()
        {
            List<string> lst = new List<string>();
            foreach (string name in Bayes.prob.Dangers.Keys)
            {
                lst.Add(name);
            }
            return lst;
        }
        public double[] get_sel_info(string name)
        {
            double[] a = new double[12];
            if (Dangers.ContainsKey(name))
            {

                a[0] = Dangers[name].save_conf_g1;
                a[1] = Dangers[name].save_conf_g2;
                a[2] = Dangers[name].save_conf_g3;
                a[3] = Dangers[name].save_integr_g1;
                a[4] = Dangers[name].save_integr_g2;
                a[5] = Dangers[name].save_integr_g3;
                a[6] = Dangers[name].save_avail_g1;
                a[7] = Dangers[name].save_avail_g2;
                a[8] = Dangers[name].save_avail_g3;
                a[9] = Dangers[name].prior_prob_g1;
                a[10] = Dangers[name].prior_prob_g2;
                a[11] = Dangers[name].prior_prob_g3;
                return a;
            }
            else return a;

        }
        public double[] calc_res(string name)
        {
            double[] a = Bayes.prob.get_sel_info(name);
            double[] res = new double[3];
            double pb = a[0] * a[3] * a[6] * a[9] +
                a[1] * a[4] * a[7] * a[10] +
                a[2] * a[5] * a[8] * a[11];
                
            res[0] = (a[9] * a[3] * a[6] * a[0]) / pb;
            res[1] = (a[1] * a[4] * a[7] * a[10]) / pb;
            res[2] = (a[2] * a[5] * a[8] * a[11]) / pb;
            return res;
        }
        public double[] calc_res(string name, bool conf_safe, bool integ_safe, bool avail_safe)
        {
            double p_y1_o1, p_y1_o2, p_y1_o3;
            double p_y2_o1, p_y2_o2, p_y2_o3;
            double p_y3_o1, p_y3_o2, p_y3_o3;

            double[] a = Bayes.prob.get_sel_info(name);
            double[] res = new double[3];
            if (conf_safe)
            {
                p_y1_o1 = Dangers[name].save_conf_g1;
                p_y1_o2 = Dangers[name].save_conf_g2;
                p_y1_o3 = Dangers[name].save_conf_g3;
            }
            else
            {
                p_y1_o1 = 1 - Dangers[name].save_conf_g1;
                p_y1_o2 = 1 - Dangers[name].save_conf_g2;
                p_y1_o3 = 1 - Dangers[name].save_conf_g3;
            }
            if (integ_safe)
            {
                p_y2_o1 = Dangers[name].save_integr_g1;
                p_y2_o2 = Dangers[name].save_integr_g2;
                p_y2_o3 = Dangers[name].save_integr_g3;
            }
            else
            {
                p_y2_o1 = 1 - Dangers[name].save_integr_g1;
                p_y2_o2 = 1 - Dangers[name].save_integr_g2;
                p_y2_o3 = 1 - Dangers[name].save_integr_g3;
            }
            if (avail_safe)
            {
                p_y3_o1 = Dangers[name].save_avail_g1;
                p_y3_o2 = Dangers[name].save_avail_g2;
                p_y3_o3 = Dangers[name].save_avail_g3;
            }
            else
            {
                p_y3_o1 = 1 - Dangers[name].save_avail_g1;
                p_y3_o2 = 1 - Dangers[name].save_avail_g2;
                p_y3_o3 = 1 - Dangers[name].save_avail_g3;
            }
            double pb = p_y1_o1 * p_y2_o1 * p_y3_o1 * Dangers[name].prior_prob_g1 +
                p_y1_o2 * p_y2_o2 * p_y3_o2 * Dangers[name].prior_prob_g2 +
                p_y1_o3 * p_y2_o3 * p_y3_o3 * Dangers[name].prior_prob_g3;

            res[0] = (p_y1_o1 * p_y2_o1 * p_y3_o1 * Dangers[name].prior_prob_g1) / pb;
            res[1] = (p_y1_o2 * p_y2_o2 * p_y3_o2 * Dangers[name].prior_prob_g2) / pb;
            res[2] = (p_y1_o3 * p_y2_o3 * p_y3_o3 * Dangers[name].prior_prob_g3) / pb;
            return res;
        }
    }
}
