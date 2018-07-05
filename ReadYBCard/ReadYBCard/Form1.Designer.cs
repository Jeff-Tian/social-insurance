namespace ReadYBCard
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnReadCard = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BRXM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JYSJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jLEISDB2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.axJLPrintECG1 = new AxJLPrintECGLib.AxJLPrintECG();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jLEISDB2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axJLPrintECG1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadCard
            // 
            this.btnReadCard.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReadCard.Location = new System.Drawing.Point(149, 127);
            this.btnReadCard.Name = "btnReadCard";
            this.btnReadCard.Size = new System.Drawing.Size(398, 84);
            this.btnReadCard.TabIndex = 0;
            this.btnReadCard.Text = "查找心电报告";
            this.btnReadCard.UseVisualStyleBackColor = true;
            this.btnReadCard.Click += new System.EventHandler(this.btnReadCard_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KH,
            this.BRXM,
            this.JYSJ});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(0, 176);
            this.dgv.Margin = new System.Windows.Forms.Padding(1);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 44;
            this.dgv.Size = new System.Drawing.Size(692, 297);
            this.dgv.TabIndex = 3;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // KH
            // 
            this.KH.DataPropertyName = "KH";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.KH.DefaultCellStyle = dataGridViewCellStyle4;
            this.KH.HeaderText = "卡号";
            this.KH.Name = "KH";
            this.KH.ReadOnly = true;
            // 
            // BRXM
            // 
            this.BRXM.DataPropertyName = "BRXM";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BRXM.DefaultCellStyle = dataGridViewCellStyle5;
            this.BRXM.HeaderText = "姓名";
            this.BRXM.Name = "BRXM";
            this.BRXM.ReadOnly = true;
            // 
            // JYSJ
            // 
            this.JYSJ.DataPropertyName = "JYSJ";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.JYSJ.DefaultCellStyle = dataGridViewCellStyle6;
            this.JYSJ.HeaderText = "检查时间";
            this.JYSJ.Name = "JYSJ";
            this.JYSJ.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(149, 227);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(398, 79);
            this.button1.TabIndex = 5;
            this.button1.Text = "打印";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(149, 324);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(398, 76);
            this.button2.TabIndex = 6;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("宋体", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCardNumber.Location = new System.Drawing.Point(251, 74);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(1);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(299, 41);
            this.txtCardNumber.TabIndex = 7;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCardNumber.Location = new System.Drawing.Point(152, 81);
            this.lblCardNumber.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(79, 33);
            this.lblCardNumber.TabIndex = 8;
            this.lblCardNumber.Text = "卡号";
            // 
            // axJLPrintECG1
            // 
            this.axJLPrintECG1.Enabled = true;
            this.axJLPrintECG1.Location = new System.Drawing.Point(605, 13);
            this.axJLPrintECG1.Name = "axJLPrintECG1";
            this.axJLPrintECG1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axJLPrintECG1.OcxState")));
            this.axJLPrintECG1.Size = new System.Drawing.Size(100, 50);
            this.axJLPrintECG1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 473);
            this.Controls.Add(this.axJLPrintECG1);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnReadCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "报告打印";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jLEISDB2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axJLPrintECG1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadCard;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource jLEISDB2DataSetBindingSource;
        
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRXM;
        private System.Windows.Forms.DataGridViewTextBoxColumn JYSJ;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblCardNumber;
        private AxJLPrintECGLib.AxJLPrintECG axJLPrintECG1;
    }
}

