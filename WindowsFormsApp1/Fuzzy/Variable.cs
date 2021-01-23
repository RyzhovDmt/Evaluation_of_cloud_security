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

namespace WindowsFormsApp1
{
    public partial class Variable : UserControl
    {
        private LingVariable _current;
        public Variable()
        {
            InitializeComponent();
        }
        public LingVariable Current
        {
            get { return _current; }
            set
            {
                _current = value;
                this.ChartPanel.Paint += new PaintEventHandler(drawSelectedMF);
                this.ChartPanel.Refresh();
            }
        }

        private void drawSelectedMF(object sender, PaintEventArgs e)
        {
            if (Current != null)
            {
                for (int i = 0; i < Current.MFs.Count; i++)
                {
                    if (MFView.SelectedIndices.Count > 0 && i == MFView.SelectedIndices[0])
                    {
                        DrawChart(e.Graphics, Current.MFs[i], Current.Range, true);
                    }
                    else
                    {
                        DrawChart(e.Graphics, Current.MFs[i], Current.Range, false);
                    }
                }
                base.OnPaint(e);
            }
        }

        private void popualteMF(FuzzyLogicController.MFs.MemberShipFunction mf)
        {
            MFNameTxT.Text = mf.Name;
            MFParamTxT.Text = mf.Params[0].ToString();
            for (int i = 1; i < mf.Params.Count; i++)
            {
                MFParamTxT.Text = MFParamTxT.Text + ", " + mf.Params[i];
            }
            if (mf is FuzzyLogicController.MFs.Trimf)
            {
                MFTypeCombo.SelectedIndex = 0;
            }
            else if (mf is FuzzyLogicController.MFs.Trapmf)
            {
                MFTypeCombo.SelectedIndex = 1;
            }
        }

        public void Populate()
        {
            VarTxT.Text = Current.Name;
            RangeTxT.Text = Current.Range[0] + ", " + Current.Range[1];

            if (Current.Type == VarType.Input) { TypeCombo.SelectedIndex = 0; }
            else { TypeCombo.SelectedIndex = 1; }

            if (Current.MFs.Count > 0)
            {
                for (int i = 0; i < Current.MFs.Count; i++)
                {
                    if (!MFView.Items.ContainsKey(Current.MFs[i].Name))
                    {
                        MFView.Items.Add(Current.MFs[i].Name, Current.MFs[i].Name, 1);
                    }
                }

            }
        }

        private void DrawChart(Graphics g, FuzzyLogicController.MFs.MemberShipFunction mf, List<double> Range, bool isSelected)
        {
            List<double> pts = mf.Params;

            Graphics gfx = g;
            #region Graphs
            Point[] points = new Point[pts.Count];
            for (int i = 0; i < pts.Count; i++)
            {
                double value = (pts[i] - Range[0]) / (Range[1] - Range[0]);
                int pos = Convert.ToInt32(value * (ChartPanel.Bounds.Width));
                if (i == 0 || i == pts.Count - 1)
                {
                    points[i] = new Point(pos, ChartPanel.Bounds.Height - 20);
                }
                else
                {
                    points[i] = new Point(pos, 40);
                }
            }
            if (!isSelected)
            {
                gfx.DrawLines(new Pen(Color.Red), points);
            }
            else
            {
                gfx.DrawLines(new Pen(new SolidBrush(Color.Blue), 3), points);
            }


            int diff = Convert.ToInt32((points[pts.Count - 1].X - points[0].X) / 2);
            int strvalue = points[0].X + diff;

            if (!isSelected)
            {
                Font font = new Font("SanSerif", 10, FontStyle.Italic);
                gfx.DrawString(mf.Name, font, new SolidBrush(Color.Red), new PointF(strvalue - 25, 20));
            }
            else
            {
                Font font = new Font("SanSerif", 12, FontStyle.Italic);
                gfx.DrawString(mf.Name, font, new SolidBrush(Color.Blue), new PointF(strvalue - 25, 20));
            }
            #endregion
            #region Axis
            gfx.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, ChartPanel.Height - 19), new Point(ChartPanel.Width, ChartPanel.Height - 19));
            double Step = (Range[1] - Range[0]) / (10 - 1);
            double Steps = Range[0];
            for (int i = 0; i < 10; i++)
            {
                Steps = Steps + Step;
                double value = (Steps - Range[0]) / (Range[1] - Range[0]);
                int pos = Convert.ToInt32(value * (ChartPanel.Bounds.Width));
                PointF point = new PointF(pos, ChartPanel.Bounds.Height - 15);
                gfx.DrawString(Convert.ToInt32(Steps).ToString(), new Font(FontFamily.GenericSansSerif, 10), new SolidBrush(Color.Black), point);
            }
            #endregion
        }

        private void MFView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MFView.SelectedIndices.Count > 0)
            {
                MFParamTxT.Text = "";
                popualteMF(Current.MFs[MFView.SelectedIndices[0]]);
                this.ChartPanel.Paint += new PaintEventHandler(drawSelectedMF);
                this.ChartPanel.Refresh();
            }
        }
        public void ClearVariable()
        {
            MFView.Clear();
            VarTxT.Text = "";
            RangeTxT.Text = "";
            MFNameTxT.Text = "";
            MFParamTxT.Text = "";
            Current = null;
        }

        private void MfBtn_Click(object sender, EventArgs e)
        {
            if (!MFView.Items.ContainsKey(MFNameTxT.Text))
            {
                List<double> pts = FuzzyApp.tokString(MFParamTxT.Text);
                FuzzyLogicController.MFs.MemberShipFunction mftemp;
                if (MFTypeCombo.SelectedIndex == 0)
                {
                    mftemp = new FuzzyLogicController.MFs.Trimf(MFNameTxT.Text, pts[0], pts[1], pts[2]);
                    Current.MFs.Add(mftemp);
                    popualteMF(mftemp);
                }
                else if (MFTypeCombo.SelectedIndex == 1)
                {
                    mftemp = new FuzzyLogicController.MFs.Trapmf(MFNameTxT.Text, pts[0], pts[1], pts[2], pts[3]);
                    Current.MFs.Add(mftemp);
                    popualteMF(mftemp);
                }
                Populate();
                this.ChartPanel.Paint += new PaintEventHandler(drawSelectedMF);
                this.ChartPanel.Refresh();
            }
            else
            {
                MessageBox.Show("It Exists!!! Try a new mf name", "MemberShip Function Exists",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SaveMFBtn_Click(object sender, EventArgs e)
        {
            if (MFView.Items.Count > 0)
            {
                Current.MFs[MFView.SelectedIndices[0]].Name = MFNameTxT.Text;
                MFView.Items[MFView.SelectedIndices[0]].Name = MFNameTxT.Text;
                MFView.Items[MFView.SelectedIndices[0]].Text = MFNameTxT.Text;
                Current.MFs[MFView.SelectedIndices[0]].Params = FuzzyApp.tokString(MFParamTxT.Text);
                this.ChartPanel.Paint += new PaintEventHandler(drawSelectedMF);
                this.ChartPanel.Refresh();
                Populate();
            }
        }

        private void RemMFBtn_Click(object sender, EventArgs e)
        {
            if (MFView.SelectedIndices.Count > 0)
            {
                Current.MFs.Remove(Current.MFs[MFView.SelectedIndices[0]]);
                MFView.Items.Remove(MFView.SelectedItems[0]);
                this.ChartPanel.Paint += new PaintEventHandler(drawSelectedMF);
                this.ChartPanel.Refresh();
                Populate();
            }
        }
        private void OnRangeEdit(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Current.Range = FuzzyApp.tokString(RangeTxT.Text);
                this.ChartPanel.Paint += new PaintEventHandler(drawSelectedMF);
                this.ChartPanel.Refresh();
                Populate();
            }
        }

        private void OnNameEdit(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Current.Name = VarTxT.Text;
                Populate();
            }
        }
    }
}
