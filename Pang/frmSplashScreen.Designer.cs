namespace Pang
{
    partial class frmSplashScreen
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
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.panelProgressbarContainer = new System.Windows.Forms.Panel();
            this.panelProgressbar = new System.Windows.Forms.Panel();
            this.timerProgressbar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.panelProgressbarContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(63)))), ((int)(((byte)(245)))));
            this.pictureBoxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackground.Image = global::Pang.Properties.Resources.ScreenBackground;
            this.pictureBoxBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(684, 361);
            this.pictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackground.TabIndex = 0;
            this.pictureBoxBackground.TabStop = false;
            // 
            // panelProgressbarContainer
            // 
            this.panelProgressbarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(63)))), ((int)(((byte)(245)))));
            this.panelProgressbarContainer.Controls.Add(this.panelProgressbar);
            this.panelProgressbarContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelProgressbarContainer.Location = new System.Drawing.Point(0, 346);
            this.panelProgressbarContainer.Name = "panelProgressbarContainer";
            this.panelProgressbarContainer.Size = new System.Drawing.Size(684, 15);
            this.panelProgressbarContainer.TabIndex = 1;
            // 
            // panelProgressbar
            // 
            this.panelProgressbar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panelProgressbar.Location = new System.Drawing.Point(0, 0);
            this.panelProgressbar.Name = "panelProgressbar";
            this.panelProgressbar.Size = new System.Drawing.Size(33, 15);
            this.panelProgressbar.TabIndex = 2;
            // 
            // timerProgressbar
            // 
            this.timerProgressbar.Enabled = true;
            this.timerProgressbar.Interval = 30;
            this.timerProgressbar.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.panelProgressbarContainer);
            this.Controls.Add(this.pictureBoxBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.panelProgressbarContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.Panel panelProgressbarContainer;
        private System.Windows.Forms.Panel panelProgressbar;
        private System.Windows.Forms.Timer timerProgressbar;
    }
}