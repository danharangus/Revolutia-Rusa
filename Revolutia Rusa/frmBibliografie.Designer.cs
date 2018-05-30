namespace Revolutia_Rusa
{
    partial class frmBibliografie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBibliografie));
            this.closeFebruarie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeFebruarie
            // 
            this.closeFebruarie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeFebruarie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeFebruarie.BackgroundImage")));
            this.closeFebruarie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeFebruarie.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeFebruarie.Location = new System.Drawing.Point(789, 10);
            this.closeFebruarie.Name = "closeFebruarie";
            this.closeFebruarie.Size = new System.Drawing.Size(33, 30);
            this.closeFebruarie.TabIndex = 20;
            this.closeFebruarie.UseVisualStyleBackColor = true;
            this.closeFebruarie.Click += new System.EventHandler(this.closeBibliografie_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(759, 512);
            this.label1.TabIndex = 21;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // frmBibliografie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 566);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeFebruarie);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBibliografie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmBibliografie_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmBibliografie_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmBibliografie_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeFebruarie;
        public System.Windows.Forms.Label label1;
    }
}