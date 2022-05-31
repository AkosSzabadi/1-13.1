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
        int meretezo = 50;
        public formmove()
        {
            InitializeComponent();
        }

        private void formmove_Load(object sender, EventArgs e)
        {
            CenterToScreen();

        }

        private void btn_bnov_Click(object sender, EventArgs e)
        {
            if (Opacity < 1.0)
                Opacity += 0.1;
        }

        private void btn_bcsokk_Click(object sender, EventArgs e)
        {
            if (Opacity > 0.2)
                Opacity -= 0.1;
        }

        private void btn_teljesfel_Click(object sender, EventArgs e)
        {
            Top = 0;
        }

        private void btn_teljesbal_Click(object sender, EventArgs e)
        {
            Left = 0;
        }

        private void btn_teljesjobb_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
        }

        private void btn_teljesle_Click(object sender, EventArgs e)
        {
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
        }

        private void btn_kozep_Click(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void btn_fel_Click(object sender, EventArgs e)
        {
            if (Top > 0)
            {
                Top -= meretezo;
            }
        }

        private void btn_le_Click(object sender, EventArgs e)
        {
            if (Top < (Screen.PrimaryScreen.Bounds.Height - Height))
            {
                Top += meretezo;
            }
        }

        private void btn_jobb_Click(object sender, EventArgs e)
        {
            if (Left < (Screen.PrimaryScreen.Bounds.Width - Width))
            {
                Left += meretezo;
            }
        }

        private void btn_bal_Click(object sender, EventArgs e)
        {
            if (Left > 0)
            {
                Left -= meretezo;
            }
        }

        private void btn_tno_Click(object sender, EventArgs e)
        {
            if (Width < Screen.PrimaryScreen.Bounds.Width && Height < Screen.PrimaryScreen.Bounds.Height)
            {
                CenterToScreen();
                Width += meretezo;
                Height += meretezo;
            }
        }

        private void btn_tcsokk_Click(object sender, EventArgs e)
        {
            if (Width > 300 && Height > 300)
            {
                CenterToScreen();
                Width -= meretezo;
                Height -= meretezo;
            }
        }
    }
}
