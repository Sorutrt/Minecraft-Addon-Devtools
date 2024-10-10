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
        // ワールドディレクトリのリスト
        private List<string> worldHashList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        // Enterボタンをクリック
        private void dirNameBtn_Click(object sender, EventArgs e)
        {
            worldnameListBox.Items.Clear();

            // MinecraftEducationのワールドが入っているディレクトリ
            string dirName = dirNameTextBox.Text;

            // ここにすべてを入れる
            List<string[]> worldInfoList = new List<string[]>();

            // ワールドディレクトリのリスト
            worldHashList = Directory
                .GetDirectories (dirName, "*=", SearchOption.AllDirectories) // ディレクトリ内ファイル取得
                .Where(filepath => Path.GetFileName(filepath) !=  ".DS_Store") // ignore .DS_Store
                .OrderByDescending(filepath => File.GetLastWriteTime(filepath).Date) // 日付順に降順でソート
                .ThenBy(filepath => File.GetLastWriteTime(filepath).TimeOfDay) // 同じ日付内で時刻順に昇順でソート
                .ToList();
            

            int worldCount = worldHashList.Count();
            MessageBox.Show($"{worldCount.ToString()}個のワールドが見つかりました");

            try
            {
                // ワールドのディレクトリ&ワールド名を取得
                for (int i=0; i<worldCount; i++)
                {
                    var worldHash = worldHashList[i];
                    // worldの名前が入ってる実際の絶対パス
                    string worldNamePath = worldHash + "\\levelname.txt";

                    // get world name
                    string worldName;
                    if (File.Exists(worldNamePath))
                    {
                        worldName = File.ReadAllText(worldNamePath, Encoding.GetEncoding("UTF-8"));
                    }
                    else
                    {
                        worldName = null;
                        MessageBox.Show($"{worldNamePath}でlevelname.txtが見つかりません");
                    }

                    worldInfoList.Add(new string[2] { worldHashList[i], worldName });
                }
            }
            catch (Exception exp) {
                Console.WriteLine(exp.Message);
            }

            // リストボックスの再描画しないようにする
            worldnameListBox.BeginUpdate();

            foreach (string[] whn in worldInfoList)
            {
                string hash = whn[0].Substring(dirName.Length+1, 12);
                string name = whn[1];
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

            // リストボックス描画
            worldnameListBox.EndUpdate();
        }


        // ワールド選択
        private void worldnameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // 選択しているワールドのパス
                string selectedWorld = worldHashList[worldnameListBox.SelectedIndex];

                if (selectedWorld != null)
                {
                    string ThumPath = selectedWorld + "\\world_icon.jpeg";
                    worldThumPictureBox.ImageLocation = ThumPath; // .Imageプロパティを使うと表示中に削除ができない
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }
    }
}
