namespace Revolutia_Rusa
{
    partial class frmImaginiInstructiuni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImaginiInstructiuni));
            this.closeInstructiuniGalerie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeInstructiuniGalerie
            // 
            this.closeInstructiuniGalerie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeInstructiuniGalerie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeInstructiuniGalerie.BackgroundImage")));
            this.closeInstructiuniGalerie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeInstructiuniGalerie.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeInstructiuniGalerie.Location = new System.Drawing.Point(466, 7);
            this.closeInstructiuniGalerie.Name = "closeInstructiuniGalerie";
            this.closeInstructiuniGalerie.Size = new System.Drawing.Size(33, 30);
            this.closeInstructiuniGalerie.TabIndex = 19;
            this.closeInstructiuniGalerie.UseVisualStyleBackColor = true;
            this.closeInstructiuniGalerie.Click += new System.EventHandler(this.closeInstructiuniGalerie_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 306);
            this.label1.TabIndex = 20;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLectii_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLectii_MouseMove);
            // 
            // frmImaginiInstructiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(508, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeInstructiuniGalerie);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmImaginiInstructiuni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGalerieInstructiuni";
            this.Load += new System.EventHandler(this.frmImaginiInstructiuni_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLectii_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLectii_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeInstructiuniGalerie;
        public System.Windows.Forms.Label label1;
    }
}