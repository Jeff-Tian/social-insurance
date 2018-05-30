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
            this.btnReadCard = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.labelAccountNo = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.jLEISDB2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jLEISDB2DataSet = new ReadYBCard.JLEISDB2DataSet();
            this.KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BRXM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JYSJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jLEISDB2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jLEISDB2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadCard
            // 
            this.btnReadCard.Location = new System.Drawing.Point(30, 30);
            this.btnReadCard.Margin = new System.Windows.Forms.Padding(8);
            this.btnReadCard.Name = "btnReadCard";
            this.btnReadCard.Size = new System.Drawing.Size(188, 58);
            this.btnReadCard.TabIndex = 0;
            this.btnReadCard.Text = "读取医保卡信息";
            this.btnReadCard.UseVisualStyleBackColor = true;
            this.btnReadCard.Click += new System.EventHandler(this.btnReadCard_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(30, 122);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(103, 30);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "label1";
            // 
            // labelAccountNo
            // 
            this.labelAccountNo.AutoSize = true;
            this.labelAccountNo.Location = new System.Drawing.Point(35, 372);
            this.labelAccountNo.Name = "labelAccountNo";
            this.labelAccountNo.Size = new System.Drawing.Size(103, 30);
            this.labelAccountNo.TabIndex = 2;
            this.labelAccountNo.Text = "label1";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KH,
            this.BRXM,
            this.JYSJ});
            this.dgv.Location = new System.Drawing.Point(12, 523);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 44;
            this.dgv.Size = new System.Drawing.Size(1737, 539);
            this.dgv.TabIndex = 3;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1751, 1091);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.labelAccountNo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnReadCard);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jLEISDB2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jLEISDB2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadCard;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label labelAccountNo;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource jLEISDB2DataSetBindingSource;
        private JLEISDB2DataSet jLEISDB2DataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRXM;
        private System.Windows.Forms.DataGridViewTextBoxColumn JYSJ;
    }
}

