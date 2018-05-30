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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void Register(string username, string password)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Accounts.accdb";
            con.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO Conturi(utilizator, parola) values (@utilizator, @parola)";
            cmd.Parameters.AddWithValue("utilizator", username);
            cmd.Parameters.AddWithValue("parola", password);

            int cate = cmd.ExecuteNonQuery();
            if (cate > 0 && textBoxUser.Text != "" && textBoxParola.Text != "")
            {
                MessageBox.Show("Te-ai înregistrat cu succes!");
                variabile.NumeUtilizator = username;
                variabile.logat = 1;

                if (variabile.NotLoggedIn == "Test")
                {
                    (this.MdiParent as frmMain).Test = new frmTest();
                    (this.MdiParent as frmMain).Test.Show();
                    (this.MdiParent as frmMain).Test.MdiParent = this.MdiParent;
                    Close();
                }
                else if (variabile.NotLoggedIn == "Personalitati")
                {
                    (this.MdiParent as frmMain).JocPersonalitati = new frmJocImagini();
                    (this.MdiParent as frmMain).JocPersonalitati.Show();
                    (this.MdiParent as frmMain).JocPersonalitati.MdiParent = this.MdiParent;
                    Close();
                }
                else if (variabile.NotLoggedIn == "none")
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Pentru a va inregistra, trebuie sa introduce-ti un nume de utilizator si o parola.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxParola.Text = "";
                textBoxUser.Text = "";
            }

            con.Close();

        }

        private bool Check(string username, string password)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Accounts.accdb";
            con.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Conturi WHERE utilizator = @utilizator and parola = @parola";
            cmd.Parameters.AddWithValue("utilizator", username);
            cmd.Parameters.AddWithValue("parola", password);

            OleDbDataReader r = cmd.ExecuteReader();

            if (r.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
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

        private void buttonInregistrare_Click(object sender, EventArgs e)
        {
            Register(textBoxUser.Text, textBoxParola.Text);
        }

        private void buttonlOGIN_Click(object sender, EventArgs e)
        {
            if (Check(textBoxUser.Text, textBoxParola.Text) == true && textBoxUser.Text != "" && textBoxParola.Text != "")
            {
                MessageBox.Show("Te-ai conectat cu succes!", "", MessageBoxButtons.OK);
                variabile.logat = 1;
                variabile.NumeUtilizator = textBoxUser.Text;

                if (variabile.NotLoggedIn == "Test")
                {
                    (this.MdiParent as frmMain).Test = new frmTest();
                    (this.MdiParent as frmMain).Test.Show();
                    (this.MdiParent as frmMain).Test.MdiParent = this.MdiParent;
                    Close();
                } 
                else if(variabile.NotLoggedIn == "Personalitati")
                {
                    (this.MdiParent as frmMain).JocPersonalitati = new frmJocImagini();
                    (this.MdiParent as frmMain).JocPersonalitati.Show();
                    (this.MdiParent as frmMain).JocPersonalitati.MdiParent = this.MdiParent;
                    Close();
                }
                else if(variabile.NotLoggedIn == "none")
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Numele sau parola greșită.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxParola.Text = "";
                textBoxUser.Text = "";
            }
        }

        private void closeLogin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (variabile.background == 1)
            {
                this.BackgroundImage = new Bitmap("backgrounds\\panouh.png");
                lblParola.ForeColor = Color.Black;
                lblUser.ForeColor = Color.Black;
            }
            else if (variabile.background == 2)
            {
                this.BackgroundImage = new Bitmap("backgrounds\\black-wood-wallpaper.jpg");
                lblParola.ForeColor = Color.White;
                lblUser.ForeColor = Color.White;
            }
        }
    }
}
