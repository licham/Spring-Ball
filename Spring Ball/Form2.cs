using System;
using System.Windows.Forms;

namespace Spring_Ball
{
    public partial class Form2 : Form
    {
        double[]    M;
        double[,]   A;
        double[] sM, sC;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset(false);
            Hide();
        }

        public void save()
        {
            sM = new double[3] { Decimal.ToDouble(numericUpDown1.Value), Decimal.ToDouble(numericUpDown2.Value), Decimal.ToDouble(numericUpDown3.Value) };
            sC = new double[4] { Decimal.ToDouble(numericUpDown4.Value), Decimal.ToDouble(numericUpDown5.Value), Decimal.ToDouble(numericUpDown6.Value), Decimal.ToDouble(numericUpDown7.Value) };
        }

        public void reset(bool toDefault)
        {
            if (toDefault)
            {
                numericUpDown1.Value = 1;
                numericUpDown2.Value = 1;
                numericUpDown3.Value = 1;
                numericUpDown4.Value = 1;
                numericUpDown5.Value = 1;
                numericUpDown6.Value = 1;
                numericUpDown7.Value = 1;
            } else
            {
                numericUpDown1.Value = (int)sM[0];
                numericUpDown2.Value = (int)sM[1];
                numericUpDown3.Value = (int)sM[2];
                numericUpDown4.Value = (int)sC[0];
                numericUpDown5.Value = (int)sC[1];
                numericUpDown6.Value = (int)sC[2];
                numericUpDown7.Value = (int)sC[3];
            }
        }

        public double[,] getA()
        {
            getM();
            // Зчитування жорсткості пружин
            double  c1 = Decimal.ToDouble(numericUpDown4.Value) / 10,
                    c2 = Decimal.ToDouble(numericUpDown5.Value) / 10,
                    c3 = Decimal.ToDouble(numericUpDown6.Value) / 10,
                    c4 = Decimal.ToDouble(numericUpDown7.Value) / 10;
            // Всатновлення матриці А
            A = new double[6,6]{{   0,                  1,  0,                  0,  0,                  0},
                                {   -(c2 + c1) / M[0],  0,  c2 / M[0],          0,  0,                  0},
                                {   0,                  0,  0,                  1,  0,                  0},
                                {   c2 / M[1],          0,  -(c2 + c3) / M[1],  0,  c3 / M[1],          0},
                                {   0,                  0,  0,                  0,  0,                  1},
                                {   0,                  0,  c3 / M[2],          0,  -(c4 + c3) / M[2],  0} };
            return A;
        }

        public double[] getM()
        {
            // Зчитування маси куль
            M = new double[3] { Decimal.ToDouble(numericUpDown1.Value), Decimal.ToDouble(numericUpDown2.Value), Decimal.ToDouble(numericUpDown3.Value) };
            return M;
        }
    }
}
