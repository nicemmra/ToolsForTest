namespace SerialPortTest
{
    partial class frmSerialPortTest
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPortName = new System.Windows.Forms.TextBox();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.rtxtReceiveData = new System.Windows.Forms.RichTextBox();
            this.rtxtSendCommand = new System.Windows.Forms.RichTextBox();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.btnOpenConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPortName
            // 
            this.txtPortName.Location = new System.Drawing.Point(25, 23);
            this.txtPortName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPortName.Name = "txtPortName";
            this.txtPortName.Size = new System.Drawing.Size(109, 21);
            this.txtPortName.TabIndex = 0;
            this.txtPortName.Text = "com3";
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(166, 23);
            this.txtBaudRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(115, 21);
            this.txtBaudRate.TabIndex = 0;
            this.txtBaudRate.Text = "115200";
            // 
            // rtxtReceiveData
            // 
            this.rtxtReceiveData.Location = new System.Drawing.Point(25, 48);
            this.rtxtReceiveData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtxtReceiveData.Name = "rtxtReceiveData";
            this.rtxtReceiveData.Size = new System.Drawing.Size(343, 141);
            this.rtxtReceiveData.TabIndex = 2;
            this.rtxtReceiveData.Text = "";
            // 
            // rtxtSendCommand
            // 
            this.rtxtSendCommand.Location = new System.Drawing.Point(25, 193);
            this.rtxtSendCommand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtxtSendCommand.Name = "rtxtSendCommand";
            this.rtxtSendCommand.Size = new System.Drawing.Size(268, 35);
            this.rtxtSendCommand.TabIndex = 2;
            this.rtxtSendCommand.Text = "";
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Location = new System.Drawing.Point(310, 193);
            this.btnSendCommand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(56, 34);
            this.btnSendCommand.TabIndex = 1;
            this.btnSendCommand.Text = "发送";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.btnSendCommand_Click);
            // 
            // btnOpenConnect
            // 
            this.btnOpenConnect.Location = new System.Drawing.Point(299, 22);
            this.btnOpenConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenConnect.Name = "btnOpenConnect";
            this.btnOpenConnect.Size = new System.Drawing.Size(67, 22);
            this.btnOpenConnect.TabIndex = 1;
            this.btnOpenConnect.Text = "打开串口";
            this.btnOpenConnect.UseVisualStyleBackColor = true;
            this.btnOpenConnect.Click += new System.EventHandler(this.btnOpenConnect_Click);
            // 
            // frmSerialPortTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 376);
            this.Controls.Add(this.rtxtSendCommand);
            this.Controls.Add(this.rtxtReceiveData);
            this.Controls.Add(this.btnSendCommand);
            this.Controls.Add(this.btnOpenConnect);
            this.Controls.Add(this.txtBaudRate);
            this.Controls.Add(this.txtPortName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSerialPortTest";
            this.Text = "串口测试";
            this.Load += new System.EventHandler(this.frmSerialPortTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPortName;
        private System.Windows.Forms.TextBox txtBaudRate;
        private System.Windows.Forms.RichTextBox rtxtReceiveData;
        private System.Windows.Forms.RichTextBox rtxtSendCommand;
        private System.Windows.Forms.Button btnSendCommand;
        private System.Windows.Forms.Button btnOpenConnect;
    }
}

