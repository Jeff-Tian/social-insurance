using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadYBCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 读取医保卡信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadCard_Click(object sender, EventArgs e)
        {
            try
            {
                RedCard(CardState.IC_Card);
            }
            catch (Exception err)
            {
                string s = err.ToString();
            }
        }
        public enum CardState
        {
            IC_Card,
            Card
        }
        public void RedCard(CardState cardstate)
        {

            YBLib.CardInfo info = YBLib.GetCardInfo;
            lblInfo.Text = "卡信息:" + info.CardInfoString();
            Console.WriteLine(info.CardInfoString());
            labelAccountNo.Text = info.CardNo;

            QueryReport(info.CardNo);
        }

        public void QueryReport(String cardNumber)
        {
            SqlConnection conn = new SqlConnection("user id=jlxdt;" +
                                       "password=jlxdt;server=192.168.0.247\\SQL2005;" +
                                       "Trusted_Connection=yes;" +
                                       "database=JLEISDB2;" +
                                       "connection timeout=30");

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    reader["xxx"].ToString();
                }

                conn.Close();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                labelAccountNo.Text = ex.ToString();
            }
            finally
            {
                conn.Dispose();
            }
        }
    }
}
