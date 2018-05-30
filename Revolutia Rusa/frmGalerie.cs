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
    public partial class frmGalerie : Form
    {
        int c = 1;
        private string[] Descrieri = new string[30] { "Războiul Civil din Rusia","Revoluția Rusa","Abdicarea Țarului Nicolae II","Revoluția Rusa din octombrie 1917","Lenin și bolsevicii", "Decretul asupra păcii", "Primul Război Mondial", "Primul Război Mondial", "Primul Război Mondial", "Primul Război Mondial", "Aleksandr Kerenski", "Vladimir Ilici Lenin", "Nicolae al II-lea", "Iosif Vissarionovici Stalin", "Simbol național al Rusiei", "Steagul Rusiei 1917","Steagul actual al Rusiei","Stema Rusiei","Steagul URSS","Marșul femeilor","Garnizoana din Petrograd","Țarul Nicolae al II-lea","Alexei Romanov","Vladimir Ilici Lenin","Guvernul provizoriu Kerenski","Atacul asupra Palatului de iarna", "Revoluția Rusa din octombrie 1917", "Familia Romanov","Guvernul bolșevic","Revoluționari bloșevici"};
        public frmGalerie()
        {
            InitializeComponent();
        }
        private void GalerieRight_Click(object sender, EventArgs e)
        {
            c++;
            if (c == 31)
            {
                c = 1;
            }
            pbPnl1.Image = new Bitmap("GALERIE\\" + c.ToString() + ".jpg");
            lblgalerie.Text = Descrieri[c - 1];
        }

        private void GalerieLeft_Click(object sender, EventArgs e)
        {
            c--;
            if (c == 0)
            {
                c = 30;
            }
            pbPnl1.Image = new Bitmap("GALERIE\\" + c.ToString() + ".jpg");
            lblgalerie.Text = Descrieri[c - 1];
        }

        private void closeGalerie_Click(object sender, EventArgs e)
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

        private void lblgalerie_Click(object sender, EventArgs e)
        {

        }

        private void frmGalerie_Load(object sender, EventArgs e)
        {
            if (variabile.background == 1)
            {
                this.BackgroundImage = new Bitmap("backgrounds\\panouh.png");
                lblgalerie.ForeColor = Color.Black;
            }
            else if (variabile.background == 2)
            {
                this.BackgroundImage = new Bitmap("backgrounds\\black-wood-wallpaper.jpg");
                lblgalerie.ForeColor = Color.White;
            }
        }
    }
}
