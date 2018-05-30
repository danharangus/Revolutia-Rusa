namespace Revolutia_Rusa
{
    partial class FrmOctombrie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOctombrie));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.closeOctombrie = new System.Windows.Forms.Button();
            this.lblLectii = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lectiiLeft = new System.Windows.Forms.PictureBox();
            this.lectiiRight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectiiLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectiiRight)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(25, 115);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(436, 436);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // closeOctombrie
            // 
            this.closeOctombrie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeOctombrie.BackColor = System.Drawing.Color.White;
            this.closeOctombrie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeOctombrie.BackgroundImage")));
            this.closeOctombrie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeOctombrie.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeOctombrie.Location = new System.Drawing.Point(834, 14);
            this.closeOctombrie.Name = "closeOctombrie";
            this.closeOctombrie.Size = new System.Drawing.Size(33, 30);
            this.closeOctombrie.TabIndex = 19;
            this.closeOctombrie.UseVisualStyleBackColor = false;
            this.closeOctombrie.Click += new System.EventHandler(this.closeOctombrie_Click);
            // 
            // lblLectii
            // 
            this.lblLectii.BackColor = System.Drawing.Color.Transparent;
            this.lblLectii.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectii.Location = new System.Drawing.Point(70, 14);
            this.lblLectii.Name = "lblLectii";
            this.lblLectii.Size = new System.Drawing.Size(694, 77);
            this.lblLectii.TabIndex = 22;
            this.lblLectii.Text = "Octombrie 1917";
            this.lblLectii.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(553, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 224);
            this.pictureBox1.TabIndex = 23;
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
            this.lectiiLeft.TabIndex = 24;
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
            this.lectiiRight.TabIndex = 25;
            this.lectiiRight.TabStop = false;
            this.lectiiRight.Click += new System.EventHandler(this.lectiiRight_Click);
            // 
            // FrmOctombrie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 621);
            this.Controls.Add(this.lectiiRight);
            this.Controls.Add(this.lectiiLeft);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLectii);
            this.Controls.Add(this.closeOctombrie);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOctombrie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOctombrie";
            this.Load += new System.EventHandler(this.FrmOctombrie_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmOctombrie_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmOctombrie_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectiiLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectiiRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button closeOctombrie;
        public System.Windows.Forms.Label lblLectii;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox lectiiLeft;
        private System.Windows.Forms.PictureBox lectiiRight;
    }
}