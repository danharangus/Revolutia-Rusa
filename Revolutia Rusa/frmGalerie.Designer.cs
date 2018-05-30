namespace Revolutia_Rusa
{
    partial class frmGalerie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGalerie));
            this.closeGalerie = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblgalerie = new System.Windows.Forms.Label();
            this.GalerieRight = new System.Windows.Forms.PictureBox();
            this.GalerieLeft = new System.Windows.Forms.PictureBox();
            this.pbPnl1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GalerieRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GalerieLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPnl1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeGalerie
            // 
            this.closeGalerie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeGalerie.BackColor = System.Drawing.Color.White;
            this.closeGalerie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeGalerie.BackgroundImage")));
            this.closeGalerie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeGalerie.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeGalerie.Location = new System.Drawing.Point(788, 13);
            this.closeGalerie.Name = "closeGalerie";
            this.closeGalerie.Size = new System.Drawing.Size(33, 30);
            this.closeGalerie.TabIndex = 20;
            this.closeGalerie.UseVisualStyleBackColor = false;
            this.closeGalerie.Click += new System.EventHandler(this.closeGalerie_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblgalerie);
            this.panel1.Controls.Add(this.GalerieRight);
            this.panel1.Controls.Add(this.GalerieLeft);
            this.panel1.Controls.Add(this.pbPnl1);
            this.panel1.Location = new System.Drawing.Point(45, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 504);
            this.panel1.TabIndex = 21;
            // 
            // lblgalerie
            // 
            this.lblgalerie.Font = new System.Drawing.Font("Old English Text MT", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgalerie.Location = new System.Drawing.Point(47, 455);
            this.lblgalerie.Name = "lblgalerie";
            this.lblgalerie.Size = new System.Drawing.Size(647, 42);
            this.lblgalerie.TabIndex = 5;
            this.lblgalerie.Text = "Razboiul Civil din Rusia";
            this.lblgalerie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblgalerie.Click += new System.EventHandler(this.lblgalerie_Click);
            // 
            // GalerieRight
            // 
            this.GalerieRight.BackColor = System.Drawing.Color.Transparent;
            this.GalerieRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GalerieRight.BackgroundImage")));
            this.GalerieRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GalerieRight.Location = new System.Drawing.Point(700, 195);
            this.GalerieRight.Name = "GalerieRight";
            this.GalerieRight.Size = new System.Drawing.Size(41, 34);
            this.GalerieRight.TabIndex = 4;
            this.GalerieRight.TabStop = false;
            this.GalerieRight.Click += new System.EventHandler(this.GalerieRight_Click);
            // 
            // GalerieLeft
            // 
            this.GalerieLeft.BackColor = System.Drawing.Color.Transparent;
            this.GalerieLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GalerieLeft.BackgroundImage")));
            this.GalerieLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GalerieLeft.Location = new System.Drawing.Point(0, 195);
            this.GalerieLeft.Name = "GalerieLeft";
            this.GalerieLeft.Size = new System.Drawing.Size(41, 34);
            this.GalerieLeft.TabIndex = 3;
            this.GalerieLeft.TabStop = false;
            this.GalerieLeft.Click += new System.EventHandler(this.GalerieLeft_Click);
            // 
            // pbPnl1
            // 
            this.pbPnl1.Image = ((System.Drawing.Image)(resources.GetObject("pbPnl1.Image")));
            this.pbPnl1.Location = new System.Drawing.Point(47, 29);
            this.pbPnl1.Name = "pbPnl1";
            this.pbPnl1.Size = new System.Drawing.Size(647, 420);
            this.pbPnl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPnl1.TabIndex = 0;
            this.pbPnl1.TabStop = false;
            // 
            // frmGalerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeGalerie);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGalerie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGalerie";
            this.Load += new System.EventHandler(this.frmGalerie_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLectii_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLectii_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GalerieRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GalerieLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPnl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeGalerie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbPnl1;
        private System.Windows.Forms.PictureBox GalerieLeft;
        private System.Windows.Forms.PictureBox GalerieRight;
        public System.Windows.Forms.Label lblgalerie;
    }
}