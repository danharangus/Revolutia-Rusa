using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revolutia_Rusa
{
    public partial class frmJocImagini : Form
    {
        public frmJocImagini()
        {
            InitializeComponent();
        }

        public frmImaginiInstructiuni PersonalitatiInstructiuni = null;

        private void selectPersonalitati()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();
            comboBox7.Items.Clear();
            comboBox8.Items.Clear();

            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=JocPersonalitati.accdb";
            con.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT DISTINCT personalitate FROM nume";

            OleDbDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                comboBox1.Items.Add(r["personalitate"].ToString());
                comboBox2.Items.Add(r["personalitate"].ToString());
                comboBox3.Items.Add(r["personalitate"].ToString());
                comboBox4.Items.Add(r["personalitate"].ToString());
                comboBox5.Items.Add(r["personalitate"].ToString());
                comboBox6.Items.Add(r["personalitate"].ToString());
                comboBox7.Items.Add(r["personalitate"].ToString());
                comboBox8.Items.Add(r["personalitate"].ToString());
            }

            r.Close();
            con.Close();

        }

        private void frmPersonalitati_FormClosed(object sender, FormClosedEventArgs e)
        {
           (this.MdiParent as frmMain).JocPersonalitati = null;
            variabile.NotLoggedIn = "none";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPersonalitati_Load(object sender, EventArgs e)
        {
            selectPersonalitati();
            lblNume.Text = variabile.NumeUtilizator;
            if (variabile.background == 1)
            {
                this.BackgroundImage = new Bitmap("backgrounds\\panouh.png");
                lblNume.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
            }
            else if (variabile.background == 2)
            {
                this.BackgroundImage = new Bitmap("backgrounds\\black-wood-wallpaper.jpg");
                lblNume.ForeColor = Color.White;
                label1.ForeColor = Color.White;
            }
        }

        private void closePersonalitati_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerificarePersonalitati_Click(object sender, EventArgs e)
        {
            int corecte = 0;

            if(comboBox1.Text == "Vladimir Ilici Lenin")
            {
                corecte++;
            }

            if (comboBox2.Text == "Nicolae al II-lea")
            {
                corecte++;
            }

            if (comboBox3.Text == "Aleksandr Kerenski")
            {
                corecte++;
            }

            if (comboBox4.Text == "Iosif Vissarionovici Stalin")
            {
                corecte++;
            }

            if (comboBox5.Text == "Steagul URSS")
            {
                corecte++;
            }
            if (comboBox6.Text == "Steagul actual al Rusiei")
            {
                corecte++;
            }
            if (comboBox7.Text == "Steagul Republicii Sovietice Federative Socialiste Ruse")
            {
                corecte++;
            }
            if (comboBox8.Text == "Stema Rusiei")
            {
                corecte++;
            }

            if (corecte == 8)
            {
                MessageBox.Show("Felicitări! Ai obținut punctajul maxim!");
            }
            else
            {
                if (MessageBox.Show("Nu ai obținut punctajul maxim. Vrei să continui să joci?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    if (comboBox1.Text == "Vladimir Ilici Lenin")
                    {
                        pb1Corect.Visible = true;
                    }
                    else
                    {
                        pb1Gresit.Visible = true;
                        
                    }

                    if (comboBox2.Text == "Nicolae al II-lea")
                    {
                        pb2Corect.Visible = true;
                    }
                    else
                    {
                        pb2Gresit.Visible = true;
                    }

                    if (comboBox3.Text == "Aleksandr Kerenski")
                    {
                        pb3Corect.Visible = true;
                    }
                    else
                    {
                        pb3Gresit.Visible = true;
                    }

                    if (comboBox4.Text == "Iosif Vissarionovici Stalin")
                    {
                        pb4Corect.Visible = true;
                    }
                    else
                    {
                        pb4Gresit.Visible = true;
                    }

                    if (comboBox5.Text == "Steagul URSS")
                    {
                        pb5Corect.Visible = true;
                    }
                    else
                    {
                        pb5Gresit.Visible = true;
                    }
                    if (comboBox6.Text == "Steagul actual al Rusiei")
                    {
                        pb6Corect.Visible = true;
                    }
                    else
                    {
                        pb6Gresit.Visible = true;
                    }
                    if (comboBox7.Text == "Steagul Republicii Sovietice Federative Socialiste Ruse")
                    {
                        pb7Corect.Visible = true;
                    }
                    else
                    {
                        pb7Gresit.Visible = true;
                    }
                    if (comboBox8.Text == "Stema Rusiei")
                    {
                        pb8Corect.Visible = true;
                    }
                    else
                    {
                        pb8Gresit.Visible = true;
                    }
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                    comboBox6.Enabled = false;
                    comboBox7.Enabled = false;
                    comboBox8.Enabled = false;
                }
            }

        }

        private void instrucțiuniToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            PersonalitatiInstructiuni = new frmImaginiInstructiuni();
            PersonalitatiInstructiuni.MdiParent = this.MdiParent;
            PersonalitatiInstructiuni.Show();
        }
    }
}
