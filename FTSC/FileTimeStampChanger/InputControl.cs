using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTimeStampChanger
{
    public partial class MainWindow
    {
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

    }
}
