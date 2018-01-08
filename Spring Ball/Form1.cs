using System;
using System.Drawing;
using System.Windows.Forms;

namespace Spring_Ball
{
    public partial class Form1 : Form
    {
        PointF p1, p2, p3;
        float default_x1, default_x2, default_x3;
        float r = 50;
        Timer timer;
        double[,] A;
        double[] x;
        double m1, m2, m3;
        Form2 settings;

        // Створення форми
        public Form1()
        {
            InitializeComponent();
            settings = new Form2();
            AddOwnedForm(settings);
        }

        // Дії при натисканні на кнопку "Відновлення"
        // Всі параметри скидуються до початкових, моделювання припиняється
        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            p1.X = default_x1;
            p2.X = default_x2;
            p3.X = default_x3;
            numericUpDown8.Value = 0;
            numericUpDown9.Value = 0;
            numericUpDown10.Value = 0;
            button1.Enabled = true;
            button3.Enabled = true;
            settings.reset(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            settings.save();
            settings.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer.Stop();
            p1.X = (float)Decimal.ToDouble(numericUpDown8.Value) + default_x1;
            p2.X = (float)Decimal.ToDouble(numericUpDown9.Value) + default_x2;
            p3.X = (float)Decimal.ToDouble(numericUpDown10.Value) + default_x3;
            button1.Enabled = true;
            button3.Enabled = true;
            DrawScene();
        }

        // Просто малювання ліній, кіл та підписів
        private void DrawScene()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Малювання ліній-пружин
            g.DrawLine(Pens.Black,  0,           bmp.Height / 2,     p1.X - r,  bmp.Height / 2);
            g.DrawLine(Pens.Black,  p1.X + r,    bmp.Height / 2,     p2.X - r,  bmp.Height / 2);
            g.DrawLine(Pens.Black,  p2.X + r,    bmp.Height / 2,     p3.X - r,  bmp.Height / 2);
            g.DrawLine(Pens.Black,  p3.X + r,    bmp.Height / 2,     bmp.Width, bmp.Height / 2);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Підпис ліній-пружин
            g.DrawString("c1",  SystemFonts.DefaultFont,    Brushes.Black,  p1.X / 2,                       p1.Y - r - 10);
            g.DrawString("c2",  SystemFonts.DefaultFont,    Brushes.Black,  (p1.X + p2.X) / 2,              p2.Y - r - 10);
            g.DrawString("c3",  SystemFonts.DefaultFont,    Brushes.Black,  (p2.X + p3.X) / 2,              p3.Y - r - 10);
            g.DrawString("c4",  SystemFonts.DefaultFont,    Brushes.Black,  (p3.X + pictureBox1.Width) / 2, p3.Y - r - 10);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Малювання куль
            g.DrawEllipse(Pens.Black,   p1.X - r,   p1.Y - r,   2 * r,  2 * r);
            g.DrawEllipse(Pens.Black,   p2.X - r,   p2.Y - r,   2 * r,  2 * r);
            g.DrawEllipse(Pens.Black,   p3.X - r,   p3.Y - r,   2 * r,  2 * r);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Підпис куль
            g.DrawString("m1",  SystemFonts.DefaultFont,    Brushes.Black,  p1.X - 9,   p1.Y - 7);
            g.DrawString("m2",  SystemFonts.DefaultFont,    Brushes.Black,  p2.X - 9,   p2.Y - 7);
            g.DrawString("m3",  SystemFonts.DefaultFont,    Brushes.Black,  p3.X - 9,   p3.Y - 7);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Вивід значень відхилень куль
            g.DrawString("x1 = " + (p1.X - default_x1).ToString(),  SystemFonts.DefaultFont,    Brushes.Black,  p1.X - r,   p1.Y + r + 3);
            g.DrawString("x2 = " + (p2.X - default_x2).ToString(),  SystemFonts.DefaultFont,    Brushes.Black,  p2.X - r,   p2.Y + r + 3);
            g.DrawString("x3 = " + (p3.X - default_x3).ToString(),  SystemFonts.DefaultFont,    Brushes.Black,  p3.X - r,   p3.Y + r + 3);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Перенесення графіки на компонент форми (picture box)
            pictureBox1.Image = bmp;
        }

        // При завантаженні форми
        private void Form1_Load(object sender, EventArgs e)
        {
            // Змінення розміру pictureBox
            pictureBox1.Height = Height;
            pictureBox1.Width = Width - groupBox1.Width - groupBox1.Left - 30;
            // Початкові точки куль (в цих точках відхилення відповідних куль = 0)
            default_x1 = pictureBox1.Width / 4;
            default_x2 = pictureBox1.Width / 2;
            default_x3 = pictureBox1.Width / 4 * 3;
            // Встановлення куль в їх початкові точки
            p1.X = default_x1;
            p2.X = default_x2;
            p3.X = default_x3;
            p1.Y = p2.Y = p3.Y = pictureBox1.Height / 2;
            // Малювання
            DrawScene();
        }

        // Коли змінюються значення х1, х2, х3. Виконується перевірка, чи вони не перетинаються між собою і зі стінками
        // Якщо так, то встановлюються в початкове положення
        private void NumericUpDownX_ValueChanged(object sender, EventArgs e)
        {
            double y1 = Decimal.ToDouble(numericUpDown8.Value), y2 = Decimal.ToDouble(numericUpDown9.Value), y3 = Decimal.ToDouble(numericUpDown10.Value);
            if (    0                   < default_x1 + y1 - r &&
                    default_x1 + y1 + r < default_x2 + y2 - r &&
                    default_x2 + y2 + r < default_x3 + y3 - r &&
                    default_x3 + y3 + r < pictureBox1.Width)
            {
                p1.X = (float)(default_x1 + y1);
                p2.X = (float)(default_x2 + y2);
                p3.X = (float)(default_x3 + y3);
            }
            else
            {
                p1.X = (default_x1);
                p2.X = (default_x2);
                p3.X = (default_x3);
                numericUpDown8.Value = 0;
                numericUpDown9.Value = 0;
                numericUpDown10.Value = 0;
            }
            DrawScene();
        }

        // Просто множення матриці А на вектор х
        private double[] Multiply()
        {
            double[] res = new double[] { 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < 6; ++i)
            {
                for (int j = 0; j < 6; ++j)
                {
                    res[i] += (double)(A.GetValue(i, j)) * x[j];
                }
            }
            return res;
        }

        // Функція, що викликається таймером кожні 10ms
        // Оновлює вектор х та запускає перемальовування сцени
        private void UpdateScene(Object myObject, EventArgs myEventArgs)
        {
            // dx = A * x
            double[] dx = Multiply();
            // x = x + dx * dt, dt = 10ms
            for (int i = 0; i < 6; ++i)
            {
                x[i] += dx[i] * 0.01;
            }
            // Переміщення куль в нові позиції
            p1.X = (float)(default_x1 + x[0]);
            p2.X = (float)(default_x2 + x[2]);
            p3.X = (float)(default_x3 + x[4]);
            // Перевірка зіткнення першої кулі з лівою стінкою
            if (0 > p1.X - r)
            {
                x[1] = Math.Abs(x[1]);
            }
            // Перевірка зіткнення першої кулі з другою
            if (p1.X + r > p2.X - r)
            {
                double temp = x[3];
                x[3] = (2 * m1 * x[1] + (m2 - m1) * x[3]) / (m1 + m2);
                x[1] = x[3] + temp - x[1];
            }
            // Перевірка зіткнення другої кулі з третьою
            if (p2.X + r > p3.X - r)
            {
                double temp = x[5];
                x[5] = (2 * m2 * x[3] + (m3 - m2) * x[5]) / (m2 + m3);
                x[3] = x[5] + temp - x[3];
            }
            // Перевірка зіткнення третьої кулі з правою стінкою
            if (p3.X + r > pictureBox1.Width)
            {
                x[5] = -1 * Math.Abs(x[5]);
            }
            // Малювання
            DrawScene();
        }

        // Дії при натисканні на кнопку "Запуск"
        // Зчитуються всі дані і запускається моделювання
        private void Button1_Click(object sender, EventArgs e)
        {           
            // Зчитування початкових відхилень куль
            double  x1 = Decimal.ToDouble(numericUpDown8.Value),
                    x2 = Decimal.ToDouble(numericUpDown9.Value),
                    x3 = Decimal.ToDouble(numericUpDown10.Value);
            // Встановлення початкових значень вектора х
            x = new double[] { x1, 0, x2, 0, x3, 0 };
            // Всатновлення матриці А
            A = settings.getA();
            double[] M = settings.getM();
            m1 = M[0];
            m2 = M[1];
            m3 = M[2];
            // Нові параметри можна встановити після перезапуску програми або натискання кнопки "Відновлення"
            button1.Enabled = false;
            button3.Enabled = false;
            // Встановлення та запуск таймера
            timer = new Timer
            {
                Interval = 10
            };
            timer.Tick += new EventHandler(UpdateScene);
            timer.Start();
        }
    }
}
