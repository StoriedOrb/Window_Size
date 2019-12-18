using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenResolution
{
    public partial class Form1 : Form
    {
        public bool space = true;
        public int t1 = 0;
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.MouseWheel += new MouseEventHandler(Form1_MouseWheel);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (space == true)
            {
                label2.Text = "Координата У: " + (e.Y).ToString();
                label3.Text = "Координата Х: " + (e.X).ToString();
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)     //////////// SPACE
            {
                if (space == false)
                {
                    space = true;
                }
                else
                {
                    space = false;
                }
            }
            if (e.KeyCode == Keys.Up && e.Shift)       //////////// UP
            {
                this.Height += 4;
                this.Top -= 4;
            }
            else
            {
                if (e.KeyCode == Keys.Up && e.Control)
                {
                    this.Height -= 4;
                }
                else
                {
                    if (e.KeyCode == Keys.Up)
                    {
                        this.Top -= 4;
                    }
                }
            }

            if (e.KeyCode == Keys.Left && e.Shift)      //////////// LEFT
            {
                this.Width += 4;
                this.Left -= 4;
            }
            else
            {
                if (e.KeyCode == Keys.Left && e.Control)
                {
                    this.Width -= 4;
                }
                else
                {
                    if (e.KeyCode == Keys.Left)
                    {
                        this.Left -= 4;
                    }
                }
            }

            if (e.KeyCode == Keys.Down && e.Shift)      //////////// DOWN
            {
                this.Height += 4;
            }
            else
            {
                if (e.KeyCode == Keys.Down && e.Control)
                {
                    this.Height -= 4;
                    this.Top += 4;
                }
                else
                {
                    if (e.KeyCode == Keys.Down)
                    {
                        this.Top += 4;
                    }
                }
            }

            if (e.KeyCode == Keys.Right && e.Shift)     //////////// RIGHT
            {
                this.Width += 4;
            }
            else
            {
                if (e.KeyCode == Keys.Right && e.Control)
                {
                    this.Width -= 4;
                    this.Left += 4;
                }
                else
                {
                    if (e.KeyCode == Keys.Right)
                    {
                        this.Left += 4;
                    }
                }
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)     //////////// t1
        {
            if (e.Button == MouseButtons.Left)
            {
                t1 = 1;
                timer1.Start();
            }
            if (e.Button == MouseButtons.Right)
            {
                t1 = 2;
                timer1.Start();
            }
            if (e.Button == MouseButtons.Middle)
            {
                Random rnd = new Random();
                this.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            }

        }
        private void Form1_MouseWheel(object sender, MouseEventArgs b)     //////////// OPACITY
        {
            if (b.Delta > 0)
            {
                Opacity += 0.009;
            }
            else
            {
                Opacity -= 0.009;
                if (Opacity < 0.05)
                {
                    Opacity = 1;
                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)    /////DATE AND TIME
        {
            if (t1 == 1)
                this.Text = DateTime.Now.ToString("HH:mm:ss");
            if (t1 == 2)
                this.Text = DateTime.Now.ToString("dd MMMM yyyy");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
