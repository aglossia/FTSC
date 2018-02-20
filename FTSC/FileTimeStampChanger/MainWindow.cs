using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace FileTimeStampChanger
{
    /// <summary>
    /// ファイルの日付情報を編集するGUIアプリケーション
    /// </summary>
    public partial class MainWindow : Form
    {
        /// <summary>
        /// メインウィンドウ
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        static string[] files;

        /// <summary>
        /// ファイル選択ダイアログを開き、選択されたファイルの日時情報をテキストボックスに表示する 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            txtFileName.Text = ofd.FileName;
            //btnRead_Click(this, e);
        }

        /// <summary>
        /// ファイルの日付情報をテキストボックスに表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                string[] dateInfo = readFileInfo(txtFileName.Text);
                txtCreate.Text = dateInfo[0];
                txtUpdate.Text = dateInfo[1];
                txtAccess.Text = dateInfo[2];


            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("ファイルが見つかりません。");
            }
        }

        /// <summary>
        /// テキストボックスに入力された日付情報をファイルに書き込む
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string[] dateInfo = { txtCreate.Text, txtUpdate.Text, txtAccess.Text };
                writeFileInfo(txtFileName.Text, dateInfo);
                MessageBox.Show("日付情報を書き込みました。");
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("ファイルが見つかりません。");
            }
            catch (FormatException)
            {
                MessageBox.Show("日付の書式が異なります。\nyyyy/MM/dd HH:mm:ss");
            }
        }

        /// <summary>
        /// プログラムを終了する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// ファイルの日付情報を取得する
        /// </summary>
        /// <exception cref="FileNotFoundException"></exception>
        /// <param name="filename">ファイル名</param>
        /// <returns>日付情報のリスト。0:作成日,1:更新日,2:アクセス日</returns>
        private string[] readFileInfo(string filename)
        {
            string[] dateInfo = { "create", "update", "access" };
            if (File.Exists(filename))
            {
                dateInfo[0] = File.GetCreationTime(filename).ToString();
                dateInfo[1] = File.GetLastWriteTime(filename).ToString();
                dateInfo[2] = File.GetLastAccessTime(filename).ToString();
            }
            else
            {
                throw new FileNotFoundException();
            }
            return dateInfo;
        }

        /// <summary>
        /// ファイルに日付情報を書き込む
        /// </summary>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="FormatException"></exception>
        /// <param name="filename">ファイル名</param>
        /// <param name="dateInfo">日付情報のリスト。0:作成日,1:更新日,2:アクセス</param>
        private void writeFileInfo(string filename, string[] dateInfo)
        {
            if (File.Exists(filename))
            {
                string format = "yyyy/MM/dd HH:mm:ss";
                File.SetCreationTime(filename, DateTime.ParseExact(dateInfo[0], format, null));
                File.SetLastWriteTime(filename, DateTime.ParseExact(dateInfo[1], format, null));
                File.SetLastAccessTime(filename, DateTime.ParseExact(dateInfo[2], format, null));
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            /*
            // Random クラスの新しいインスタンスを生成する
            Random cRandom = new System.Random();

            // 0 以上の乱数を取得する
            int iResult1 = cRandom.Next();

            // 0 以上 512 未満の乱数を取得する
            int iResult2 = cRandom.Next(512);

            // 256 以上 512 未満の乱数を取得する
            int iResult3 = cRandom.Next(0, 999);

            //txtStartDate.Text = iResult3.ToString();
            
            int iResult4 = cRandom.Next(0, 3600);

            addtime += iResult4;

            int year = (int)yearUD.Value;
            int month = (int)monthUD.Value;
            int day = (int)dayUD.Value;
            int hour = (int)hourUD.Value;
            int min = (int)minUD.Value;
            int sec = (int)secUD.Value;
            DateTime dt = new DateTime(year, month, day, hour, min, sec, 123);

            string a = (FromDateTime(dt)+addtime).ToString();

            txtStartDate.Text = UnixTimeToDateTime(a).ToString();
            */

        }

        private void btnTest_Click_1(object sender, EventArgs e)
        {
            //string a = folderList.SelectedItems.ToString();
            string[] b = {};
            List<string> list = new List<string>(b);

            for(int i = 0 ; i < folderList.SelectedItems.Count ; i++){
                selectList.Items.Add(folderList.SelectedItems[i]);
                list.Add(folderList.SelectedItems[i].ToString());
            }

            //string a = listBox1.Items[1].ToString();

            //MessageBox.Show(folderList.SelectedItems[1].ToString());
            /*
            DialogResult result = MessageBox.Show("ファイルを上書きしますか？",
                "質問",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
             */
        }

        private void txtFolderName_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("a");
        }

        private void MainWindow_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("a");
        }

        private void aToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://toyotamayuko.com/");
        }












    }
}
