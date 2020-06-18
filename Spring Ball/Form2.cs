using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Spring_Ball
{
    public partial class Form2 : Form
    {
        public Utils.State Parameters { get; set; }

        public Form2()
        {
            InitializeComponent();
            Parameters = new Utils.State();
            CountValueChanged(null, null);
            UpdateParameters();
            PreviousParameters = Parameters.Clone();
        }

        public void ParametersChange(Utils.State parameters)
        {
            PreviousParameters = parameters.Clone();
            PreviousParameters.TimeInterval *= 1000;
            PreviousParameters.Fading *= 100;
            PreviousParameters.Coefficients = PreviousParameters.Coefficients.ConvertAll((float val) => val * 1000);
            Reset();
        }

        private Utils.State PreviousParameters { get; set; }

        private void UpdateParameters()
        {
            Parameters.Count = decimal.ToInt32(n31.Value);
            Parameters.Radius = decimal.ToInt32(n32.Value);
            Parameters.Fading = decimal.ToInt32(n21.Value);
            Parameters.TimeInterval = decimal.ToInt32(n11.Value);
            Parameters.Masses = new List<float>(Parameters.Count);
            Parameters.Coefficients = new List<float>(Parameters.Count + 1);
            Parameters.StartPositions = new List<float>(Parameters.Count);
            Parameters.BalancedPositions = new List<float>(Parameters.Count);
            for (var i = 0; i < Parameters.Count; ++i)
            {
                Parameters.Masses.Add(decimal.ToInt32(((NumericUpDown)g4.Controls.Find("n4" + i.ToString(), true)[0]).Value));
                Parameters.StartPositions.Add(decimal.ToInt32(((NumericUpDown)g5.Controls.Find("n5" + i.ToString(), true)[0]).Value));
                Parameters.Coefficients.Add(decimal.ToInt32(((NumericUpDown)g6.Controls.Find("n6" + i.ToString(), true)[0]).Value));
                Parameters.BalancedPositions.Add((i == 0 ? 0 : Parameters.BalancedPositions[i - 1]) + decimal.ToInt32(((NumericUpDown)g7.Controls.Find("n7" + i.ToString(), true)[0]).Value));
            }
            Parameters.Coefficients.Add(decimal.ToInt32(((NumericUpDown)g6.Controls.Find("n6" + Parameters.Count.ToString(), true)[0]).Value));
            Parameters.Width = Parameters.BalancedPositions[Parameters.Count - 1] + decimal.ToInt32(((NumericUpDown)g7.Controls.Find("n7" + Parameters.Count.ToString(), true)[0]).Value);
            for (var i = 0; i < Parameters.Count - 1; ++i)
            {
                if (Parameters.BalancedPositions[i] + Parameters.StartPositions[i] + Parameters.Radius > Parameters.BalancedPositions[i + 1] + Parameters.StartPositions[i + 1] - Parameters.Radius)
                {
                    Reset();
                }
            }
            if (0 > Parameters.StartPositions[0] + Parameters.BalancedPositions[0] - Parameters.Radius || Parameters.StartPositions[Parameters.Count - 1] + Parameters.BalancedPositions[Parameters.Count - 1] + Parameters.Radius > Parameters.Width)
            {
                Reset();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateParameters();
            Save();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reset();
            Visible = false;
        }

        private void Save() => PreviousParameters = Parameters.Clone();

        private void Reset()
        {
            Parameters = PreviousParameters.Clone();
            n11.Value = (int)Parameters.TimeInterval;
            n21.Value = (int)Parameters.Fading;
            n31.Value = Parameters.Count;
            n32.Value = (int)Parameters.Radius;
            CountValueChanged(null, null);
            for (var i = 0; i < Parameters.Count; ++i)
            {
                ((NumericUpDown)g4.Controls.Find("n4" + i.ToString(), true)[0]).Value = (int)Parameters.Masses[i];
                ((NumericUpDown)g5.Controls.Find("n5" + i.ToString(), true)[0]).Value = (int)Parameters.StartPositions[i];
                ((NumericUpDown)g6.Controls.Find("n6" + i.ToString(), true)[0]).Value = (int)Parameters.Coefficients[i];
                ((NumericUpDown)g7.Controls.Find("n7" + i.ToString(), true)[0]).Value = (int)(Parameters.BalancedPositions[i] - (i == 0 ? 0 : Parameters.BalancedPositions[i - 1]));
            }
            ((NumericUpDown)g6.Controls.Find("n6" + Parameters.Count.ToString(), true)[0]).Value = (int)Parameters.Coefficients[Parameters.Count];
            ((NumericUpDown)g7.Controls.Find("n7" + Parameters.Count.ToString(), true)[0]).Value = (int)(Parameters.Width - Parameters.BalancedPositions[Parameters.Count - 1]);
        }

        private void Form2_VisibleChanged(object sender, EventArgs e) => Owner.Enabled = true;

        private GroupBox MakeBox(string text, int i, int j, int min, int max, int value)
        {
            var n = new NumericUpDown
            {
                Name = "n" + i.ToString() + j.ToString(),
                Minimum = min,
                Maximum = max,
                Value = value,
                Location = new Point(6, 19)
            };
            var g = new GroupBox
            {
                Name = "g" + i.ToString() + j.ToString(),
                Text = text,
                Size = new Size(135, 50),
                Location = new Point(6 + 141 * j, 19)
            };
            g.Controls.Add(n);
            return g;
        }

        private void CountValueChanged(object sender, EventArgs e)
        {
            g4.Controls.Clear();
            g5.Controls.Clear();
            g6.Controls.Clear();
            var Count = decimal.ToInt32(n31.Value);
            g4.Size = g5.Size = new Size(6 + 141 * Count, 80);
            g6.Size = g7.Size = new Size(6 + 141 * (Count + 1), 80);
            g0.Size = new Size(12 + g6.Size.Width, g0.Size.Height);
            Size = new Size(30 + g0.Size.Width, Size.Height);
            for (var i = 0; i < Count; ++i)
            {
                g4.Controls.Add(MakeBox("m" + i.ToString(), 4, i, 0, 1000, 1));
                g5.Controls.Add(MakeBox("x" + i.ToString(), 5, i, -10000, 10000, 0));
                g6.Controls.Add(MakeBox("c" + i.ToString(), 6, i, 1, 1000, 20));
                g7.Controls.Add(MakeBox("l" + i.ToString(), 7, i, i == 0 ? (int)Parameters.Radius : 2 * (int)Parameters.Radius, 10000, 400));
            }
            g6.Controls.Add(MakeBox("c" + Count.ToString(), 6, Count, 1, 1000, 10));
            g7.Controls.Add(MakeBox("l" + Count.ToString(), 7, Count, 2 * (int)Parameters.Radius, 10000, 400));
        }
    }
}
