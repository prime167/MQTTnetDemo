namespace MqttNetServer
{
    partial class FrmMqttServer
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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            panel2 = new System.Windows.Forms.Panel();
            lblClientCount = new System.Windows.Forms.Label();
            BtnStop = new System.Windows.Forms.Button();
            TxbPort = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            TxbServer = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            BtnStart = new System.Windows.Forms.Button();
            listBox1 = new System.Windows.Forms.ListBox();
            panel1 = new System.Windows.Forms.Panel();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(listBox1, 0, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(933, 638);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblClientCount);
            panel2.Controls.Add(BtnStop);
            panel2.Controls.Add(TxbPort);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(TxbServer);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(BtnStart);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(4, 4);
            panel2.Margin = new System.Windows.Forms.Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(925, 49);
            panel2.TabIndex = 0;
            // 
            // lblClientCount
            // 
            lblClientCount.AutoSize = true;
            lblClientCount.Location = new System.Drawing.Point(692, 20);
            lblClientCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblClientCount.Name = "lblClientCount";
            lblClientCount.Size = new System.Drawing.Size(78, 17);
            lblClientCount.TabIndex = 6;
            lblClientCount.Text = "Client Count";
            // 
            // BtnStop
            // 
            BtnStop.Location = new System.Drawing.Point(388, 5);
            BtnStop.Margin = new System.Windows.Forms.Padding(4);
            BtnStop.Name = "BtnStop";
            BtnStop.Size = new System.Drawing.Size(88, 40);
            BtnStop.TabIndex = 5;
            BtnStop.Text = "Stop";
            BtnStop.UseVisualStyleBackColor = true;
            BtnStop.Click += BtnStop_Click;
            // 
            // TxbPort
            // 
            TxbPort.Location = new System.Drawing.Point(223, 13);
            TxbPort.Margin = new System.Windows.Forms.Padding(4);
            TxbPort.Name = "TxbPort";
            TxbPort.Size = new System.Drawing.Size(51, 23);
            TxbPort.TabIndex = 4;
            TxbPort.Text = "1883";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(182, 20);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(32, 17);
            label2.TabIndex = 3;
            label2.Text = "Port";
            // 
            // TxbServer
            // 
            TxbServer.Location = new System.Drawing.Point(58, 13);
            TxbServer.Margin = new System.Windows.Forms.Padding(4);
            TxbServer.Name = "TxbServer";
            TxbServer.Size = new System.Drawing.Size(116, 23);
            TxbServer.TabIndex = 2;
            TxbServer.Text = "192.168.22.148";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 20);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 17);
            label1.TabIndex = 1;
            label1.Text = "Server";
            // 
            // BtnStart
            // 
            BtnStart.Location = new System.Drawing.Point(294, 4);
            BtnStart.Margin = new System.Windows.Forms.Padding(4);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new System.Drawing.Size(88, 40);
            BtnStart.TabIndex = 0;
            BtnStart.Text = "Start";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // listBox1
            // 
            listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new System.Drawing.Point(4, 61);
            listBox1.Margin = new System.Windows.Forms.Padding(4);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(925, 573);
            listBox1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(933, 638);
            panel1.TabIndex = 1;
            // 
            // FrmMqttServer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 638);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "FrmMqttServer";
            Text = "MqttServer";
            Load += FrmMqttServer_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxbPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblClientCount;
    }
}

