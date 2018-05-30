using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Revolutia_Rusa
{
    public partial class frmTest : Form
    {

        frmTest Test;
        frmLogin Login = null;

        public string nume;
        public int IDIntrebare = 1, vieti = 3, punctaj = 0;
        public string[] intrebare = new String[100];
        public string[] var_a = new String[100];
        public string[] var_b = new String[100];
        public string[] var_c = new String[100];
        public string[] corect = new String[100];
        public string[] ales = new String[100];
        public frmTest()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            if (variabile.background == 1)
            {
                pnlTest.BackgroundImage = new Bitmap("backgrounds\\panouh.png");
                radioButton1.ForeColor = Color.Black;
                radioButton2.ForeColor = Color.Black;
                radioButton3.ForeColor = Color.Black;
                lblIntrebare.ForeColor = Color.Black;
                lblName.ForeColor = Color.Black;
            }
            else if (variabile.background == 2)
            {
                pnlTest.BackgroundImage = new Bitmap("backgrounds\\black-wood-wallpaper.jpg");
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
                radioButton3.ForeColor = Color.White;
                lblIntrebare.ForeColor = Color.White;
                lblName.ForeColor = Color.White;
            }

            IDIntrebare = 1;
                nume = variabile.NumeUtilizator;
                pnlTest.Visible = true;
                pnlTest.Location = new Point(0, 0);
                lblName.Text = nume;
                vieti = 3;
                punctaj = 0;
                int i;

                for (i = 1; i <= 10; i++)
                {
                    (pnlTest.Controls["bulina" + i.ToString()] as PictureBox).BackgroundImage = new Bitmap("Game\\bulina_transparenta.png");
                }

                heart1.BackgroundImage = new Bitmap("Game\\heart.png");
                heart2.BackgroundImage = new Bitmap("Game\\heart.png");
                heart3.BackgroundImage = new Bitmap("Game\\heart.png");

                heart1.Visible = true;
                heart2.Visible = true;
                heart3.Visible = true;

               (pnlTest.Controls["bulina" + IDIntrebare.ToString()] as PictureBox).BackgroundImage = new Bitmap("Game\\bulina_gri.png");

                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Soft.accdb";
                con.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT TOP 10 * FROM Test ORDER BY rnd(id)";

                OleDbDataReader r = cmd.ExecuteReader();

                i = 1;

                while (r.Read())
                {
                    intrebare[i] = r["intrebare"].ToString();
                    var_a[i] = r["varianta_a"].ToString();
                    var_b[i] = r["varianta_b"].ToString();
                    var_c[i] = r["varianta_c"].ToString();
                    corect[i] = r["corect"].ToString();
                    i++;
                }

                lblIntrebare.Text = intrebare[IDIntrebare];
                radioButton1.Text = var_a[IDIntrebare];
                radioButton2.Text = var_b[IDIntrebare];
                radioButton3.Text = var_c[IDIntrebare];
           
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ales[IDIntrebare] = "a";
           // ales[IDIntrebare+1] = "a";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ales[IDIntrebare] = "b";
         //   ales[IDIntrebare+1] = "b";
        }

        private void frmTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.MdiParent as frmMain).Test = null;
            variabile.NotLoggedIn = "none";
        }

        private void lblIntrebare_Click(object sender, EventArgs e)
        {

        }

        private void pnlTest_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bulina10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ales[IDIntrebare] = "c";
          //  ales[IDIntrebare+1] = "c";
        }

        private void buttonContinua_Click(object sender, EventArgs e)
        {
         if(corect[IDIntrebare] == ales[IDIntrebare])
            {
                (pnlTest.Controls["bulina" + IDIntrebare.ToString()] as PictureBox).BackgroundImage = new Bitmap("Game\\bulina_verde.png");
                punctaj++;
                IDIntrebare++;
                if (IDIntrebare == 11)
                {
                    MessageBox.Show("Felicitări, ai câştigat! Punctaj: " + punctaj.ToString(), "", MessageBoxButtons.OK);
                    if (MessageBox.Show("Vrei să joci din nou?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frmTest_Load(sender, e);
                        //this.Close();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    lblIntrebare.Text = intrebare[IDIntrebare];
                    radioButton1.Text = var_a[IDIntrebare];
                    radioButton2.Text = var_b[IDIntrebare];
                    radioButton3.Text = var_c[IDIntrebare];
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    (pnlTest.Controls["bulina" + IDIntrebare.ToString()] as PictureBox).BackgroundImage = new Bitmap("Game\\bulina_gri.png");
                }
            }
         else
            {
                (pnlTest.Controls["bulina" + IDIntrebare.ToString()] as PictureBox).BackgroundImage = new Bitmap("Game\\bulina_rosie.png");
                (pnlTest.Controls["heart" + vieti.ToString()] as PictureBox).Visible = false;
                vieti--;
                if(vieti == 0)
                {
                    MessageBox.Show("Ai pierdut! Punctaj: " + punctaj.ToString(),"", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if(MessageBox.Show("Vrei să joci din nou?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frmTest_Load(sender, e);
                        //this.Close();
                    }
                    else
                    {
                        this.Close();
                    }


                }
                else
                {
                    IDIntrebare++;
                    if (IDIntrebare == 11)
                    {
                        MessageBox.Show("Felicitări, ai câştigat! Punctaj: " + punctaj.ToString(), "", MessageBoxButtons.OK);
                        if (MessageBox.Show("Vrei să joci din nou?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.Close();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        lblIntrebare.Text = intrebare[IDIntrebare];
                        radioButton1.Text = var_a[IDIntrebare];
                        radioButton2.Text = var_b[IDIntrebare];
                        radioButton3.Text = var_c[IDIntrebare];
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        (pnlTest.Controls["bulina" + IDIntrebare.ToString()] as PictureBox).BackgroundImage = new Bitmap("Game\\bulina_gri.png");
                    }

                }
            }
        }
    }
}
