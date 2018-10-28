namespace ROMS
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.pnltitlebar = new System.Windows.Forms.Panel();
            this.bimbtnexit = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlstatusbar = new System.Windows.Forms.Panel();
            this.pnlmain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnltitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bimbtnexit)).BeginInit();
            this.pnlmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltitlebar
            // 
            this.pnltitlebar.Controls.Add(this.bimbtnexit);
            this.pnltitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltitlebar.Location = new System.Drawing.Point(0, 0);
            this.pnltitlebar.Name = "pnltitlebar";
            this.pnltitlebar.Size = new System.Drawing.Size(1184, 65);
            this.pnltitlebar.TabIndex = 0;
            // 
            // bimbtnexit
            // 
            this.bimbtnexit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bimbtnexit.Image = ((System.Drawing.Image)(resources.GetObject("bimbtnexit.Image")));
            this.bimbtnexit.ImageActive = null;
            this.bimbtnexit.Location = new System.Drawing.Point(1117, 1);
            this.bimbtnexit.Name = "bimbtnexit";
            this.bimbtnexit.Size = new System.Drawing.Size(64, 64);
            this.bimbtnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bimbtnexit.TabIndex = 0;
            this.bimbtnexit.TabStop = false;
            this.bimbtnexit.Zoom = 10;
            // 
            // pnlstatusbar
            // 
            this.pnlstatusbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlstatusbar.Location = new System.Drawing.Point(0, 629);
            this.pnlstatusbar.Name = "pnlstatusbar";
            this.pnlstatusbar.Size = new System.Drawing.Size(1184, 52);
            this.pnlstatusbar.TabIndex = 1;
            // 
            // pnlmain
            // 
            this.pnlmain.Controls.Add(this.label1);
            this.pnlmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlmain.Location = new System.Drawing.Point(0, 65);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(1184, 564);
            this.pnlmain.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.pnlmain);
            this.Controls.Add(this.pnlstatusbar);
            this.Controls.Add(this.pnltitlebar);
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnltitlebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bimbtnexit)).EndInit();
            this.pnlmain.ResumeLayout(false);
            this.pnlmain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltitlebar;
        private System.Windows.Forms.Panel pnlstatusbar;
        private System.Windows.Forms.Panel pnlmain;
        private Bunifu.Framework.UI.BunifuImageButton bimbtnexit;
        private System.Windows.Forms.Label label1;
    }
}

