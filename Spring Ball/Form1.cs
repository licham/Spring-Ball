using System;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Spring_Ball
{
    public partial class Form1 : Form
    {
        private Simulator simulator;
        private Protocol protocol;
        private Timer timer;
        private readonly Form2 settings;
        private readonly Form3 plotter;
        private readonly Image img_spring = Image.FromFile("Spring.jpg");
        private Image img_ball;

        public Form1()
        {
            InitializeComponent();
            settings = new Form2();
            plotter = new Form3();
            AddOwnedForm(settings);
            AddOwnedForm(plotter);
        }

        private void DrawScene()
        {
            label1.Text = simulator.State.Time.ToString();

            var bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            var g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            var positions = new List<float>(simulator.State.Count);
            for (var i = 0; i < simulator.State.Count; ++i)
            {
                positions.Add(simulator.State.BalancedPositions[i] + simulator.State.Positions[i]);
            }
            var radius = (int)simulator.State.Radius;
            var count = simulator.State.Count;
            var height = bmp.Height / 2;
            Point ulCorner;

            for (var i = 0; i < count; ++i)
            {
                if (i == 0)
                {
                    var length = (int)(positions[0] - radius > 1 ? positions[0] - radius : 1);
                    Image img = new Bitmap(img_spring, new Size(length, 2 * radius));
                    ulCorner = new Point(0, height - radius);
                    g.DrawImage(img, ulCorner);
                }
                if (i == count - 1)
                {
                    var length = (int)(bmp.Width - positions[i] - radius > 1 ? bmp.Width - positions[i] - radius : 1);
                    Image img = new Bitmap(img_spring, new Size(length, 2 * radius));
                    ulCorner = new Point((int)positions[i] + radius, height - radius);
                    g.DrawImage(img, ulCorner);
                }
                else
                {
                    var length = (int)(positions[i + 1] - positions[i] - 2 * radius > 1 ? positions[i + 1] - positions[i] - 2 * radius : 1);
                    Image img = new Bitmap(img_spring, new Size(length, 2 * radius));
                    ulCorner = new Point((int)positions[i] + radius, height - radius);
                    g.DrawImage(img, ulCorner);
                }
                ulCorner = new Point((int)positions[i] - radius, height - radius);
                g.DrawImage(img_ball, ulCorner);
                g.DrawString("x" + i.ToString() + " = " + simulator.State.Positions[i].ToString(), SystemFonts.DefaultFont, Brushes.Black, positions[i] - radius, height + radius + 3);
            }
            pictureBox1.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Height = Height - 100;
            simulator = new Simulator();
            protocol = new Protocol();
            timer = new Timer
            {
                Interval = 10
            };
            timer.Tick += UpdateScene;
            LoadSettingsState();
        }

        private void UpdateScene(object myObject, EventArgs myEventArgs)
        {
            simulator.Update();
            plotter.Update(simulator.State.Positions);
            protocol.Update(simulator.State);
            DrawScene();
        }

        private void LoadSettingsState()
        {
            var state = settings.Parameters.Clone();
            state.Positions = new List<float>(state.StartPositions);
            state.Fading /= 100;
            state.TimeInterval /= 1000;
            state.Coefficients = state.Coefficients.ConvertAll((float val) => val / 1000);
            state.MaxRightPositions = new List<float>(state.StartPositions);
            state.MaxLeftPositions = new List<float>(state.StartPositions);
            state.Time = 0;
            state.Speeds = Utils.GetValueList(0, state.Count);

            simulator.State = state;

            img_ball = new Bitmap(Image.FromFile("Ball.jpg"), new Size(2 * (int)state.Radius, 2 * (int)state.Radius));

            protocol.Start(state);

            plotter.Count = simulator.State.Count;
            plotter.TimeInterval = simulator.State.TimeInterval;
            plotter.Start();

            pictureBox1.Width = (int)state.Width;
            DrawScene();
        }

        private void Form1_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled == true)
            {
                protocol.Stop();
                LoadSettingsState();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //protocol.Stop();
        }

        private void стартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            protocol.Stop();
            LoadSettingsState();
            стартToolStripMenuItem.Enabled = false;
            паузаToolStripMenuItem.Enabled = true;
            стопToolStripMenuItem.Enabled = true;
            налаштуванняToolStripMenuItem.Enabled = false;
            графікиToolStripMenuItem.Enabled = true;
            протоколToolStripMenuItem.Enabled = true;
            максимальніВідхиленняToolStripMenuItem.Enabled = true;
            зберегтиПротоколToolStripMenuItem.Enabled = true;
            timer.Start();
        }

        private void паузаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (паузаToolStripMenuItem.Text == "Пауза")
            {
                timer.Stop();
                паузаToolStripMenuItem.Text = "Продовжити";
            }
            else
            {
                timer.Start();
                паузаToolStripMenuItem.Text = "Пауза";
            }
        }

        private void стопToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            стартToolStripMenuItem.Enabled = true;
            паузаToolStripMenuItem.Enabled = false;
            паузаToolStripMenuItem.Text = "Пауза";
            стопToolStripMenuItem.Enabled = false;
            налаштуванняToolStripMenuItem.Enabled = true;
        }

        private void налаштуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings.Visible = true;
            Enabled = false;
        }

        private void графікиToolStripMenuItem_Click(object sender, EventArgs e) => plotter.Visible = true;

        private void зберегтиПротоколToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.Copy(Path.GetFullPath("QuickProtocol.txt"), Path.GetFullPath(saveFileDialog.FileName));
            }
        }

        private void протоколToolStripMenuItem_Click(object sender, EventArgs e) => Process.Start("QuickProtocol.txt");

        private void завантажитиПротоколToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            protocol.Stop();
            var openFileDialog = new OpenFileDialog
            {
                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK && Path.GetFullPath(openFileDialog.FileName) != Path.GetFullPath("QuickProtocol.txt"))
            {
                var state = protocol.Load(Path.GetFullPath(openFileDialog.FileName), protocol, plotter);
                settings.ParametersChange(state);
                simulator.State = state;
                img_ball = new Bitmap(Image.FromFile("Ball.jpg"), new Size(2 * (int)state.Radius, 2 * (int)state.Radius));
                pictureBox1.Width = (int)state.Width;
                DrawScene();

                стартToolStripMenuItem.Enabled = false;
                паузаToolStripMenuItem.Enabled = true;
                паузаToolStripMenuItem.Text = "Продовжити";
                стопToolStripMenuItem.Enabled = true;
                налаштуванняToolStripMenuItem.Enabled = false;
                графікиToolStripMenuItem.Enabled = true;
                протоколToolStripMenuItem.Enabled = true;
                максимальніВідхиленняToolStripMenuItem.Enabled = true;
                зберегтиПротоколToolStripMenuItem.Enabled = true;
            }
        }

        private void максимальніВідхиленняToolStripMenuItem_Click(object sender, EventArgs e) => Process.Start("QuickPositions.txt");
    }
}
