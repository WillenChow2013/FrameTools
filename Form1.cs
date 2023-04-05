using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameDataToolWinform
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            st_note.Text = "请输入待处理数据帧...";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_org.Text = "";
        }

        private void btn_process_Click(object sender, EventArgs e)
        {

            String tmpStr = Tools.RemoveNonHexCharacters(Tools.RemoveHexPrefix( txt_org.Text));
            if(tmpStr.Length%2 != 0)
            {
                st_note.Text = "输入的数据帧错误！";
            }
            else
            {
                txt_cksum8.Text = Tools.CalculateHex8BitChecksum(tmpStr)+"H";
                txt_cksum16.Text = Tools.CalculateHex16BitChecksum(tmpStr) + "H";

                txt_des.Text = Tools.AddSpaceBetweenChars(tmpStr);
                int len = Convert.ToInt32(tmpStr.Length / 2);
                txt_len.Text = "" + len;
                txt_lenHex.Text = "" + len.ToString("X");

                if (cmb_crcType.Text.Contains("CCITT-FALSE"))
                {
                    ushort tmpCrc = Tools.CalculateCrcCittFalse(tmpStr);
                    txt_crcRes.Text = tmpCrc.ToString("X4");
                }
                else if (cmb_crcType.Text.Contains("CRC-MODBUS"))
                {
                    ushort tmpCrc1 = Tools.GetCrc16Modbus(tmpStr);
                    txt_crcRes.Text = tmpCrc1.ToString("X4");
                }
                else 
                {
                    ushort tmpCrc1 = Tools.GetCrc8(tmpStr);
                    txt_crcRes.Text = tmpCrc1.ToString("X2");
                }


                st_note.Text = st_note.Text ;
            }
        }

        private void btn_rec2CFomart_Click(object sender, EventArgs e)
        {
            String tmpStr = Tools.HexToCString(txt_des.Text);
            txt_des.Text = tmpStr;
        }

        private void btn_org2AscII_Click(object sender, EventArgs e)
        {
            String tmpStr = Tools.StringToAsciiCode(txt_org.Text);
            txt_des.Text = tmpStr;
        }

        private void btn_orgAscII2Char_Click(object sender, EventArgs e)
        {
            
            String tmpStr = Tools.ConvertToAsciiString(txt_org.Text);
            txt_des.Text = tmpStr;
        }

        private void txt_org_TextChanged(object sender, EventArgs e)
        {
            // 如果目标按钮可用，则模拟用户点击
            if (btn_process.Enabled)
            {
                btn_process.PerformClick();
            }
        }
    }
}
