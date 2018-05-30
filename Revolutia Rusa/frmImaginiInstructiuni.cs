using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revolutia_Rusa
{
    public partial class frmImaginiInstructiuni : Form
    {
        public frmImaginiInstructiuni()
        {
            InitializeComponent();
        }

        private void closeInstructiuniGalerie_Click(object sender, EventArgs e)
        {
            Close();
        }

        Point LastPoint;

        private void frmLectii_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void frmLectii_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void frmImaginiInstructiuni_Load(object sender, EventArgs e)
        {
            if (variabile.background == 1)
            {
                this.BackgroundImage = new Bitmap("backgrounds\\panouh.png");
                label1.ForeColor = Color.Black;
            }
            else if (variabile.background == 2)
            {
                this.BackgroundImage = new Bitmap("backgrounds\\black-wood-wallpaper.jpg");
                label1.ForeColor = Color.White;
            }
        }
    }
}
