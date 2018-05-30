namespace Revolutia_Rusa
{
    partial class FrmFebruarie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFebruarie));
            this.textFebruarie = new System.Windows.Forms.TextBox();
            this.closeFebruarie = new System.Windows.Forms.Button();
            this.lblLectii = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lectiiLeft = new System.Windows.Forms.PictureBox();
            this.lectiiRight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectiiLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectiiRight)).BeginInit();
            this.SuspendLayout();
            // 
            // textFebruarie
            // 
            this.textFebruarie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textFebruarie.Location = new System.Drawing.Point(25, 115);
            this.textFebruarie.Multiline = true;
            this.textFebruarie.Name = "textFebruarie";
            this.textFebruarie.ReadOnly = true;
            this.textFebruarie.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textFebruarie.Size = new System.Drawing.Size(436, 436);
            this.textFebruarie.TabIndex = 2;
            this.textFebruarie.Text = resources.GetString("textFebruarie.Text");
            // 
            // closeFebruarie
            // 
            this.closeFebruarie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeFebruarie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeFebruarie.BackgroundImage")));
            this.closeFebruarie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeFebruarie.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeFebruarie.Location = new System.Drawing.Point(838, 12);
            this.closeFebruarie.Name = "closeFebruarie";
            this.closeFebruarie.Size = new System.Drawing.Size(33, 30);
            this.closeFebruarie.TabIndex = 19;
            this.closeFebruarie.UseVisualStyleBackColor = true;
            this.closeFebruarie.Click += new System.EventHandler(this.closeFebruarie_Click);
            // 
            // lblLectii
            // 
            this.lblLectii.BackColor = System.Drawing.Color.Transparent;
            this.lblLectii.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectii.Location = new System.Drawing.Point(70, 14);
            this.lblLectii.Name = "lblLectii";
            this.lblLectii.Size = new System.Drawing.Size(694, 77);
            this.lblLectii.TabIndex = 20;
            this.lblLectii.Text = "Februarie 1917";
            this.lblLectii.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLectii.Click += new System.EventHandler(this.lblLectii_Click);
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
            // FrmFebruarie
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
            this.Controls.Add(this.closeFebruarie);
            this.Controls.Add(this.textFebruarie);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFebruarie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFebruarie";
            this.Load += new System.EventHandler(this.FrmFebruarie_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmFebruerie_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmFebruarie_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectiiLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectiiRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFebruarie;
        private System.Windows.Forms.Button closeFebruarie;
        public System.Windows.Forms.Label lblLectii;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox lectiiLeft;
        private System.Windows.Forms.PictureBox lectiiRight;
    }
}