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
            this.dirNameBtn = new System.Windows.Forms.Button();
            this.worldnameListBox = new System.Windows.Forms.ListBox();
            this.worldThumPictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.worldInfoTabPage = new System.Windows.Forms.TabPage();
            this.openVscodeBtn = new System.Windows.Forms.Button();
            this.openExplorer = new System.Windows.Forms.Button();
            this.xyzTabPage = new System.Windows.Forms.TabPage();
            this.xyzConvertButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.xyzTextBox = new System.Windows.Forms.TextBox();
            this.worldOfdBtn = new System.Windows.Forms.Button();
            this.vscodePathTxtBox = new System.Windows.Forms.TextBox();
            this.vscodeOfdBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.worldThumPictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            this.worldInfoTabPage.SuspendLayout();
            this.xyzTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // dirNameTextBox
            // 
            this.dirNameTextBox.Location = new System.Drawing.Point(94, 6);
            this.dirNameTextBox.Name = "dirNameTextBox";
            this.dirNameTextBox.Size = new System.Drawing.Size(514, 19);
            this.dirNameTextBox.TabIndex = 0;
            this.dirNameTextBox.Text = "C:\\Users\\58kok\\AppData\\Local\\Packages\\Microsoft.MinecraftEducationEdition_8wekyb3" +
    "d8bbwe\\LocalState\\games\\com.mojang\\minecraftWorlds";
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
            this.tabControl1.Controls.Add(this.xyzTabPage);
            this.tabControl1.Controls.Add(this.settingsTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(705, 405);
            this.tabControl1.TabIndex = 4;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.vscodeOfdBtn);
            this.settingsTabPage.Controls.Add(this.vscodePathTxtBox);
            this.settingsTabPage.Controls.Add(this.worldOfdBtn);
            this.settingsTabPage.Controls.Add(this.label3);
            this.settingsTabPage.Controls.Add(this.label1);
            this.settingsTabPage.Controls.Add(this.dirNameTextBox);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTabPage.Size = new System.Drawing.Size(697, 379);
            this.settingsTabPage.TabIndex = 1;
            this.settingsTabPage.Text = "環境設定";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "VSCodeの場所";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ワールドの場所";
            // 
            // worldInfoTabPage
            // 
            this.worldInfoTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.worldInfoTabPage.Controls.Add(this.openVscodeBtn);
            this.worldInfoTabPage.Controls.Add(this.openExplorer);
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
            // openVscodeBtn
            // 
            this.openVscodeBtn.Location = new System.Drawing.Point(511, 160);
            this.openVscodeBtn.Name = "openVscodeBtn";
            this.openVscodeBtn.Size = new System.Drawing.Size(125, 23);
            this.openVscodeBtn.TabIndex = 5;
            this.openVscodeBtn.Text = "VSCodeで開く";
            this.openVscodeBtn.UseVisualStyleBackColor = true;
            this.openVscodeBtn.Click += new System.EventHandler(this.openVscodeBtn_Click);
            // 
            // openExplorer
            // 
            this.openExplorer.Location = new System.Drawing.Point(380, 160);
            this.openExplorer.Name = "openExplorer";
            this.openExplorer.Size = new System.Drawing.Size(125, 23);
            this.openExplorer.TabIndex = 4;
            this.openExplorer.Text = "エクスプローラーで開く";
            this.openExplorer.UseVisualStyleBackColor = true;
            this.openExplorer.Click += new System.EventHandler(this.openExplorer_Click);
            // 
            // xyzTabPage
            // 
            this.xyzTabPage.Controls.Add(this.xyzConvertButton);
            this.xyzTabPage.Controls.Add(this.label2);
            this.xyzTabPage.Controls.Add(this.xyzTextBox);
            this.xyzTabPage.Location = new System.Drawing.Point(4, 22);
            this.xyzTabPage.Name = "xyzTabPage";
            this.xyzTabPage.Size = new System.Drawing.Size(697, 379);
            this.xyzTabPage.TabIndex = 2;
            this.xyzTabPage.Text = "xyz";
            this.xyzTabPage.UseVisualStyleBackColor = true;
            // 
            // xyzConvertButton
            // 
            this.xyzConvertButton.Location = new System.Drawing.Point(23, 74);
            this.xyzConvertButton.Name = "xyzConvertButton";
            this.xyzConvertButton.Size = new System.Drawing.Size(128, 23);
            this.xyzConvertButton.TabIndex = 2;
            this.xyzConvertButton.Text = "Convert - Copy";
            this.xyzConvertButton.UseVisualStyleBackColor = true;
            this.xyzConvertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "x y z (x y z)";
            // 
            // xyzTextBox
            // 
            this.xyzTextBox.Location = new System.Drawing.Point(98, 22);
            this.xyzTextBox.Name = "xyzTextBox";
            this.xyzTextBox.Size = new System.Drawing.Size(100, 19);
            this.xyzTextBox.TabIndex = 0;
            // 
            // worldOfdBtn
            // 
            this.worldOfdBtn.Location = new System.Drawing.Point(614, 4);
            this.worldOfdBtn.Name = "worldOfdBtn";
            this.worldOfdBtn.Size = new System.Drawing.Size(75, 23);
            this.worldOfdBtn.TabIndex = 4;
            this.worldOfdBtn.Text = "参照..";
            this.worldOfdBtn.UseVisualStyleBackColor = true;
            this.worldOfdBtn.Click += new System.EventHandler(this.worldOfdBtn_Click);
            // 
            // vscodePathTxtBox
            // 
            this.vscodePathTxtBox.Location = new System.Drawing.Point(94, 35);
            this.vscodePathTxtBox.Name = "vscodePathTxtBox";
            this.vscodePathTxtBox.Size = new System.Drawing.Size(514, 19);
            this.vscodePathTxtBox.TabIndex = 5;
            // 
            // vscodeOfdBtn
            // 
            this.vscodeOfdBtn.Location = new System.Drawing.Point(614, 33);
            this.vscodeOfdBtn.Name = "vscodeOfdBtn";
            this.vscodeOfdBtn.Size = new System.Drawing.Size(75, 23);
            this.vscodeOfdBtn.TabIndex = 6;
            this.vscodeOfdBtn.Text = "参照..";
            this.vscodeOfdBtn.UseVisualStyleBackColor = true;
            this.vscodeOfdBtn.Click += new System.EventHandler(this.vscodeOfdBtn_Click);
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
            this.settingsTabPage.ResumeLayout(false);
            this.settingsTabPage.PerformLayout();
            this.worldInfoTabPage.ResumeLayout(false);
            this.xyzTabPage.ResumeLayout(false);
            this.xyzTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox dirNameTextBox;
        private System.Windows.Forms.Button dirNameBtn;
        private System.Windows.Forms.ListBox worldnameListBox;
        private System.Windows.Forms.PictureBox worldThumPictureBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage worldInfoTabPage;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage xyzTabPage;
        private System.Windows.Forms.Button xyzConvertButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xyzTextBox;
        private System.Windows.Forms.Button openExplorer;
        private System.Windows.Forms.Button openVscodeBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button worldOfdBtn;
        private System.Windows.Forms.TextBox vscodePathTxtBox;
        private System.Windows.Forms.Button vscodeOfdBtn;
    }
}

