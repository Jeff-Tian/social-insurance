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
            this.btnReadCard = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.labelAccountNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReadCard
            // 
            this.btnReadCard.Location = new System.Drawing.Point(30, 30);
            this.btnReadCard.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 900);
            this.Controls.Add(this.labelAccountNo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnReadCard);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadCard;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label labelAccountNo;
    }
}

