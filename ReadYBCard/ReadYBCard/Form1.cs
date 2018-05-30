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

            //QueryReport(info.CardNo);
            QueryReport("1084285");
        }

        public void QueryReport(String cardNumber)
        {
            SqlConnection conn = new SqlConnection("Data Source=192.168.0.247\\SQL2005;Initial Catalog=JLEISDB2;Persist Security Info=True;User ID=jlxdt;Password=jlxdt");

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from v_report where KH='" + cardNumber + "'", conn);
  
                DataTable dt = new DataTable();

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);

                    if(dt != null && dt.Rows.Count > 0)
                    {
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = dt.AsDataView();

                  
                        labelAccountNo.Text = dt.Rows.Count.ToString();
                    }

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
