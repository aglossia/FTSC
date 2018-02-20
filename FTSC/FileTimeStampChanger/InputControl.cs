using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace FileTimeStampChanger
{
    public partial class MainWindow
    {

        static int disc = 0;

        // 年入力
        private void yearUD_ValueChanged(object sender, EventArgs e)
        {
            if (yearUD.Value == 2051)
            {
                yearUD.Value = 1970;
            }
            if (yearUD.Value == 1969)
            {
                yearUD.Value = 2050;
            }
        }

        // 月入力
        private void monthUD_ValueChanged(object sender, EventArgs e)
        {
            if (monthUD.Value == 13)
            {
                monthUD.Value = 1;
            }
            if (monthUD.Value == 0)
            {
                monthUD.Value = 12;
            }
        }

        // 日入力
        private void dayUD_ValueChanged(object sender, EventArgs e)
        {
            if (dayUD.Value == 32)
            {
                dayUD.Value = 1;
            }
            if (dayUD.Value == 0)
            {
                dayUD.Value = 31;
            }
        }

        // 時入力
        private void hourUD_ValueChanged(object sender, EventArgs e)
        {
            if (hourUD.Value == 24)
            {
                hourUD.Value = 0;
            }
            if (hourUD.Value == -1)
            {
                hourUD.Value = 23;
            }
        }

        // 分入力
        private void minUD_ValueChanged(object sender, EventArgs e)
        {
            if (minUD.Value == 60)
            {
                minUD.Value = 0;
            }
            if (minUD.Value == -1)
            {
                minUD.Value = 59;
            }
        }


        // 秒入力
        private void secUD_ValueChanged(object sender, EventArgs e)
        {
            if (secUD.Value == 60)
            {
                secUD.Value = 0;
            }
            if (secUD.Value == -1)
            {
                secUD.Value = 59;
            }
        }

        private void txtFolderName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter){
                folderOpen.PerformClick();
            }
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;

            if (e.KeyData == Keys.Left)
            {
                if ((disc & 0x3) != 0)
                {
                    disc |= 0x4;
                }
                else
                {
                    disc |= 0x1;
                }

            }
            else if (e.KeyData == Keys.Right && (disc & 0x1) != 0)
            {
                if ((disc & 0x1) != 0)
                {
                    disc |= 0x2;
                } else if ((disc & 0x7) != 0)
                {
                    MessageBox.Show("congratulations!!!");
                }

            }
            testBox.Text = disc.ToString();

            shift = 1;
        }

        //static TabControlCancelEventArgs a ;
        static int shift = 0;
        
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //tabControl1.SelectedTab = tabPage1;
            //MessageBox.Show("aa");
            //2番目のタブを選択できないようにする
            if (e.TabPageIndex == 1)
            {
               // e.Cancel = true;
            }
            
        }
        
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            
            if (shift == 0){
                if (e.TabPageIndex == 1)
                {
                tabControl1.SelectedTab = tabPage2;
                }
                if (e.TabPageIndex == 2)
                {
                tabControl1.SelectedTab = tabPage1;
                }
            }
            else
            {
                if (e.TabPageIndex == 1)
                {
                tabControl1.SelectedTab = tabPage1;
                }
                if (e.TabPageIndex == 2)
                {
                tabControl1.SelectedTab = tabPage2;
                }
                shift = 0;
            }
            

        }
        
    }
}
