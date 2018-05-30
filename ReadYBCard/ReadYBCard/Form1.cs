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
        private DataTable dt = new DataTable();

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

            //QueryReport(info.CardNo);
            QueryReport("F02545847");
        }

        public void QueryReport(String cardNumber)
        {
            SqlConnection conn = new SqlConnection("Data Source=192.168.0.247\\SQL2005;Initial Catalog=JLEISDB2;Persist Security Info=True;User ID=jlxdt;Password=jlxdt");

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from JLEISDB2.dbo.v_report where KH = '" + cardNumber + "'", conn);
                      

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);

                    if(dt != null && dt.Rows.Count > 0)
                    {
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = dt.AsDataView();
                        button1.Enabled = true;
                    }
                    else
                    {
                        button1.Enabled = false;
                    }

                }

                conn.Close();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //axJLPrintECG1.setPrintTemplateUrl(@"C:\Users\Jeff\Documents\WeChat Files\jie-tian\Files\JLCtrls\print.ini");

            axJLPrintECG1.printEcgPaper(0);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow row = dt.Rows[e.RowIndex];
            axJLPrintECG1.setEcgBinData(row["XDT"]);
            axJLPrintECG1.setEcgData(row["XDT"].ToString());
            axJLPrintECG1.setComment(row["ZD"].ToString(), row["BGRXM"].ToString());
            axJLPrintECG1.setMeasureBinData(row["XDT"]);
            axJLPrintECG1.setMeasureData(row["XDT"].ToString());
            axJLPrintECG1.setPatientInfo(row["KH"].ToString(), row["BRXM"].ToString(), row["BRXB"].ToString().Equals("1") ? "男" : "女", "", (int)row["age"], "");
        }
    }
}
