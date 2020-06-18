using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Spring_Ball
{
    public partial class Form3 : Form
    {
        public int Count { get; set; }
        public float TimeInterval { get; set; }

        public Form3() => InitializeComponent();

        public void Start()
        {
            LeftTimePosition = 1000;
            LeftTime = 0;
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(button1);
            groupBox1.Size = new Size(1020, 20 + Count * 660 + button1.Size.Height);
            button1.Location = new Point(5, 20 + Count * 660);
            Positions = new List<List<float>>(Count);
            for (var i = 0; i < Count; ++i)
            {
                groupBox1.Controls.Add(MakeBox(i));
                Positions.Add(Utils.GetValueList(0, 1000));
            }
        }

        public void Update(List<float> positions)
        {
            for (var i = 0; i < Count; ++i)
            {
                var bmp = new Bitmap(1000, 600);
                var g = Graphics.FromImage(bmp);
                g.Clear(Color.White);
                DrawGrid(g);
                for (var j = 1; j < 999; ++j)
                {
                    Positions[i][j - 1] = Positions[i][j];
                    g.DrawLine(Pens.Black, j - 1, -Positions[i][j] + 300, j, -Positions[i][j + 1] + 300);
                }
                Positions[i][998] = Positions[i][999];
                Positions[i][999] = positions[i] * 3 / 10;
                g.DrawLine(Pens.Black, 998, -Positions[i][998] + 300, 999, -Positions[i][999] + 300);
                ((PictureBox)groupBox1.Controls.Find("p" + i.ToString(), true)[0]).Image = bmp;
            }
            LeftTimePosition--;
            if (0 > LeftTimePosition)
            {
                LeftTimePosition += 100;
                LeftTime += 100 * TimeInterval;
            }
        }

        private List<List<float>> Positions { get; set; }
        private int LeftTimePosition { get; set; }
        private float LeftTime { get; set; }

        private void DrawGrid(Graphics g)
        {
            var pen = new Pen(Color.Black)
            {
                DashPattern = new float[2] { 10, 10 }
            };
            pen.Width = 3;
            g.DrawLine(pen, 0, 300, 1000, 300);
            g.DrawString("0", SystemFonts.DefaultFont, Brushes.Black, 3, 300 - 13);

            pen.Width = 1;
            for (var i = -19; i < 20; ++i)
            {
                if (i != 0)
                {
                    g.DrawLine(pen, 0, 300 - i * 15, 1000, 300 - i * 15);
                    g.DrawString((i * 50).ToString(), SystemFonts.DefaultFont, Brushes.Black, 3, 300 - i * 15 - 13);
                }
            }

            pen.DashPattern = new float[2] { 5, 5 };
            var position = LeftTimePosition;
            var k = 0;
            while (position < 1000)
            {
                g.DrawLine(pen, position, 600, position, 0);
                g.DrawString((LeftTime + k * TimeInterval).ToString() + "с", SystemFonts.DefaultFont, Brushes.Black, position + 3, 585);
                position += 100;
                k += 100;
            }
        }

        private GroupBox MakeBox(int i)
        {
            var p = new PictureBox
            {
                Name = "p" + i.ToString(),
                Location = new Point(5, 20),
                Size = new Size(1000, 600)
            };
            var g = new GroupBox
            {
                Name = "g" + i.ToString(),
                Text = "Куля " + i.ToString(),
                Size = new Size(1010, 640),
                Location = new Point(5, 20 + i * 660)
            };
            g.Controls.Add(p);
            return g;
        }

        private void button1_Click(object sender, EventArgs e) => Visible = false;
    }
}
