namespace Updater
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtLabelStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.txtChangelog = new System.Windows.Forms.TextBox();
            this.txtLabelApplication = new System.Windows.Forms.Label();
            this.txtApplication = new System.Windows.Forms.Label();
            this.txtLabelChangelog = new System.Windows.Forms.Label();
            this.bg2 = new System.Windows.Forms.Panel();
            this.bg1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLabelVersionCurrent = new System.Windows.Forms.Label();
            this.txtLabelVersionNew = new System.Windows.Forms.Label();
            this.txtVersionCurrent = new System.Windows.Forms.Label();
            this.txtVersionNew = new System.Windows.Forms.Label();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.buttUpdate = new UberLib.Controls.Button();
            this.progressBar = new UberLib.Controls.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.bg1.SuspendLayout();
            this.panelUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLabelStatus
            // 
            this.txtLabelStatus.AutoSize = true;
            this.txtLabelStatus.BackColor = System.Drawing.Color.Transparent;
            this.txtLabelStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtLabelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.txtLabelStatus.Location = new System.Drawing.Point(3, 3);
            this.txtLabelStatus.Name = "txtLabelStatus";
            this.txtLabelStatus.Size = new System.Drawing.Size(58, 19);
            this.txtLabelStatus.TabIndex = 9;
            this.txtLabelStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.BackColor = System.Drawing.Color.Transparent;
            this.txtStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.Black;
            this.txtStatus.Location = new System.Drawing.Point(4, 22);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(32, 16);
            this.txtStatus.TabIndex = 11;
            this.txtStatus.Text = "Idle.";
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbIcon.Location = new System.Drawing.Point(15, 63);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(32, 32);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon.TabIndex = 13;
            this.pbIcon.TabStop = false;
            // 
            // txtChangelog
            // 
            this.txtChangelog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.txtChangelog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChangelog.ForeColor = System.Drawing.Color.Black;
            this.txtChangelog.Location = new System.Drawing.Point(15, 126);
            this.txtChangelog.Multiline = true;
            this.txtChangelog.Name = "txtChangelog";
            this.txtChangelog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtChangelog.Size = new System.Drawing.Size(479, 103);
            this.txtChangelog.TabIndex = 15;
            this.txtChangelog.Text = "Unknown";
            // 
            // txtLabelApplication
            // 
            this.txtLabelApplication.AutoSize = true;
            this.txtLabelApplication.BackColor = System.Drawing.Color.Transparent;
            this.txtLabelApplication.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtLabelApplication.ForeColor = System.Drawing.Color.Black;
            this.txtLabelApplication.Location = new System.Drawing.Point(12, 44);
            this.txtLabelApplication.Name = "txtLabelApplication";
            this.txtLabelApplication.Size = new System.Drawing.Size(183, 16);
            this.txtLabelApplication.TabIndex = 17;
            this.txtLabelApplication.Text = "An update is now available for:";
            // 
            // txtApplication
            // 
            this.txtApplication.AutoSize = true;
            this.txtApplication.BackColor = System.Drawing.Color.Transparent;
            this.txtApplication.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.txtApplication.Location = new System.Drawing.Point(53, 71);
            this.txtApplication.Name = "txtApplication";
            this.txtApplication.Size = new System.Drawing.Size(143, 16);
            this.txtApplication.TabIndex = 18;
            this.txtApplication.Text = "Unknown Application";
            // 
            // txtLabelChangelog
            // 
            this.txtLabelChangelog.AutoSize = true;
            this.txtLabelChangelog.BackColor = System.Drawing.Color.Transparent;
            this.txtLabelChangelog.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtLabelChangelog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.txtLabelChangelog.Location = new System.Drawing.Point(11, 104);
            this.txtLabelChangelog.Name = "txtLabelChangelog";
            this.txtLabelChangelog.Size = new System.Drawing.Size(93, 19);
            this.txtLabelChangelog.TabIndex = 19;
            this.txtLabelChangelog.Text = "Changelog";
            // 
            // bg2
            // 
            this.bg2.BackColor = System.Drawing.Color.Gray;
            this.bg2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bg2.Location = new System.Drawing.Point(0, 35);
            this.bg2.Name = "bg2";
            this.bg2.Size = new System.Drawing.Size(506, 3);
            this.bg2.TabIndex = 21;
            // 
            // bg1
            // 
            this.bg1.BackgroundImage = global::Updater.Properties.Resources.Background;
            this.bg1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bg1.Controls.Add(this.label1);
            this.bg1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bg1.Location = new System.Drawing.Point(0, 0);
            this.bg1.Name = "bg1";
            this.bg1.Size = new System.Drawing.Size(506, 35);
            this.bg1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Update Available";
            // 
            // txtLabelVersionCurrent
            // 
            this.txtLabelVersionCurrent.AutoSize = true;
            this.txtLabelVersionCurrent.BackColor = System.Drawing.Color.Transparent;
            this.txtLabelVersionCurrent.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabelVersionCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.txtLabelVersionCurrent.Location = new System.Drawing.Point(289, 44);
            this.txtLabelVersionCurrent.Name = "txtLabelVersionCurrent";
            this.txtLabelVersionCurrent.Size = new System.Drawing.Size(109, 16);
            this.txtLabelVersionCurrent.TabIndex = 22;
            this.txtLabelVersionCurrent.Text = "Current version:";
            // 
            // txtLabelVersionNew
            // 
            this.txtLabelVersionNew.AutoSize = true;
            this.txtLabelVersionNew.BackColor = System.Drawing.Color.Transparent;
            this.txtLabelVersionNew.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabelVersionNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.txtLabelVersionNew.Location = new System.Drawing.Point(404, 44);
            this.txtLabelVersionNew.Name = "txtLabelVersionNew";
            this.txtLabelVersionNew.Size = new System.Drawing.Size(90, 16);
            this.txtLabelVersionNew.TabIndex = 23;
            this.txtLabelVersionNew.Text = "New version:";
            // 
            // txtVersionCurrent
            // 
            this.txtVersionCurrent.AutoSize = true;
            this.txtVersionCurrent.BackColor = System.Drawing.Color.Transparent;
            this.txtVersionCurrent.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtVersionCurrent.ForeColor = System.Drawing.Color.Black;
            this.txtVersionCurrent.Location = new System.Drawing.Point(289, 60);
            this.txtVersionCurrent.Name = "txtVersionCurrent";
            this.txtVersionCurrent.Size = new System.Drawing.Size(37, 16);
            this.txtVersionCurrent.TabIndex = 24;
            this.txtVersionCurrent.Text = "0.0.0";
            // 
            // txtVersionNew
            // 
            this.txtVersionNew.AutoSize = true;
            this.txtVersionNew.BackColor = System.Drawing.Color.Transparent;
            this.txtVersionNew.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtVersionNew.ForeColor = System.Drawing.Color.Black;
            this.txtVersionNew.Location = new System.Drawing.Point(404, 60);
            this.txtVersionNew.Name = "txtVersionNew";
            this.txtVersionNew.Size = new System.Drawing.Size(37, 16);
            this.txtVersionNew.TabIndex = 25;
            this.txtVersionNew.Text = "0.0.0";
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.txtLabelStatus);
            this.panelUpdate.Controls.Add(this.txtStatus);
            this.panelUpdate.Controls.Add(this.progressBar);
            this.panelUpdate.Location = new System.Drawing.Point(8, 235);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(498, 80);
            this.panelUpdate.TabIndex = 26;
            this.panelUpdate.Visible = false;
            // 
            // buttUpdate
            // 
            this.buttUpdate.BackColor = System.Drawing.Color.Transparent;
            this.buttUpdate.ButtonText = "Update";
            this.buttUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttUpdate.Location = new System.Drawing.Point(396, 235);
            this.buttUpdate.Name = "buttUpdate";
            this.buttUpdate.Size = new System.Drawing.Size(98, 26);
            this.buttUpdate.Style_Border_Colour = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttUpdate.Style_Border_Size = 0F;
            this.buttUpdate.Style_Normal_Background = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.buttUpdate.Style_Normal_Background_1 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.buttUpdate.Style_Normal_Background_2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.buttUpdate.Style_Normal_Background_Image = null;
            this.buttUpdate.Style_Normal_Text_Colour = System.Drawing.Color.White;
            this.buttUpdate.Style_OnClick_Background = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.buttUpdate.Style_OnClick_Background_1 = System.Drawing.Color.DarkGray;
            this.buttUpdate.Style_OnClick_Background_2 = System.Drawing.Color.LightGray;
            this.buttUpdate.Style_OnClick_Background_Image = null;
            this.buttUpdate.Style_OnClick_Text_Colour = System.Drawing.Color.White;
            this.buttUpdate.Style_OnHover_Background = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.buttUpdate.Style_OnHover_Background_1 = System.Drawing.Color.DarkGray;
            this.buttUpdate.Style_OnHover_Background_2 = System.Drawing.Color.SlateGray;
            this.buttUpdate.Style_OnHover_Background_Image = null;
            this.buttUpdate.Style_OnHover_Text_Colour = System.Drawing.Color.White;
            this.buttUpdate.Style_Text_Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttUpdate.Style_Text_Position_Horizontal = UberLib.Controls.Button.TextTypeX.Centre;
            this.buttUpdate.Style_Text_Position_Vertical = UberLib.Controls.Button.TextTypeY.Centre;
            this.buttUpdate.TabIndex = 27;
            this.buttUpdate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttUpdate_MouseClick);
            // 
            // progressBar
            // 
            this.progressBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar.Location = new System.Drawing.Point(7, 41);
            this.progressBar.Name = "progressBar";
            this.progressBar.Orientation = UberLib.Controls.ProgressBar.OrientationType.LeftToRight;
            this.progressBar.ReadOnly = true;
            this.progressBar.Size = new System.Drawing.Size(479, 31);
            this.progressBar.Style_Border_Colour = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.progressBar.Style_Border_Width = 2;
            this.progressBar.Style_Colour_Empty = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.progressBar.Style_Colour_Filled = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.progressBar.Style_Image_Empty = null;
            this.progressBar.Style_Image_Filled = null;
            this.progressBar.TabIndex = 14;
            this.progressBar.Text_Background = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.progressBar.Text_Colour = System.Drawing.Color.White;
            this.progressBar.Text_Decimal_Points = 2;
            this.progressBar.Text_Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.progressBar.Text_Padding = 4;
            this.progressBar.Text_Position_X = UberLib.Controls.ProgressBar.TextTypeX.Centre;
            this.progressBar.Text_Position_Y = UberLib.Controls.ProgressBar.TextTypeY.Centre;
            this.progressBar.Value = 0F;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(506, 315);
            this.Controls.Add(this.buttUpdate);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.txtVersionNew);
            this.Controls.Add(this.txtVersionCurrent);
            this.Controls.Add(this.txtLabelVersionNew);
            this.Controls.Add(this.txtLabelVersionCurrent);
            this.Controls.Add(this.txtLabelChangelog);
            this.Controls.Add(this.txtApplication);
            this.Controls.Add(this.txtLabelApplication);
            this.Controls.Add(this.txtChangelog);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.bg2);
            this.Controls.Add(this.bg1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updater - Ubermeat.co.uk FOSS";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.bg1.ResumeLayout(false);
            this.bg1.PerformLayout();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtLabelStatus;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.PictureBox pbIcon;
        private UberLib.Controls.ProgressBar progressBar;
        private System.Windows.Forms.TextBox txtChangelog;
        private System.Windows.Forms.Label txtLabelApplication;
        private System.Windows.Forms.Label txtApplication;
        private System.Windows.Forms.Label txtLabelChangelog;
        private System.Windows.Forms.Panel bg2;
        private System.Windows.Forms.Panel bg1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtLabelVersionCurrent;
        private System.Windows.Forms.Label txtLabelVersionNew;
        private System.Windows.Forms.Label txtVersionCurrent;
        private System.Windows.Forms.Label txtVersionNew;
        private System.Windows.Forms.Panel panelUpdate;
        private UberLib.Controls.Button buttUpdate;
    }
}

