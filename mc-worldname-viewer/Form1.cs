using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mc_worldname_viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Enterボタンをクリック
        private void dirNameBtn_Click(object sender, EventArgs e)
        {
            // MinecraftEducationのワールドが入っているディレクトリ
            string dirName = dirNameTextBox.Text;

            // ワールドハッシュ&ワールド名を表示するための配列 あとで辞書にするかも？
            Dictionary<string, string> worldHashNames = new Dictionary<string, string>();

            //MessageBox.Show(dirName);
            DirectoryInfo worldHashesDI = new DirectoryInfo(dirName);
            try
            {
                // ワールドのディレクトリ&ワールド名を取得
                foreach (DirectoryInfo di in worldHashesDI.GetDirectories("*="))
                {
                    // get world name
                    string worldNamePath = dirName + "\\" + di.Name + "\\levelname.txt";
                    MessageBox.Show(worldNamePath);
                    string worldName;
                    if (File.Exists(worldNamePath))
                    {
                        worldName = File.ReadAllText(worldNamePath, Encoding.GetEncoding("UTF-8"));
                    }
                    else
                    {
                        worldName = null;
                        //MessageBox.Show("levelname.txtが見つかりません");
                    }

                    worldHashNames.Add(di.Name, worldName);
                }
            }
            catch (Exception exp) {
                Console.WriteLine(exp.Message);
            }

            foreach (KeyValuePair<string, string> whn in worldHashNames)
            {
                string hash = whn.Key;
                string name = whn.Value;
                string showhn;
                if(name == null)
                {
                    showhn = hash + " : World name has not found";
                }
                else
                {
                    showhn = hash + " : " + name;
                }
                worldnameListBox.Items.Add(showhn);
            }

        }
    }
}
