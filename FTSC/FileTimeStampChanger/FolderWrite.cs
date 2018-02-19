using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileTimeStampChanger
{
    public partial class MainWindow
    {
        static Boolean selectFlag = false;

        static string[] b = {};
        List<string> list = new List<string>(b);

        private void folderOpen_Click(object sender, EventArgs e)
        {
            folderList.Items.Clear();
            var directory = txtFolderName.Text;
            var x = new System.IO.DirectoryInfo(directory);
            try{
                folderList.Items.AddRange(x.GetFiles("*"));
            }
            catch(DirectoryNotFoundException)
            {
                MessageBox.Show("指定されたフォルダが見つかりません");
                return;
            }
            
            
            //指定フォルダ以下のファイルをすべて取得する
            files = System.IO.Directory.GetFiles
                (
                txtFolderName.Text,
                "*",
                System.IO.SearchOption.AllDirectories
                );
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //string path = System.IO.Path.GetDirectoryName(txtFolderName.Text);
            selectList.Items.Clear();

            for(int i = 0 ; i < folderList.SelectedItems.Count ; i++){
                selectList.Items.Add(folderList.SelectedItems[i]);
                list.Add(txtFolderName.Text + "\\" + folderList.SelectedItems[i].ToString());
            }

            selectFlag = true;

        }

        private void btnSelectClear_Click(object sender, EventArgs e)
        {
            selectList.Items.Clear();
            list.Clear();
            selectFlag = false;
        }


        private void btnWriteFolder_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("ファイルを上書きしますか？",
                "質問",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            //何が選択されたか調べる

            if (result == DialogResult.Yes)
            {

            }
            else if (result == DialogResult.No)
            {
                return;
            }

            string[] changeArray;
            Random cRandom = new System.Random();

            utility util = new utility();

            int addTime = 0;
            int stepStart = 0;
            int stepEnd = 0;
            string tx;

            if (txtStepStart.Text.Length == 0)
            {
                //MessageBox.Show("ステップスタートは空です");
                stepStart = 0;
            }else
            {
                stepStart = int.Parse(txtStepStart.Text)*60;
            }
            
            if (txtStepEnd.Text.Length == 0)
            {
                //MessageBox.Show("ステップエンドは空です");
                stepEnd = 1*60;
            }else
            {
                stepEnd = int.Parse(txtStepEnd.Text)*60;
            }
            
            if (selectFlag == false){
                changeArray = files;
            }
            else
            {
                changeArray = list.ToArray();
            }

            int year = (int)yearUD.Value;
            int month = (int)monthUD.Value;
            int day = (int)dayUD.Value;
            int hour = (int)hourUD.Value;
            int min = (int)minUD.Value;
            int sec = (int)secUD.Value;
            DateTime dt = new DateTime(year, month, day, hour, min, sec, 123);
            string format = "yyyy/MM/dd HH:mm:ss";

            foreach(string x in changeArray){

                addTime += cRandom.Next(stepStart, stepEnd);

                tx = utility.UnixTimeToDateTime((utility.FromDateTime(dt)+addTime).ToString()).ToString("yyyy/MM/dd HH:mm:ss");

                File.SetCreationTime(x, DateTime.ParseExact(tx, format, null));
                File.SetLastWriteTime(x, DateTime.ParseExact(tx, format, null));
                File.SetLastAccessTime(x, DateTime.ParseExact(tx, format, null));
            }

            if (chkboxNotice.Checked == true) { 
                MessageBox.Show("write finish");
            }


        }
    }
}
