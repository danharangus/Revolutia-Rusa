namespace Revolutia_Rusa
{
    partial class FrmIulie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIulie));
            this.textIulie = new System.Windows.Forms.TextBox();
            this.closeIanuarie = new System.Windows.Forms.Button();
            this.lblLectii = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textIulie
            // 
            this.textIulie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textIulie.Location = new System.Drawing.Point(25, 115);
            this.textIulie.Multiline = true;
            this.textIulie.Name = "textIulie";
            this.textIulie.ReadOnly = true;
            this.textIulie.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textIulie.Size = new System.Drawing.Size(436, 436);
            this.textIulie.TabIndex = 1;
            this.textIulie.Text = resources.GetString("textIulie.Text");
            // 
            // closeIanuarie
            // 
            this.closeIanuarie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeIanuarie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeIanuarie.BackgroundImage")));
            this.closeIanuarie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeIanuarie.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeIanuarie.Location = new System.Drawing.Point(833, 14);
            this.closeIanuarie.Name = "closeIanuarie";
            this.closeIanuarie.Size = new System.Drawing.Size(33, 30);
            this.closeIanuarie.TabIndex = 19;
            this.closeIanuarie.UseVisualStyleBackColor = true;
            this.closeIanuarie.Click += new System.EventHandler(this.closeIanuarie_Click);
            // 
            // lblLectii
            // 
            this.lblLectii.BackColor = System.Drawing.Color.Transparent;
            this.lblLectii.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectii.Location = new System.Drawing.Point(70, 14);
            this.lblLectii.Name = "lblLectii";
            this.lblLectii.Size = new System.Drawing.Size(694, 77);
            this.lblLectii.TabIndex = 21;
            this.lblLectii.Text = "Iulie 1917";
            this.lblLectii.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(553, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 224);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // FrmIulie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 621);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLectii);
            this.Controls.Add(this.closeIanuarie);
            this.Controls.Add(this.textIulie);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIulie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIanuarie";
            this.Load += new System.EventHandler(this.FrmIulie_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmIanuarie_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmIanuarie_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textIulie;
        private System.Windows.Forms.Button closeIanuarie;
        public System.Windows.Forms.Label lblLectii;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}