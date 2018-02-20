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
        private void folderOpen_Click(object sender, EventArgs e)
        {
            folderList.Items.Clear();
            var directory = txtFolderName.Text;
            var x = new System.IO.DirectoryInfo(directory);
            folderList.Items.AddRange(x.GetFiles("*"));
            
            //指定フォルダ以下のファイルをすべて取得する
            files = System.IO.Directory.GetFiles
                (
                txtFolderName.Text,
                "*",
                System.IO.SearchOption.AllDirectories
                );
        }

        private void btnWriteFolder_Click(object sender, EventArgs e)
        {
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
            

            int year = (int)yearUD.Value;
            int month = (int)monthUD.Value;
            int day = (int)dayUD.Value;
            int hour = (int)hourUD.Value;
            int min = (int)minUD.Value;
            int sec = (int)secUD.Value;
            DateTime dt = new DateTime(year, month, day, hour, min, sec, 123);
            string format = "yyyy/MM/dd HH:mm:ss";

            foreach(string x in files){

                addTime += cRandom.Next(stepStart, stepEnd);

                tx = utility.UnixTimeToDateTime((utility.FromDateTime(dt)+addTime).ToString()).ToString("yyyy/MM/dd HH:mm:ss");

                File.SetCreationTime(x, DateTime.ParseExact(tx, format, null));
                File.SetLastWriteTime(x, DateTime.ParseExact(tx, format, null));
                File.SetLastAccessTime(x, DateTime.ParseExact(tx, format, null));
            }
        }
    }
}
