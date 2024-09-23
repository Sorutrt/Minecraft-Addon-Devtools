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
            this.SuspendLayout();
            // 
            // dirNameTextBox
            // 
            this.dirNameTextBox.Location = new System.Drawing.Point(159, 35);
            this.dirNameTextBox.Name = "dirNameTextBox";
            this.dirNameTextBox.Size = new System.Drawing.Size(275, 19);
            this.dirNameTextBox.TabIndex = 0;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // dirNameBtn
            // 
            this.dirNameBtn.Location = new System.Drawing.Point(481, 35);
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
            this.worldnameListBox.Location = new System.Drawing.Point(140, 113);
            this.worldnameListBox.Name = "worldnameListBox";
            this.worldnameListBox.Size = new System.Drawing.Size(306, 196);
            this.worldnameListBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.worldnameListBox);
            this.Controls.Add(this.dirNameBtn);
            this.Controls.Add(this.dirNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dirNameTextBox;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button dirNameBtn;
        private System.Windows.Forms.ListBox worldnameListBox;
    }
}

