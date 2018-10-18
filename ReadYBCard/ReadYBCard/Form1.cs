using System;
using System.Data;
using System.Data.SqlClient;
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
                ReadCard();
            }
            catch (Exception err)
            {
                string s = err.ToString();

                string cardNumber = this.txtCardNumber.Text;
                if (cardNumber != "")
                {
                    QueryReport(cardNumber);
                }
                else
                {
                    MessageBox.Show(s);
                }
            }
        }

        public void ReadCard()
        {
            QueryReport(GetCardNumber());
            //QueryReport("K04185546");
        }

        public void QueryReport(String cardNumber)
        {
            //SqlConnection conn = new SqlConnection("Data Source=192.168.0.247\\SQL2005;Initial Catalog=JLEISDB2;Persist Security Info=True;User ID=jlxdt;Password=jlxdt");
            string connectionString =
                System.Configuration.ConfigurationManager.ConnectionStrings["main"].ConnectionString;
            //MessageBox.Show(connectionString);

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from JLEISDB2.dbo.v_report where KH = '" + cardNumber + "'",
                    conn);


                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    dt = new DataTable();
                    da.Fill(dt);

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = dt.AsDataView();
                        button1.Enabled = true;

                        this.dgv_CellClick(null, new DataGridViewCellEventArgs(0, 0));
                    }
                    else
                    {
                        button1.Enabled = false;
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string iniPath = System.Configuration.ConfigurationManager.AppSettings["iniPath"];
            iniPath = System.IO.Path.GetFullPath("./print.ini");

            int res = axJLPrintECG1.setPrintTemplateUrl(iniPath);
            if (res != 0)
            {
                res = axJLPrintECG1.setPrintTemplateUrl(iniPath);

                if (res != 0)
                {
                    res = axJLPrintECG1.setPrintTemplateUrl(iniPath);
                    MessageBox.Show("设置 ini 发生错误： " + res.ToString());
                }
            }


            int returnValue = axJLPrintECG1.printEcgPaper(0);

            if (returnValue != 0)
            {
                switch (returnValue)
                {
                    case 6008:
                        MessageBox.Show("打印发生其他错误，请稍后再试。");
                        break;
                    default:
                        MessageBox.Show("打印发生未知错误，请稍后再试。");
                        break;
                }
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow row = dt.Rows[e.RowIndex];


            DateTime birthday = (DateTime) row["birthday"];
            DateTime now = DateTime.Now;
            TimeSpan diff = now.Subtract(birthday);

            axJLPrintECG1.setEcgBinData(row["XDT"]);
            axJLPrintECG1.setEcgData(row["XDT"].ToString());
            axJLPrintECG1.setComment(row["ZD"].ToString(), row["BGRXM"].ToString());
            axJLPrintECG1.setMeasureBinData(row["measuredata"]);
            axJLPrintECG1.setMeasureData(row["measuredata"].ToString());
            axJLPrintECG1.setPatientInfo(row["KH"].ToString(), row["BRXM"].ToString(),
                row["BRXB"].ToString().Equals("1") ? "男" : "女", "", (int) (diff.Days / 365), "");


            //this.labelSelectedInfo.Text = "选中了第 " + (e.RowIndex + 1).ToString() + " 行。";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnReadCard.Left = (this.Width - this.btnReadCard.Width) / 2;
            this.button1.Left = (this.Width - this.button1.Width) / 2;
            this.button2.Left = (this.Width - this.button2.Width) / 2;
            this.lblCardNumber.Left = this.btnReadCard.Left;
            this.txtCardNumber.Left = this.btnReadCard.Right - this.txtCardNumber.Width;
            txtCardNumber.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dgv.DataSource = new DataTable();
            this.button1.Enabled = false;

            Application.Exit();
        }

        private void lblCardNumber_Click(object sender, EventArgs e)
        {
            GetCardNumber();
        }

        private string GetCardNumber()
        {
            YBLib.CardInfo info = YBLib.GetCardInfo;
            txtCardNumber.Text = info.CardNo.Trim();

            return txtCardNumber.Text;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            txtCardNumber.Focus();
        }

        private void tmrReadCard_Tick(object sender, EventArgs e)
        {
            if (txtCardNumber.Text.Length == 0)
            {
                GetCardNumber();
            }
        }
    }
}