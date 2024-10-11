namespace mc_worldname_viewer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.dirNameTextBox = new System.Windows.Forms.TextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.dirNameBtn = new System.Windows.Forms.Button();
            this.worldnameListBox = new System.Windows.Forms.ListBox();
            this.worldThumPictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.worldInfoTabPage = new System.Windows.Forms.TabPage();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.worldThumPictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.worldInfoTabPage.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // dirNameTextBox
            // 
            this.dirNameTextBox.Location = new System.Drawing.Point(89, 6);
            this.dirNameTextBox.Name = "dirNameTextBox";
            this.dirNameTextBox.Size = new System.Drawing.Size(571, 19);
            this.dirNameTextBox.TabIndex = 0;
            this.dirNameTextBox.Text = "C:\\Users\\58kok\\AppData\\Local\\Packages\\Microsoft.MinecraftEducationEdition_8wekyb3" +
    "d8bbwe\\LocalState\\games\\com.mojang\\minecraftWorlds";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // dirNameBtn
            // 
            this.dirNameBtn.Location = new System.Drawing.Point(380, 17);
            this.dirNameBtn.Name = "dirNameBtn";
            this.dirNameBtn.Size = new System.Drawing.Size(75, 23);
            this.dirNameBtn.TabIndex = 1;
            this.dirNameBtn.Text = "Enter";
            this.dirNameBtn.UseVisualStyleBackColor = true;
            this.dirNameBtn.Click += new System.EventHandler(this.dirNameBtn_Click);
            // 
            // worldnameListBox
            // 
            this.worldnameListBox.FormattingEnabled = true;
            this.worldnameListBox.ItemHeight = 12;
            this.worldnameListBox.Location = new System.Drawing.Point(18, 17);
            this.worldnameListBox.Name = "worldnameListBox";
            this.worldnameListBox.Size = new System.Drawing.Size(356, 316);
            this.worldnameListBox.TabIndex = 2;
            this.worldnameListBox.SelectedIndexChanged += new System.EventHandler(this.worldnameListBox_SelectedIndexChanged);
            // 
            // worldThumPictureBox
            // 
            this.worldThumPictureBox.Location = new System.Drawing.Point(380, 189);
            this.worldThumPictureBox.Name = "worldThumPictureBox";
            this.worldThumPictureBox.Size = new System.Drawing.Size(256, 144);
            this.worldThumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.worldThumPictureBox.TabIndex = 3;
            this.worldThumPictureBox.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.worldInfoTabPage);
            this.tabControl1.Controls.Add(this.settingsTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(705, 405);
            this.tabControl1.TabIndex = 4;
            // 
            // worldInfoTabPage
            // 
            this.worldInfoTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.worldInfoTabPage.Controls.Add(this.worldnameListBox);
            this.worldInfoTabPage.Controls.Add(this.worldThumPictureBox);
            this.worldInfoTabPage.Controls.Add(this.dirNameBtn);
            this.worldInfoTabPage.Location = new System.Drawing.Point(4, 22);
            this.worldInfoTabPage.Name = "worldInfoTabPage";
            this.worldInfoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.worldInfoTabPage.Size = new System.Drawing.Size(697, 379);
            this.worldInfoTabPage.TabIndex = 0;
            this.worldInfoTabPage.Text = "WorldInfo";
            this.worldInfoTabPage.UseVisualStyleBackColor = true;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.label1);
            this.settingsTabPage.Controls.Add(this.dirNameTextBox);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTabPage.Size = new System.Drawing.Size(666, 355);
            this.settingsTabPage.TabIndex = 1;
            this.settingsTabPage.Text = "環境設定";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ワールドの場所";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 405);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Minecraft Addon Devtools";
            ((System.ComponentModel.ISupportInitialize)(this.worldThumPictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.worldInfoTabPage.ResumeLayout(false);
            this.settingsTabPage.ResumeLayout(false);
            this.settingsTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox dirNameTextBox;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button dirNameBtn;
        private System.Windows.Forms.ListBox worldnameListBox;
        private System.Windows.Forms.PictureBox worldThumPictureBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage worldInfoTabPage;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.Label label1;
    }
}

