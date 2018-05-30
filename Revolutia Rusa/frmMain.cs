using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revolutia_Rusa
{
    public partial class frmMain : Form
    {
        public frmLectii Lectii = null;
        public frmTest Test = null;
        public frmLogin Login = null;
        public frmJocImagini JocPersonalitati = null;
        public frmLectiiPers LectiiPers = null;
        public frmGalerie Galerie = null;
        public SoundPlayer sndplayr;
        public frmBibliografie Bibliografie = null;
        public frmBackground Background = null;
        public FrmFebruarie Februarie = null;
        public FrmIulie Iulie = null;
        public FrmOctombrie Octombrie = null;
        public frmImaginiInstructiuni ImaginiInstructiuni = null;



        public int click = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void contextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lectii = new frmLectii();
            Lectii.MdiParent = this;
            Lectii.Show();
            Lectii.Text = "Context";
        }

        private void jocPersonalitatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (JocPersonalitati == null)
            {
                if (variabile.logat == 1)
                {
                    JocPersonalitati = new frmJocImagini();
                    JocPersonalitati.MdiParent = this;
                    JocPersonalitati.Show();
                }
                else
                {
                    variabile.NotLoggedIn = "Personalitati";
                    MessageBox.Show("Nu v-ați conectat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Login = new frmLogin();
                    Login.MdiParent = this;
                    Login.Show();
                }
            }
            else
            {
                MessageBox.Show("Eroare: Nu puteţi rula mai multe instanţe ale jocului simultan.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void jocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Test == null)
            {
                if (variabile.logat == 1)
                {
                    Test = new frmTest();
                    Test.MdiParent = this;
                    Test.Show();
                }
                else
                {
                    variabile.NotLoggedIn = "Test";
                    MessageBox.Show("Nu v-ați conectat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Login = new frmLogin();
                    Login.MdiParent = this;
                    Login.Show();
                }
            }
            else
            {
                MessageBox.Show("Eroare: Nu puteţi rula mai multe instanţe ale testului simultan.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login = new frmLogin();
            Login.MdiParent = this;
            Login.Show();
        }

        private void leninToolStripMenuItem_Click(object sender, EventArgs e)
        {
            variabile.Personalitatea = "Lenin";
            LectiiPers = new frmLectiiPers();
            LectiiPers.MdiParent = this;
            LectiiPers.Show();
        }

        private void nicolaeAlIIleaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            variabile.Personalitatea = "Nicolae";
            LectiiPers = new frmLectiiPers();
            LectiiPers.MdiParent = this;
            LectiiPers.Show();
        }

        private void stalinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            variabile.Personalitatea = "Stalin";
            LectiiPers = new frmLectiiPers();
            LectiiPers.MdiParent = this;
            LectiiPers.Show();
        }

        private void kerenskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            variabile.Personalitatea = "Aleksandr Kerenski";
            LectiiPers = new frmLectiiPers();
            LectiiPers.MdiParent = this;
            LectiiPers.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                sndplayr = new SoundPlayer("muzica.wav");
                sndplayr.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString(), "Error");
            }
        }

        private void galerieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Galerie = new frmGalerie();
            Galerie.MdiParent = this;
            Galerie.Show();
        }

        private void buttonVolume_Click(object sender, EventArgs e)
        {
            click++;
            if (click == 1)
            {
                sndplayr.Stop();
                buttonVolume.BackgroundImage = new Bitmap("buttons\\mute.png");
                toolTip1.SetToolTip(buttonVolume, "Click pentru a porni muzica");
            }
            else if (click == 2)
            {
                sndplayr.Play();
                buttonVolume.BackgroundImage = new Bitmap("buttons\\volume.png");
                toolTip1.SetToolTip(buttonVolume, "Click pentru a opri muzica");
            }

            if (click == 2)
            {
                click = 0;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void ianuarieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Iulie = new FrmIulie();
            Iulie.MdiParent = this;
            Iulie.Show();
        }

        private void februarieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Februarie = new FrmFebruarie();
            Februarie.MdiParent = this;
            Februarie.Show();
        }

        private void octombrieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Octombrie= new FrmOctombrie();
            Octombrie.MdiParent = this;
            Octombrie.Show();
        }

        private void bibliografieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bibliografie = new frmBibliografie();
            Bibliografie.MdiParent = this;
            Bibliografie.Show();
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Background = new frmBackground();
            Background.MdiParent = this;
            Background.Show();
        }
    }
}