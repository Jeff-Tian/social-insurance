using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ReadYBCard
{
    public class YBLib
    {
        [DllImport("SendRcv2.dll")]
        public static extern int SendRcv2(String pStartParam, String pSend, byte[] pRcv);
        //启动参数定义
        public static string startCode = "12345678";
        //发送消息常量定义
        public static string sendBeginCode = "SSSSS000    ";
        public static string sendEndCode = "ZZZZ";
        public static string sendMsgReturnCode = "".PadRight(4, ' ');
        public static string sendTime = "".PadRight(16, ' ');
        public static string sendInceptTime = "".PadRight(16, ' ');
        public static string sendSysHint = "".PadRight(40, ' ');
        public static string sendSys = "".PadRight(60, ' ');
        public YBLib()
        {

        }
        public byte[] Send(string pSend)
        {
            byte[] RevMessage = new byte[512];
            string strSend;
            strSend = sendBeginCode + "99999999800     " + "01".PadRight(4, ' ') + sendTime + sendInceptTime +
                      "".PadRight(344, ' ') +
                      sendSysHint + sendSys + sendEndCode;
            //System.Windows.Forms.MessageBox.Show(strSend.Length.ToString());
            SendRcv2(startCode, strSend, RevMessage);
            return RevMessage;
        }


        public static CardInfo GetCardInfo
        {
            get
            {

                CardInfo info = new CardInfo();
                YBLib obj = new YBLib();
                byte[] pRcv = obj.Send("");

                info.CardNo = Encoding.Default.GetString(pRcv, 64, 9);
                info.Name = Encoding.Default.GetString(pRcv, 73, 30);
                info.Sex = Encoding.Default.GetString(pRcv, 103, 1);
                info.IdNo = Encoding.Default.GetString(pRcv, 104, 18);
                info.Phone = Encoding.Default.GetString(pRcv, 122, 15);
                info.Addr = Encoding.Default.GetString(pRcv, 137, 80);

                return info;
            }
        }

        public class CardInfo
        {

            string cardNo;
            /// <summary>
            /// 卡号
            /// </summary>
            public string CardNo
            {
                get { return cardNo; }
                set { cardNo = value; }
            }
            string name;
            /// <summary>
            /// 姓名
            /// </summary>
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            string sex;
            /// <summary>
            /// 性别
            /// </summary>
            public string Sex
            {
                get { return sex; }
                set { sex = value; }
            }

            string idNo;
            /// <summary>
            /// 身份证
            /// </summary>
            public string IdNo
            {
                get { return idNo; }
                set { idNo = value; }
            }

            string phone;
            /// <summary>
            /// 电话
            /// </summary>
            public string Phone
            {
                get { return phone; }
                set { phone = value; }
            }

            string addr;
            /// <summary>
            /// 地址
            /// </summary>
            public string Addr
            {
                get { return addr; }
                set { addr = value; }
            }

            public string CardInfoString()
            {
                return   "姓名:"+this.Name+"\r 证件号码:"+this.IdNo+"\r 卡号:"+this.CardNo+"\r 性别:"+this.Sex+"\r 电话:"+this.Phone+"\r  地址:"+this.Addr;
            }
        }
    }
}
