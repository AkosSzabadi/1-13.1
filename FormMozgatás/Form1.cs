using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMozgatás
{
    public partial class formmove : Form
    {
        int meretezo = 40;
        public formmove()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Width < Screen.PrimaryScreen.Bounds.Width && Height < Screen.PrimaryScreen.Bounds.Height)
            {
                CenterToScreen();
                Width += meretezo;
                Height += meretezo;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Width > 300 && Height > 300)
            {
                CenterToScreen();
                Width -= meretezo;
                Height -= meretezo;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Left > 0)
            {
                Left -= meretezo;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Left < (Screen.PrimaryScreen.Bounds.Width - Width))
            {
                Left += meretezo;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Top < (Screen.PrimaryScreen.Bounds.Height - Height))
            {
                Top += meretezo;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Top = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Top > 0)
            {
                Top -= meretezo;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Left = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Opacity > 0.2)
                Opacity -= 0.1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Opacity < 1.0)
                Opacity += 0.1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
