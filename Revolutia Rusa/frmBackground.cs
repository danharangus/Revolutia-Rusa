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
    public partial class frmBackground : Form
    {

        /* public frmLectii Lectii = null;
         public frmTest Test = null;
         public frmLogin Login = null;
         public frmJocImagini JocPersonalitati = null;
         public frmLectiiPers LectiiPers = null;
         public frmGalerie Galerie = null;
         public frmBibliografie Bibliografie = null;
         public frmBackground Background = null;
         public FrmFebruarie Februarie = null;
         public FrmIulie Iulie = null;
         public FrmOctombrie Octombrie = null;
         public frmImaginiInstructiuni Instructiuni = null;*/

        public frmBackground()
        {
            InitializeComponent();
        }

        Point LastPoint;

        private void frmTest_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void frmTest_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void closeBackground_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            variabile.background = 1;
            lblBackground.ForeColor = Color.Black;
            if (variabile.background == 1)
            {
                this.BackgroundImage = new Bitmap("backgrounds\\panouh.png");
                bg1Selected.Visible = true;
                bg2Selected.Visible = false;
            }
            else if (variabile.background == 2)
            {
                this.BackgroundImage = new Bitmap("backgrounds\\black-wood-wallpaper.jpg");
                bg1Selected.Visible = false;
                bg2Selected.Visible = true;
            }
            if ((this.MdiParent as frmMain).Bibliografie != null)
            {
                (this.MdiParent as frmMain).Bibliografie.BackgroundImage = new Bitmap("backgrounds\\panouh.png");
                (this.MdiParent as frmMain).Bibliografie.label1.ForeColor = Color.Black;
            }

            if ((this.MdiParent as frmMain).Lectii != null)
            {
                (this.MdiParent as frmMain).Lectii.BackgroundImage = new Bitmap("backgrounds\\panouh.png");
                (this.MdiParent as frmMain).Lectii.lblLectii.ForeColor = Color.Black;
            }

            if ((this.MdiParent as frmMain).Test != null)
            {
                (this.MdiParent as frmMain).Test.pnlTest.BackgroundImage = new Bitmap("backgrounds\\panouh.png");
                (this.MdiParent as frmMain).Test.radioButton1.ForeColor = Color.Black;
                (this.MdiParent as frmMain).Test.radioButton2.ForeColor = Color.Black;
                (this.MdiParent as frmMain).Test.radioButton3.ForeColor = Color.Black;
                (this.MdiParent as frmMain).Test.lblIntrebare.ForeColor = Color.Black;
                (this.MdiParent as frmMain).Test.lblName.ForeColor = Color.Black;
            }

            if ((this.MdiParent as frmMain).JocPersonalitati != null)
            {
                (this.MdiParent as frmMain).JocPersonalitati.BackgroundImage = new Bitmap("backgrounds\\panouh.png");
                (this.MdiParent as frmMain).JocPersonalitati.lblNume.ForeColor = Color.Black;
                (this.MdiParent as frmMain).JocPersonalitati.label1.ForeColor = Color.Black;
            }

            if ((this.MdiParent as frmMain).LectiiPers != null)
            {
                (this.MdiParent as frmMain).LectiiPers.BackgroundImage = new Bitmap("backgrounds\\panouh.png");
                (this.MdiParent as frmMain).LectiiPers.lblLectiiPers.ForeColor = Color.Black;
            }

            if ((this.MdiParent as frmMain).Galerie != null)
            {
                (this.MdiParent as frmMain).Galerie.BackgroundImage = new Bitmap("backgrounds\\panouh.png");
                (this.MdiParent as frmMain).Galerie.lblgalerie.ForeColor = Color.Black;
            }

            if ((this.MdiParent as frmMain).Background != null)
            {
                (this.MdiParent as frmMain).Background.BackgroundImage = new Bitmap("backgrounds\\panouh.png");
            }
            if ((this.MdiParent as frmMain).Februarie != null)
            {
                (this.MdiParent as frmMain).Februarie.BackgroundImage = new Bitmap("backgrounds\\panouh.png");
                (this.MdiParent as frmMain).Februarie.lblLectii.ForeColor = Color.Black;
            }

            if ((this.MdiParent as frmMain).Iulie != null)
            {
                (this.MdiParent as frmMain).Iulie.BackgroundImage = new Bitmap("backgrounds\\panouh.png");
                (this.MdiParent as frmMain).Iulie.lblLectii.ForeColor = Color.Black;
            }

            if ((this.MdiParent as frmMain).Octombrie != null)
            {
                (this.MdiParent as frmMain).Octombrie.BackgroundImage = new Bitmap("backgrounds\\panouh.png");
                (this.MdiParent as frmMain).Octombrie.lblLectii.ForeColor = Color.Black;
            }

            if ((this.MdiParent as frmMain).ImaginiInstructiuni != null)
            {
                (this.MdiParent as frmMain).ImaginiInstructiuni.BackgroundImage = new Bitmap("backgrounds\\panouh.png");
                (this.MdiParent as frmMain).ImaginiInstructiuni.label1.ForeColor = Color.Black;
            }

            if ((this.MdiParent as frmMain).Login != null)
            {
                (this.MdiParent as frmMain).Login.BackgroundImage = new Bitmap("backgrounds\\panouh.png");
                (this.MdiParent as frmMain).Login.lblParola.ForeColor = Color.Black;
                (this.MdiParent as frmMain).Login.lblUser.ForeColor = Color.Black;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            variabile.background = 2;
            lblBackground.ForeColor = Color.White;
            if (variabile.background == 1)
            {
                this.BackgroundImage = new Bitmap("backgrounds\\panouh.png");
                bg1Selected.Visible = true;
                bg2Selected.Visible = false;
            }
            else if (variabile.background == 2)
            {
                this.BackgroundImage = new Bitmap("backgrounds\\black-wood-wallpaper.jpg");
                bg1Selected.Visible = false;
                bg2Selected.Visible = true;
            }
            if ((this.MdiParent as frmMain).Bibliografie != null)
            {
                (this.MdiParent as frmMain).Bibliografie.BackgroundImage = new Bitmap("backgrounds\\black-wood-wallpaper.jpg");
                (this.MdiParent as frmMain).Bibliografie.label1.ForeColor = Color.White;

            }

            if ((this.MdiParent as frmMain).Lectii != null)
            {
                (this.MdiParent as frmMain).Lectii.BackgroundImage = new Bitmap("backgrounds\\black-wood-wallpaper.jpg");
                (this.MdiParent as frmMain).Lectii.lblLectii.ForeColor = Color.White;
            }

            if ((this.MdiParent as frmMain).Test != null)
            {
                (this.MdiParent as frmMain).Test.pnlTest.BackgroundImage = new Bitmap("backgrounds\\black-wood-wallpaper.jpg");
                (this.MdiParent as frmMain).Test.radioButton1.ForeColor = Color.White;
                (this.MdiParent as frmMain).Test.radioButton2.ForeColor = Color.White;
                (this.MdiParent as frmMain).Test.radioButton3.ForeColor = Color.White;
                (this.MdiParent as frmMain).Test.lblIntrebare.ForeColor = Color.White;
                (this.MdiParent as frmMain).Test.lblName.ForeColor = Color.White;
            }

            if ((this.MdiParent as frmMain).JocPersonalitati != null)
            {
                (this.MdiParent as frmMain).JocPersonalitati.BackgroundImage = new Bitmap("backgrounds\\black-wood-wallpaper.jpg");
                (this.MdiParent as frmMain).JocPersonalitati.lblNume.ForeColor = Color.White;
                (this.MdiParent as frmMain).JocPersonalitati.label1.ForeColor = Color.White;
            }

            if ((this.MdiParent as frmMain).LectiiPers != null)
            {
                (this.MdiParent as frmMain).LectiiPers.BackgroundImage = new Bitmap("backgrounds\\black-wood-wallpaper.jpg");
                (this.MdiParent as frmMain).LectiiPers.lblLectiiPers.ForeColor = Color.White;
            }

            if ((this.MdiParent as frmMain).Galerie != null)
            {
                (this.MdiParent as frmMain).Galerie.BackgroundImage = new Bitmap("backgrounds\\black-wood-wallpaper.jpg");
                (this.MdiParent as frmMain).Galerie.lblgalerie.ForeColor = Color.White;
            }

            if ((this.MdiParent as frmMain).Background != null)
            {
                (this.MdiParent as frmMain).Background.BackgroundImage = new Bitmap("backgrounds\\black-wood-wallpaper.jpg");
            }
            if ((this.MdiParent as frmMain).Februarie != null)
            {
                (this.MdiParent as frmMain).Februarie.BackgroundImage = new Bitmap("backgrounds\\black-wood-wallpaper.jpg");
                (this.MdiParent as frmMain).Februarie.lblLectii.ForeColor = Color.White;
            }

            if ((this.MdiParent as frmMain).Iulie != null)
            {
                (this.MdiParent as frmMain).Iulie.BackgroundImage = new Bitmap("backgrounds\\black-wood-wallpaper.jpg");
                (this.MdiParent as frmMain).Iulie.lblLectii.ForeColor = Color.White;
            }

            if ((this.MdiParent as frmMain).Octombrie != null)
            {
                (this.MdiParent as frmMain).Octombrie.BackgroundImage = new Bitmap("backgrounds\\black-wood-wallpaper.jpg");
                (this.MdiParent as frmMain).Iulie.lblLectii.ForeColor = Color.White;
            } 

            if ((this.MdiParent as frmMain).ImaginiInstructiuni != null)
            {
                (this.MdiParent as frmMain).ImaginiInstructiuni.BackgroundImage = new Bitmap("backgrounds\\black-wood-wallpaper.jpg");
                (this.MdiParent as frmMain).ImaginiInstructiuni.label1.ForeColor = Color.White;
            }

            if ((this.MdiParent as frmMain).Login != null)
            {
                (this.MdiParent as frmMain).Login.BackgroundImage = new Bitmap("backgrounds\\black-wood-wallpaper.jpg");
                (this.MdiParent as frmMain).Login.lblParola.ForeColor = Color.White;
                (this.MdiParent as frmMain).Login.lblUser.ForeColor = Color.White;
            }
        }

        private void frmBackground_Load(object sender, EventArgs e)
        {
            if (variabile.background == 1)
            {
                this.BackgroundImage = new Bitmap("backgrounds\\panouh.png");
                lblBackground.ForeColor = Color.Black;
                bg1Selected.Visible = true;
                bg2Selected.Visible = false;
            }
            else if (variabile.background == 2)
            {
                this.BackgroundImage = new Bitmap("backgrounds\\black-wood-wallpaper.jpg");
                lblBackground.ForeColor = Color.White;
                bg1Selected.Visible = false;
                bg2Selected.Visible = true;
            }
        }
    }
}
