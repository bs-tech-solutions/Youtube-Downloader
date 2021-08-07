
namespace Youtube_Downloader
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.UrlPanel = new System.Windows.Forms.Panel();
            this.UrlTB = new System.Windows.Forms.TextBox();
            this.UrlLabel = new System.Windows.Forms.Label();
            this.VideoDetailsPanel = new System.Windows.Forms.Panel();
            this.VideoNameLabel = new System.Windows.Forms.Label();
            this.ResolutionsLabel = new System.Windows.Forms.Label();
            this.VideoName = new System.Windows.Forms.Label();
            this.ResolutionsCMB = new System.Windows.Forms.ComboBox();
            this.DownloadPanel = new System.Windows.Forms.Panel();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.SaveToLabel = new System.Windows.Forms.Label();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.ChoosePathBtn = new FontAwesome.Sharp.IconButton();
            this.LoadingPB = new System.Windows.Forms.PictureBox();
            this.DownloadBtn = new FontAwesome.Sharp.IconButton();
            this.SettingBtn = new FontAwesome.Sharp.IconButton();
            this.VideoThumbNailPB = new System.Windows.Forms.PictureBox();
            this.AppLogoPB = new System.Windows.Forms.PictureBox();
            this.AboutBtn = new FontAwesome.Sharp.IconButton();
            this.MinimizeBtn = new FontAwesome.Sharp.IconButton();
            this.CloseBtn = new FontAwesome.Sharp.IconButton();
            this.TopPanel.SuspendLayout();
            this.UrlPanel.SuspendLayout();
            this.VideoDetailsPanel.SuspendLayout();
            this.DownloadPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoThumbNailPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppLogoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.LightGray;
            this.TopPanel.Controls.Add(this.AppNameLabel);
            this.TopPanel.Controls.Add(this.AppLogoPB);
            this.TopPanel.Controls.Add(this.AboutBtn);
            this.TopPanel.Controls.Add(this.MinimizeBtn);
            this.TopPanel.Controls.Add(this.CloseBtn);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 50);
            this.TopPanel.TabIndex = 0;
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.AutoSize = true;
            this.AppNameLabel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppNameLabel.Location = new System.Drawing.Point(43, 18);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(138, 19);
            this.AppNameLabel.TabIndex = 4;
            this.AppNameLabel.Text = "Youtube Downloader";
            // 
            // UrlPanel
            // 
            this.UrlPanel.BackColor = System.Drawing.Color.White;
            this.UrlPanel.Controls.Add(this.UrlLabel);
            this.UrlPanel.Controls.Add(this.UrlTB);
            this.UrlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UrlPanel.Location = new System.Drawing.Point(0, 50);
            this.UrlPanel.Name = "UrlPanel";
            this.UrlPanel.Size = new System.Drawing.Size(800, 60);
            this.UrlPanel.TabIndex = 1;
            // 
            // UrlTB
            // 
            this.UrlTB.Location = new System.Drawing.Point(61, 20);
            this.UrlTB.Name = "UrlTB";
            this.UrlTB.Size = new System.Drawing.Size(665, 20);
            this.UrlTB.TabIndex = 0;
            // 
            // UrlLabel
            // 
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlLabel.Location = new System.Drawing.Point(20, 20);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(35, 19);
            this.UrlLabel.TabIndex = 1;
            this.UrlLabel.Text = "URL";
            // 
            // VideoDetailsPanel
            // 
            this.VideoDetailsPanel.BackColor = System.Drawing.Color.White;
            this.VideoDetailsPanel.Controls.Add(this.ResolutionsCMB);
            this.VideoDetailsPanel.Controls.Add(this.VideoName);
            this.VideoDetailsPanel.Controls.Add(this.ResolutionsLabel);
            this.VideoDetailsPanel.Controls.Add(this.VideoNameLabel);
            this.VideoDetailsPanel.Controls.Add(this.VideoThumbNailPB);
            this.VideoDetailsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.VideoDetailsPanel.Location = new System.Drawing.Point(0, 110);
            this.VideoDetailsPanel.Name = "VideoDetailsPanel";
            this.VideoDetailsPanel.Size = new System.Drawing.Size(800, 200);
            this.VideoDetailsPanel.TabIndex = 2;
            // 
            // VideoNameLabel
            // 
            this.VideoNameLabel.AutoSize = true;
            this.VideoNameLabel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoNameLabel.Location = new System.Drawing.Point(254, 48);
            this.VideoNameLabel.Name = "VideoNameLabel";
            this.VideoNameLabel.Size = new System.Drawing.Size(96, 19);
            this.VideoNameLabel.TabIndex = 2;
            this.VideoNameLabel.Text = "Video Name:";
            // 
            // ResolutionsLabel
            // 
            this.ResolutionsLabel.AutoSize = true;
            this.ResolutionsLabel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolutionsLabel.Location = new System.Drawing.Point(254, 134);
            this.ResolutionsLabel.Name = "ResolutionsLabel";
            this.ResolutionsLabel.Size = new System.Drawing.Size(89, 19);
            this.ResolutionsLabel.TabIndex = 3;
            this.ResolutionsLabel.Text = "Resolutions:";
            // 
            // VideoName
            // 
            this.VideoName.AutoSize = true;
            this.VideoName.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoName.Location = new System.Drawing.Point(373, 50);
            this.VideoName.Name = "VideoName";
            this.VideoName.Size = new System.Drawing.Size(28, 15);
            this.VideoName.TabIndex = 4;
            this.VideoName.Text = "URL";
            // 
            // ResolutionsCMB
            // 
            this.ResolutionsCMB.FormattingEnabled = true;
            this.ResolutionsCMB.Location = new System.Drawing.Point(376, 134);
            this.ResolutionsCMB.Name = "ResolutionsCMB";
            this.ResolutionsCMB.Size = new System.Drawing.Size(150, 21);
            this.ResolutionsCMB.TabIndex = 5;
            // 
            // DownloadPanel
            // 
            this.DownloadPanel.BackColor = System.Drawing.Color.White;
            this.DownloadPanel.Controls.Add(this.LoadingPB);
            this.DownloadPanel.Controls.Add(this.DownloadBtn);
            this.DownloadPanel.Controls.Add(this.SettingBtn);
            this.DownloadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DownloadPanel.Location = new System.Drawing.Point(0, 310);
            this.DownloadPanel.Name = "DownloadPanel";
            this.DownloadPanel.Size = new System.Drawing.Size(800, 60);
            this.DownloadPanel.TabIndex = 3;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.White;
            this.SettingsPanel.Controls.Add(this.DestinationLabel);
            this.SettingsPanel.Controls.Add(this.SaveToLabel);
            this.SettingsPanel.Controls.Add(this.ChoosePathBtn);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsPanel.Location = new System.Drawing.Point(0, 370);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(800, 80);
            this.SettingsPanel.TabIndex = 4;
            // 
            // SaveToLabel
            // 
            this.SaveToLabel.AutoSize = true;
            this.SaveToLabel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveToLabel.Location = new System.Drawing.Point(76, 31);
            this.SaveToLabel.Name = "SaveToLabel";
            this.SaveToLabel.Size = new System.Drawing.Size(63, 19);
            this.SaveToLabel.TabIndex = 5;
            this.SaveToLabel.Text = "Save to:";
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLabel.Location = new System.Drawing.Point(145, 35);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(48, 15);
            this.DestinationLabel.TabIndex = 6;
            this.DestinationLabel.Text = "Save to:";
            // 
            // ChoosePathBtn
            // 
            this.ChoosePathBtn.FlatAppearance.BorderSize = 0;
            this.ChoosePathBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoosePathBtn.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.ChoosePathBtn.IconColor = System.Drawing.Color.Goldenrod;
            this.ChoosePathBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ChoosePathBtn.IconSize = 50;
            this.ChoosePathBtn.Location = new System.Drawing.Point(20, 15);
            this.ChoosePathBtn.Name = "ChoosePathBtn";
            this.ChoosePathBtn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ChoosePathBtn.Size = new System.Drawing.Size(50, 50);
            this.ChoosePathBtn.TabIndex = 4;
            this.ChoosePathBtn.UseVisualStyleBackColor = true;
            // 
            // LoadingPB
            // 
            this.LoadingPB.Image = global::Youtube_Downloader.Properties.Resources._1488;
            this.LoadingPB.Location = new System.Drawing.Point(676, 5);
            this.LoadingPB.Name = "LoadingPB";
            this.LoadingPB.Size = new System.Drawing.Size(50, 50);
            this.LoadingPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadingPB.TabIndex = 5;
            this.LoadingPB.TabStop = false;
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.FlatAppearance.BorderSize = 0;
            this.DownloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadBtn.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.DownloadBtn.IconColor = System.Drawing.Color.DarkSlateGray;
            this.DownloadBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DownloadBtn.IconSize = 50;
            this.DownloadBtn.Location = new System.Drawing.Point(620, 5);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.DownloadBtn.Size = new System.Drawing.Size(50, 50);
            this.DownloadBtn.TabIndex = 4;
            this.DownloadBtn.UseVisualStyleBackColor = true;
            // 
            // SettingBtn
            // 
            this.SettingBtn.FlatAppearance.BorderSize = 0;
            this.SettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingBtn.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.SettingBtn.IconColor = System.Drawing.Color.DarkSlateGray;
            this.SettingBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SettingBtn.IconSize = 50;
            this.SettingBtn.Location = new System.Drawing.Point(20, 5);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.SettingBtn.Size = new System.Drawing.Size(50, 50);
            this.SettingBtn.TabIndex = 3;
            this.SettingBtn.UseVisualStyleBackColor = true;
            // 
            // VideoThumbNailPB
            // 
            this.VideoThumbNailPB.Location = new System.Drawing.Point(20, 20);
            this.VideoThumbNailPB.Name = "VideoThumbNailPB";
            this.VideoThumbNailPB.Size = new System.Drawing.Size(200, 160);
            this.VideoThumbNailPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VideoThumbNailPB.TabIndex = 0;
            this.VideoThumbNailPB.TabStop = false;
            // 
            // AppLogoPB
            // 
            this.AppLogoPB.Image = global::Youtube_Downloader.Properties.Resources.logo;
            this.AppLogoPB.Location = new System.Drawing.Point(12, 12);
            this.AppLogoPB.Name = "AppLogoPB";
            this.AppLogoPB.Size = new System.Drawing.Size(25, 25);
            this.AppLogoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AppLogoPB.TabIndex = 3;
            this.AppLogoPB.TabStop = false;
            // 
            // AboutBtn
            // 
            this.AboutBtn.FlatAppearance.BorderSize = 0;
            this.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutBtn.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.AboutBtn.IconColor = System.Drawing.Color.CadetBlue;
            this.AboutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AboutBtn.IconSize = 35;
            this.AboutBtn.Location = new System.Drawing.Point(701, 12);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.AboutBtn.Size = new System.Drawing.Size(25, 25);
            this.AboutBtn.TabIndex = 2;
            this.AboutBtn.UseVisualStyleBackColor = true;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.MinimizeBtn.IconColor = System.Drawing.Color.ForestGreen;
            this.MinimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeBtn.IconSize = 35;
            this.MinimizeBtn.Location = new System.Drawing.Point(732, 12);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.MinimizeBtn.Size = new System.Drawing.Size(25, 25);
            this.MinimizeBtn.TabIndex = 1;
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.CloseBtn.IconColor = System.Drawing.Color.Firebrick;
            this.CloseBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseBtn.IconSize = 35;
            this.CloseBtn.Location = new System.Drawing.Point(763, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.CloseBtn.Size = new System.Drawing.Size(25, 25);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.DownloadPanel);
            this.Controls.Add(this.VideoDetailsPanel);
            this.Controls.Add(this.UrlPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Downloader";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.UrlPanel.ResumeLayout(false);
            this.UrlPanel.PerformLayout();
            this.VideoDetailsPanel.ResumeLayout(false);
            this.VideoDetailsPanel.PerformLayout();
            this.DownloadPanel.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoThumbNailPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppLogoPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private FontAwesome.Sharp.IconButton AboutBtn;
        private FontAwesome.Sharp.IconButton MinimizeBtn;
        private FontAwesome.Sharp.IconButton CloseBtn;
        private System.Windows.Forms.PictureBox AppLogoPB;
        private System.Windows.Forms.Label AppNameLabel;
        private System.Windows.Forms.Panel UrlPanel;
        private System.Windows.Forms.Label UrlLabel;
        private System.Windows.Forms.TextBox UrlTB;
        private System.Windows.Forms.Panel VideoDetailsPanel;
        private System.Windows.Forms.PictureBox VideoThumbNailPB;
        private System.Windows.Forms.Label VideoName;
        private System.Windows.Forms.Label ResolutionsLabel;
        private System.Windows.Forms.Label VideoNameLabel;
        private System.Windows.Forms.ComboBox ResolutionsCMB;
        private System.Windows.Forms.Panel DownloadPanel;
        private FontAwesome.Sharp.IconButton SettingBtn;
        private System.Windows.Forms.PictureBox LoadingPB;
        private FontAwesome.Sharp.IconButton DownloadBtn;
        private System.Windows.Forms.Panel SettingsPanel;
        private FontAwesome.Sharp.IconButton ChoosePathBtn;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.Label SaveToLabel;
    }
}

