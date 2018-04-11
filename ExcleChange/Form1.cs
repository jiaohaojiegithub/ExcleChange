using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcleChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string ExcelChenge(string NumCard)
        {
            uint OldCard = uint.Parse(NumCard.Trim());
            uint eOldCard = OldCard % 100000;
            uint sOldCard = OldCard / 100000;
            byte[] send_byte = new byte[4];
            send_byte[3] = (byte)sOldCard;
            send_byte[0] = (byte)(eOldCard);
            send_byte[1] = (byte)(eOldCard >> 8);
            send_byte[2] = (byte)(eOldCard >> 16);
            int NewCard = 0;
            int x = 0;
            for (int j = 0; j < send_byte.Length; j++)
            {
                if (send_byte[j] == 0)
                {
                    x = j;
                }
                else
                {
                    NewCard = NewCard + (send_byte[j] << (x * 8));
                    x++;
                }
            }
            return NewCard.ToString();
        }
        private void butChange_Click(object sender, EventArgs e)
        {
            //14347742
            uint OldCard = uint.Parse(txtOld.Text.ToString().Trim());
            uint eOldCard = OldCard % 100000;//47742
            uint sOldCard = OldCard / 100000;//143
            byte[] send_byte = new byte[4];
            //for (int i = 0; i < send_byte.Length; i++)
            //{
            //    send_byte[i] = 0;
            //}
            send_byte[3] = (byte)sOldCard;//143 0x
            send_byte[0] = (byte)(eOldCard);
            send_byte[1] = (byte)(eOldCard >> 8);
            send_byte[2] = (byte)(eOldCard >> 16);
            int NewCard=0;
            int x = 0;
            for (int j = 0; j < send_byte.Length; j++)
            {
                if (send_byte[j] == 0)
                {
                    x = j;
                }
                else
                {
                    NewCard = NewCard + (send_byte[j] << (x * 8));
                    x++;
                }
            }

            //string sNewcard = "";
            //for (int j = (send_byte[0]).ToString().Length;j<4;j++)
            //{
            //sNewcard =(send_byte[0].ToString().Trim()).PadLeft(3,'0');
            //sNewcard += ((send_byte[1]) + (send_byte[2] << 8) + (send_byte[3] << 16)).ToString().PadLeft(5, '0');
            //}
           // MessageBox.Show(sNewcard);
           // int NewCard = ((send_byte[0]) + (send_byte[1] << 8) + (send_byte[2] << 16)+(send_byte[3]<<24));
            txtNew.Text = NewCard.ToString();

        }
        //判断字符串后面有几个0
        public int ChangeStr(string Cardstr)
        {
            int ZeroNum = 0;
            for (int i = 1; i < Cardstr.Length+1; i++)
            {
                if (Cardstr.Substring((Cardstr.Length - i), 1) == "0")
                    ZeroNum = ZeroNum + 1;
                else
                    break;
            }
            return ZeroNum;
        }
        private void butChangeInSite_Click(object sender, EventArgs e)
        {
            txtNew.Text = "";
            int Num = 0;
            //string strCard = txtCardInSite.Text.ToString().Trim().Replace("0*$", "");//无效

            string strCardTwo = txtCardInSite.Text.ToString().Trim();
            if (ChangeStr(strCardTwo) <= 6)
                Num = ChangeStr(strCardTwo);
            else
                Num = 6;
            string strCardOne = System.Text.RegularExpressions.Regex.Replace(strCardTwo, "0{"+Num+"}$", "");//去掉字符串后面所有的0
            //  MessageBox.Show(strCard + "\n" + strCardTwo.Substring(0, strCardTwo.Length - 6) + "\n" + strCardOne+"\n该值后面有"+ChangeStr(strCardTwo)+"个0");

            // txtNew.Text = CardInSite(strCardTwo.Substring(0, strCardTwo.Length - 6));
            txtNew.Text = CardInSite(strCardOne);
        }
        //场所卡号转我方卡号
        public string CardInSite(string CardSite)
        {
            uint str = uint.Parse(CardSite.ToString().Trim());
            int NewStr=0;
            byte[] str_byte = new byte[4];
            for (int i = 0; i < str_byte.Length; i++)
            {
                str_byte[i] = (byte)(str >> (8*i));
            }
            for (int j = 0; j < (str_byte.Length - 1); j++)
            {
                NewStr = NewStr+(str_byte[j] << (8 * j));
            }
            return NewStr.ToString();
        }

        private void txtOld_Enter(object sender, EventArgs e)
        {
            butChange.Enabled = true;
            butChangeInSite.Enabled = false;
        }

        private void txtCardInSite_Enter(object sender, EventArgs e)
        {
            butChange.Enabled = false;
            butChangeInSite.Enabled = true;
        }
    }
}
