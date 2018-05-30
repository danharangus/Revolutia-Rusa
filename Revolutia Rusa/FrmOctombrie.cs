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
    public partial class FrmOctombrie : Form
    {
        int c = 1;
        public FrmOctombrie()
        {
            InitializeComponent();
        }
        Point LastPoint;

        private void frmOctombrie_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void frmOctombrie_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void closeOctombrie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmOctombrie_Load(object sender, EventArgs e)
        {
            textBox1.SelectionStart = textBox1.Text.Length;
            if (variabile.background == 1)
            {
                this.BackgroundImage = new Bitmap("backgrounds\\panouh.png");
                lblLectii.ForeColor = Color.Black;
            }
            else if (variabile.background == 2)
            {
                this.BackgroundImage = new Bitmap("backgrounds\\black-wood-wallpaper.jpg");
                lblLectii.ForeColor = Color.White;
            }
        }

        private void lectiiRight_Click(object sender, EventArgs e)
        {
            c++;
            if (c == 6)
            {
                c = 1;
            }
            pictureBox1.BackgroundImage = new Bitmap("Octombrie\\" + c.ToString() + ".jpg");
        }

        private void lectiiLeft_Click(object sender, EventArgs e)
        {
            c--;
            if (c == 0)
            {
                c = 5;
            }
            pictureBox1.BackgroundImage = new Bitmap("Octombrie\\" + c.ToString() + ".jpg");
        }
    }
}
