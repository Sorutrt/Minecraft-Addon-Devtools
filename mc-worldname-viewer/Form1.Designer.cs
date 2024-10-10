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
            ((System.ComponentModel.ISupportInitialize)(this.worldThumPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dirNameTextBox
            // 
            this.dirNameTextBox.Location = new System.Drawing.Point(33, 35);
            this.dirNameTextBox.Name = "dirNameTextBox";
            this.dirNameTextBox.Size = new System.Drawing.Size(275, 19);
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
            this.dirNameBtn.Location = new System.Drawing.Point(314, 33);
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
            this.worldnameListBox.Location = new System.Drawing.Point(33, 62);
            this.worldnameListBox.Name = "worldnameListBox";
            this.worldnameListBox.Size = new System.Drawing.Size(356, 340);
            this.worldnameListBox.TabIndex = 2;
            this.worldnameListBox.SelectedIndexChanged += new System.EventHandler(this.worldnameListBox_SelectedIndexChanged);
            // 
            // worldThumPictureBox
            // 
            this.worldThumPictureBox.Location = new System.Drawing.Point(410, 258);
            this.worldThumPictureBox.Name = "worldThumPictureBox";
            this.worldThumPictureBox.Size = new System.Drawing.Size(256, 144);
            this.worldThumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.worldThumPictureBox.TabIndex = 3;
            this.worldThumPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.worldThumPictureBox);
            this.Controls.Add(this.worldnameListBox);
            this.Controls.Add(this.dirNameBtn);
            this.Controls.Add(this.dirNameTextBox);
            this.Name = "Form1";
            this.Text = "Minecraft Addon Devtools";
            ((System.ComponentModel.ISupportInitialize)(this.worldThumPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dirNameTextBox;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button dirNameBtn;
        private System.Windows.Forms.ListBox worldnameListBox;
        private System.Windows.Forms.PictureBox worldThumPictureBox;
    }
}

