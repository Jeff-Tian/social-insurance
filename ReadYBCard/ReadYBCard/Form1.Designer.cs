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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnReadCard = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Print = new System.Windows.Forms.DataGridViewButtonColumn();
            this.KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BRXM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JYSJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jLEISDB2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jLEISDB2DataSet = new ReadYBCard.JLEISDB2DataSet();
            this.axJLPrintECG1 = new AxJLPrintECGLib.AxJLPrintECG();
            this.button1 = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jLEISDB2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jLEISDB2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axJLPrintECG1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadCard
            // 
            this.btnReadCard.Location = new System.Drawing.Point(43, 17);
            this.btnReadCard.Margin = new System.Windows.Forms.Padding(8);
            this.btnReadCard.Name = "btnReadCard";
            this.btnReadCard.Size = new System.Drawing.Size(452, 130);
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
            this.Print,
            this.KH,
            this.BRXM,
            this.JYSJ,
            this.XDT});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(0, 834);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 44;
            this.dgv.Size = new System.Drawing.Size(1729, 685);
            this.dgv.TabIndex = 3;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // Print
            // 
            this.Print.HeaderText = "打印";
            this.Print.Name = "Print";
            this.Print.ReadOnly = true;
            this.Print.UseColumnTextForButtonValue = true;
            // 
            // KH
            // 
            this.KH.DataPropertyName = "KH";
            this.KH.HeaderText = "卡号";
            this.KH.Name = "KH";
            this.KH.ReadOnly = true;
            // 
            // BRXM
            // 
            this.BRXM.DataPropertyName = "BRXM";
            this.BRXM.HeaderText = "姓名";
            this.BRXM.Name = "BRXM";
            this.BRXM.ReadOnly = true;
            // 
            // JYSJ
            // 
            this.JYSJ.DataPropertyName = "JYSJ";
            this.JYSJ.HeaderText = "检查时间";
            this.JYSJ.Name = "JYSJ";
            this.JYSJ.ReadOnly = true;
            // 
            // XDT
            // 
            this.XDT.DataPropertyName = "XDT";
            this.XDT.HeaderText = "心电图";
            this.XDT.Name = "XDT";
            this.XDT.ReadOnly = true;
            // 
            // jLEISDB2DataSetBindingSource
            // 
            this.jLEISDB2DataSetBindingSource.DataSource = this.jLEISDB2DataSet;
            this.jLEISDB2DataSetBindingSource.Position = 0;
            // 
            // jLEISDB2DataSet
            // 
            this.jLEISDB2DataSet.DataSetName = "JLEISDB2DataSet";
            this.jLEISDB2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // axJLPrintECG1
            // 
            this.axJLPrintECG1.Enabled = true;
            this.axJLPrintECG1.Location = new System.Drawing.Point(1410, 38);
            this.axJLPrintECG1.Name = "axJLPrintECG1";
            this.axJLPrintECG1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axJLPrintECG1.OcxState")));
            this.axJLPrintECG1.Size = new System.Drawing.Size(68, 76);
            this.axJLPrintECG1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(773, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(506, 121);
            this.button1.TabIndex = 5;
            this.button1.Text = "打印";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(51, 191);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 30);
            this.lblInfo.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1729, 1519);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axJLPrintECG1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnReadCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Form1";
            this.Text = "报告打印";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jLEISDB2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jLEISDB2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axJLPrintECG1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadCard;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource jLEISDB2DataSetBindingSource;
        private JLEISDB2DataSet jLEISDB2DataSet;
        private AxJLPrintECGLib.AxJLPrintECG axJLPrintECG1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn Print;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRXM;
        private System.Windows.Forms.DataGridViewTextBoxColumn JYSJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn XDT;
        private System.Windows.Forms.Label lblInfo;
    }
}

