namespace Revolutia_Rusa
{
    partial class frmBackground
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackground));
            this.closeBackground = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bg1Selected = new System.Windows.Forms.PictureBox();
            this.bg2Selected = new System.Windows.Forms.PictureBox();
            this.lblBackground = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg1Selected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2Selected)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBackground
            // 
            this.closeBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBackground.BackgroundImage")));
            this.closeBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBackground.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBackground.Location = new System.Drawing.Point(762, 12);
            this.closeBackground.Name = "closeBackground";
            this.closeBackground.Size = new System.Drawing.Size(33, 30);
            this.closeBackground.TabIndex = 19;
            this.closeBackground.UseVisualStyleBackColor = true;
            this.closeBackground.Click += new System.EventHandler(this.closeBackground_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(533, 201);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 155);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(35, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 155);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bg1Selected
            // 
            this.bg1Selected.BackColor = System.Drawing.Color.Transparent;
            this.bg1Selected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bg1Selected.BackgroundImage")));
            this.bg1Selected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bg1Selected.Location = new System.Drawing.Point(143, 362);
            this.bg1Selected.Name = "bg1Selected";
            this.bg1Selected.Size = new System.Drawing.Size(25, 20);
            this.bg1Selected.TabIndex = 25;
            this.bg1Selected.TabStop = false;
            this.bg1Selected.Visible = false;
            // 
            // bg2Selected
            // 
            this.bg2Selected.BackColor = System.Drawing.Color.Transparent;
            this.bg2Selected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bg2Selected.BackgroundImage")));
            this.bg2Selected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bg2Selected.Location = new System.Drawing.Point(652, 362);
            this.bg2Selected.Name = "bg2Selected";
            this.bg2Selected.Size = new System.Drawing.Size(25, 20);
            this.bg2Selected.TabIndex = 26;
            this.bg2Selected.TabStop = false;
            this.bg2Selected.Visible = false;
            // 
            // lblBackground
            // 
            this.lblBackground.BackColor = System.Drawing.Color.Transparent;
            this.lblBackground.Font = new System.Drawing.Font("Lucida Bright", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackground.ForeColor = System.Drawing.Color.Black;
            this.lblBackground.Location = new System.Drawing.Point(37, 64);
            this.lblBackground.Name = "lblBackground";
            this.lblBackground.Size = new System.Drawing.Size(749, 77);
            this.lblBackground.TabIndex = 27;
            this.lblBackground.Text = "Selectează background-ul";
            this.lblBackground.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 536);
            this.Controls.Add(this.lblBackground);
            this.Controls.Add(this.bg2Selected);
            this.Controls.Add(this.bg1Selected);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.closeBackground);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBackground";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBackground";
            this.Load += new System.EventHandler(this.frmBackground_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmTest_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmTest_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg1Selected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2Selected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeBackground;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox bg1Selected;
        private System.Windows.Forms.PictureBox bg2Selected;
        public System.Windows.Forms.Label lblBackground;
    }
}