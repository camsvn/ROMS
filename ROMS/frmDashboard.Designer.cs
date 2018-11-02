namespace ROMS
{
    partial class frmDashboard
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
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblApplicationTitle = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblCopyrights = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlDashBoard = new System.Windows.Forms.Panel();
            this.btbtnOrder = new Bunifu.Framework.UI.BunifuTileButton();
            this.btbtnKot = new Bunifu.Framework.UI.BunifuTileButton();
            this.btbtnBilling = new Bunifu.Framework.UI.BunifuTileButton();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.bimbtnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.pnlDateTime = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlDashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimbtnExit)).BeginInit();
            this.pnlDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.pbLogo);
            this.pnlTop.Controls.Add(this.lblApplicationTitle);
            this.pnlTop.Controls.Add(this.bimbtnExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1568, 100);
            this.pnlTop.TabIndex = 29;
            // 
            // lblApplicationTitle
            // 
            this.lblApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApplicationTitle.AutoSize = true;
            this.lblApplicationTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationTitle.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationTitle.ForeColor = System.Drawing.Color.White;
            this.lblApplicationTitle.Location = new System.Drawing.Point(67, 23);
            this.lblApplicationTitle.Name = "lblApplicationTitle";
            this.lblApplicationTitle.Size = new System.Drawing.Size(927, 58);
            this.lblApplicationTitle.TabIndex = 32;
            this.lblApplicationTitle.Text = "Restaurant Order Management System";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.pnlDateTime);
            this.pnlBottom.Controls.Add(this.lblCopyrights);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 722);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1568, 100);
            this.pnlBottom.TabIndex = 30;
            // 
            // lblCopyrights
            // 
            this.lblCopyrights.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCopyrights.AutoSize = true;
            this.lblCopyrights.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyrights.ForeColor = System.Drawing.Color.White;
            this.lblCopyrights.Location = new System.Drawing.Point(8, 71);
            this.lblCopyrights.Name = "lblCopyrights";
            this.lblCopyrights.Size = new System.Drawing.Size(439, 20);
            this.lblCopyrights.TabIndex = 34;
            this.lblCopyrights.Text = "Copyrights © 2018. All rights reserved By Amal Salvin Joseph";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(79, 43);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(188, 39);
            this.lblTime.TabIndex = 32;
            this.lblTime.Text = "hh:mm:ss tt";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(77, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(203, 30);
            this.lblDate.TabIndex = 32;
            this.lblDate.Text = "dd MMMM yyyy";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlDashBoard);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 100);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1568, 622);
            this.pnlMain.TabIndex = 31;
            // 
            // pnlDashBoard
            // 
            this.pnlDashBoard.Controls.Add(this.btbtnOrder);
            this.pnlDashBoard.Controls.Add(this.btbtnKot);
            this.pnlDashBoard.Controls.Add(this.btbtnBilling);
            this.pnlDashBoard.Location = new System.Drawing.Point(586, 170);
            this.pnlDashBoard.Name = "pnlDashBoard";
            this.pnlDashBoard.Size = new System.Drawing.Size(397, 364);
            this.pnlDashBoard.TabIndex = 34;
            // 
            // btbtnOrder
            // 
            this.btbtnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btbtnOrder.color = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btbtnOrder.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btbtnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbtnOrder.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbtnOrder.ForeColor = System.Drawing.Color.White;
            this.btbtnOrder.Image = global::ROMS.Properties.Resources.Food_Order100;
            this.btbtnOrder.ImagePosition = 23;
            this.btbtnOrder.ImageZoom = 50;
            this.btbtnOrder.LabelPosition = 58;
            this.btbtnOrder.LabelText = "Order(s)";
            this.btbtnOrder.Location = new System.Drawing.Point(229, 187);
            this.btbtnOrder.Margin = new System.Windows.Forms.Padding(6);
            this.btbtnOrder.Name = "btbtnOrder";
            this.btbtnOrder.Size = new System.Drawing.Size(150, 162);
            this.btbtnOrder.TabIndex = 34;
            // 
            // btbtnKot
            // 
            this.btbtnKot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btbtnKot.color = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btbtnKot.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btbtnKot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbtnKot.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbtnKot.ForeColor = System.Drawing.Color.White;
            this.btbtnKot.Image = global::ROMS.Properties.Resources.Chef_Hat_100;
            this.btbtnKot.ImagePosition = 23;
            this.btbtnKot.ImageZoom = 50;
            this.btbtnKot.LabelPosition = 58;
            this.btbtnKot.LabelText = "KOT(s)";
            this.btbtnKot.Location = new System.Drawing.Point(229, 15);
            this.btbtnKot.Margin = new System.Windows.Forms.Padding(6);
            this.btbtnKot.Name = "btbtnKot";
            this.btbtnKot.Size = new System.Drawing.Size(150, 162);
            this.btbtnKot.TabIndex = 36;
            // 
            // btbtnBilling
            // 
            this.btbtnBilling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btbtnBilling.color = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btbtnBilling.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btbtnBilling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbtnBilling.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbtnBilling.ForeColor = System.Drawing.Color.White;
            this.btbtnBilling.Image = global::ROMS.Properties.Resources.Billing_100px;
            this.btbtnBilling.ImagePosition = 100;
            this.btbtnBilling.ImageZoom = 50;
            this.btbtnBilling.LabelPosition = 130;
            this.btbtnBilling.LabelText = "Billing";
            this.btbtnBilling.Location = new System.Drawing.Point(18, 15);
            this.btbtnBilling.Margin = new System.Windows.Forms.Padding(6);
            this.btbtnBilling.Name = "btbtnBilling";
            this.btbtnBilling.Size = new System.Drawing.Size(199, 334);
            this.btbtnBilling.TabIndex = 35;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::ROMS.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(12, 17);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(73, 67);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 32;
            this.pbLogo.TabStop = false;
            // 
            // bimbtnExit
            // 
            this.bimbtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bimbtnExit.Image = global::ROMS.Properties.Resources.Logout_100;
            this.bimbtnExit.ImageActive = null;
            this.bimbtnExit.Location = new System.Drawing.Point(1487, 21);
            this.bimbtnExit.Name = "bimbtnExit";
            this.bimbtnExit.Size = new System.Drawing.Size(60, 60);
            this.bimbtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bimbtnExit.TabIndex = 32;
            this.bimbtnExit.TabStop = false;
            this.bimbtnExit.Zoom = 10;
            this.bimbtnExit.Click += new System.EventHandler(this.bimbtnExit_Click);
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // pnlDateTime
            // 
            this.pnlDateTime.Controls.Add(this.lblDate);
            this.pnlDateTime.Controls.Add(this.lblTime);
            this.pnlDateTime.Location = new System.Drawing.Point(1291, 10);
            this.pnlDateTime.Name = "pnlDateTime";
            this.pnlDateTime.Size = new System.Drawing.Size(272, 81);
            this.pnlDateTime.TabIndex = 35;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1568, 822);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlDashBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimbtnExit)).EndInit();
            this.pnlDateTime.ResumeLayout(false);
            this.pnlDateTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblApplicationTitle;
        private Bunifu.Framework.UI.BunifuImageButton bimbtnExit;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCopyrights;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlDashBoard;
        private Bunifu.Framework.UI.BunifuTileButton btbtnOrder;
        private Bunifu.Framework.UI.BunifuTileButton btbtnKot;
        private Bunifu.Framework.UI.BunifuTileButton btbtnBilling;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Panel pnlDateTime;
    }
}