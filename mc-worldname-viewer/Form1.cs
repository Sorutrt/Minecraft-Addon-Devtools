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
using Microsoft.WindowsAPICodePack.Dialogs;

namespace mc_worldname_viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // タブのサイズを変更
            this.tabControl1.ItemSize = new Size(100, 20);

            // タブの横幅を固定
            this.tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        // ------------------------------------------------
        //                  worldInfo
        // ------------------------------------------------

        // ワールドディレクトリのリスト
        private List<string> worldHashList = new List<string>();
        // 選択中のワールド
        private string selectedWorld = null;

       // Enterボタンをクリック
        private void dirNameBtn_Click(object sender, EventArgs e)
        {
            worldnameListBox.Items.Clear();

            // MinecraftEducationのワールドが入っているディレクトリ
            string dirName = dirNameTextBox.Text;

            // ここにすべてを入れる
            List<string[]> worldInfoList = new List<string[]>();

            try
            {
                // ワールドディレクトリのリスト
                worldHashList = Directory
                    .GetDirectories(dirName, "*=", SearchOption.AllDirectories) // ディレクトリ内ファイル取得
                    .Where(filepath => Path.GetFileName(filepath) != ".DS_Store") // ignore .DS_Store
                    .OrderByDescending(filepath => File.GetLastWriteTime(filepath).Date) // 日付順に降順でソート
                    .ThenBy(filepath => File.GetLastWriteTime(filepath).TimeOfDay) // 同じ日付内で時刻順に昇順でソート
                    .ToList();
            } catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

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
                selectedWorld = worldHashList[worldnameListBox.SelectedIndex];

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

        // エクスプローラーで開く
        private void openExplorer_Click(object sender, EventArgs e)
        {
            if (selectedWorld != null)
            {
                // MessageBox.Show(selectedWorld);
                //System.Diagnostics.Process.Start("EXPLORER.EXE", @selectedWorld);
                System.Diagnostics.Process.Start(@selectedWorld);
            }
            else
            {
                MessageBox.Show("ワールドを選択してください。");
            }
        }
        
        // VSCodeで開く
        private void openVscodeBtn_Click(object sender, EventArgs e)
        {
            if (selectedWorld != null)
            {
                MessageBox.Show(selectedWorld);
                //System.Diagnostics.Process.Start("EXPLORER.EXE", @selectedWorld);
                System.Diagnostics.Process.Start(vscodePathTxtBox.Text, @selectedWorld);
            }
            else
            {
                MessageBox.Show("ワールドを選択してください。");
            }
 
        }
 
        // ------------------------------------------------
        //                       xyz
        // ------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 値を取得してintに変換
                string[] xyzString = SplitFunc(xyzTextBox.Text);
                List<int> xyzList = new List<int>();
                for (int i = 0; i < xyzString.Length; i++)
                {
                    xyzList.Add(int.Parse(xyzString[i]));
                }

                // MessageBox.Show($"x: {xyzList[0]}, y: {xyzList[1]}, z: {xyzList[2]}");

                // x=111,y=222,z=333 の形にする
                string xyzComma = "";
                if (xyzList.Count == 3 ) {
                    xyzComma = $"x={xyzList[0]},y={xyzList[1]},z={xyzList[2]}";
                }
                else if (xyzList.Count == 6 ) {
                    MessageBox.Show("6変数は未実装です");
                }
                else
                {
                    MessageBox.Show("入力した値が間違っている可能性があります。");
                }

                // クリップボードに変換した値を入れる
                Clipboard.SetText(xyzComma);

            } catch (Exception exp) { 
                MessageBox.Show(exp.Message);
            }
        }
        private static string[] SplitFunc(string text)
        {
            var words = text.Split(new string[] { " ", "　" }, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }



        // ------------------------------------------------
        //                  環境設定
        // ------------------------------------------------
        private void worldOfdBtn_Click(object sender, EventArgs e)
        {
            using (var ofd = new CommonOpenFileDialog() { IsFolderPicker = true })
            {
                if (ofd.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    dirNameTextBox.Text = ofd.FileName;
                }
            }
        }

        private void vscodeOfdBtn_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog() { FileName = "code.exe", Filter = ".exeファイル | *.exe" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    vscodePathTxtBox.Text = ofd.FileName;
                }
            }
 
        }
    }
}
