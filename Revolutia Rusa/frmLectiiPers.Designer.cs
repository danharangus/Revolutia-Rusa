namespace Revolutia_Rusa
{
    partial class frmLectiiPers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLectiiPers));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lectiiLeft = new System.Windows.Forms.PictureBox();
            this.lectiiRight = new System.Windows.Forms.PictureBox();
            this.lblLectiiPers = new System.Windows.Forms.Label();
            this.closeLectii = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectiiLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectiiRight)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(25, 115);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(436, 436);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "         ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(553, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 224);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lectiiLeft
            // 
            this.lectiiLeft.BackColor = System.Drawing.Color.Transparent;
            this.lectiiLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lectiiLeft.BackgroundImage")));
            this.lectiiLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lectiiLeft.Location = new System.Drawing.Point(506, 207);
            this.lectiiLeft.Name = "lectiiLeft";
            this.lectiiLeft.Size = new System.Drawing.Size(41, 34);
            this.lectiiLeft.TabIndex = 2;
            this.lectiiLeft.TabStop = false;
            this.lectiiLeft.Click += new System.EventHandler(this.lectiiLeft_Click);
            // 
            // lectiiRight
            // 
            this.lectiiRight.BackColor = System.Drawing.Color.Transparent;
            this.lectiiRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lectiiRight.BackgroundImage")));
            this.lectiiRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lectiiRight.Location = new System.Drawing.Point(817, 207);
            this.lectiiRight.Name = "lectiiRight";
            this.lectiiRight.Size = new System.Drawing.Size(41, 34);
            this.lectiiRight.TabIndex = 3;
            this.lectiiRight.TabStop = false;
            this.lectiiRight.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblLectiiPers
            // 
            this.lblLectiiPers.BackColor = System.Drawing.Color.Transparent;
            this.lblLectiiPers.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectiiPers.Location = new System.Drawing.Point(89, 9);
            this.lblLectiiPers.Name = "lblLectiiPers";
            this.lblLectiiPers.Size = new System.Drawing.Size(694, 77);
            this.lblLectiiPers.TabIndex = 4;
            this.lblLectiiPers.Text = "Vladimir Ilici Lenin";
            // 
            // closeLectii
            // 
            this.closeLectii.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeLectii.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeLectii.BackgroundImage")));
            this.closeLectii.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeLectii.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeLectii.Location = new System.Drawing.Point(833, 14);
            this.closeLectii.Name = "closeLectii";
            this.closeLectii.Size = new System.Drawing.Size(33, 30);
            this.closeLectii.TabIndex = 18;
            this.closeLectii.UseVisualStyleBackColor = true;
            this.closeLectii.Click += new System.EventHandler(this.closeLectii_Click);
            // 
            // frmLectiiPers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 621);
            this.Controls.Add(this.closeLectii);
            this.Controls.Add(this.lblLectiiPers);
            this.Controls.Add(this.lectiiRight);
            this.Controls.Add(this.lectiiLeft);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(883, 621);
            this.Name = "frmLectiiPers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLectiiPers_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLectii_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLectii_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectiiLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectiiRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox lectiiLeft;
        private System.Windows.Forms.PictureBox lectiiRight;
        public System.Windows.Forms.Label lblLectiiPers;
        private System.Windows.Forms.Button closeLectii;
    }
}