namespace Revolutia_Rusa
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUser = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.buttonInregistrare = new System.Windows.Forms.Button();
            this.buttonlOGIN = new System.Windows.Forms.Button();
            this.closeLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUser.Location = new System.Drawing.Point(210, 68);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(280, 55);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Nume utilizator";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUser.Location = new System.Drawing.Point(229, 126);
            this.textBoxUser.Multiline = true;
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(234, 36);
            this.textBoxUser.TabIndex = 1;
            this.textBoxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblParola
            // 
            this.lblParola.BackColor = System.Drawing.Color.Transparent;
            this.lblParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblParola.Location = new System.Drawing.Point(210, 205);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(280, 55);
            this.lblParola.TabIndex = 2;
            this.lblParola.Text = "Parola";
            this.lblParola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxParola.Location = new System.Drawing.Point(229, 263);
            this.textBoxParola.Multiline = true;
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.PasswordChar = '•';
            this.textBoxParola.Size = new System.Drawing.Size(234, 36);
            this.textBoxParola.TabIndex = 3;
            this.textBoxParola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonInregistrare
            // 
            this.buttonInregistrare.Location = new System.Drawing.Point(401, 317);
            this.buttonInregistrare.Name = "buttonInregistrare";
            this.buttonInregistrare.Size = new System.Drawing.Size(112, 39);
            this.buttonInregistrare.TabIndex = 4;
            this.buttonInregistrare.Text = "Înregistrare";
            this.buttonInregistrare.UseVisualStyleBackColor = true;
            this.buttonInregistrare.Click += new System.EventHandler(this.buttonInregistrare_Click);
            // 
            // buttonlOGIN
            // 
            this.buttonlOGIN.Location = new System.Drawing.Point(186, 317);
            this.buttonlOGIN.Name = "buttonlOGIN";
            this.buttonlOGIN.Size = new System.Drawing.Size(112, 39);
            this.buttonlOGIN.TabIndex = 4;
            this.buttonlOGIN.Text = "Conectare";
            this.buttonlOGIN.UseVisualStyleBackColor = true;
            this.buttonlOGIN.Click += new System.EventHandler(this.buttonlOGIN_Click);
            // 
            // closeLogin
            // 
            this.closeLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeLogin.BackColor = System.Drawing.Color.White;
            this.closeLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeLogin.BackgroundImage")));
            this.closeLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeLogin.Location = new System.Drawing.Point(643, 11);
            this.closeLogin.Name = "closeLogin";
            this.closeLogin.Size = new System.Drawing.Size(33, 30);
            this.closeLogin.TabIndex = 19;
            this.closeLogin.UseVisualStyleBackColor = false;
            this.closeLogin.Click += new System.EventHandler(this.closeLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 502);
            this.Controls.Add(this.closeLogin);
            this.Controls.Add(this.buttonlOGIN);
            this.Controls.Add(this.buttonInregistrare);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.lblUser);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLectii_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLectii_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox textBoxUser;
        public System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Button buttonInregistrare;
        private System.Windows.Forms.Button buttonlOGIN;
        private System.Windows.Forms.Button closeLogin;
    }
}