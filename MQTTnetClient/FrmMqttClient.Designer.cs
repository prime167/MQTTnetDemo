namespace MqttNetClient
{
    partial class FrmMqttClient
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
            panel1 = new System.Windows.Forms.Panel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            panel2 = new System.Windows.Forms.Panel();
            BtnMultiDisConnect = new System.Windows.Forms.Button();
            BtnMultiConnect = new System.Windows.Forms.Button();
            TxbConnectCount = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            BtnDisConnect = new System.Windows.Forms.Button();
            TxbPort = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            TxbServer = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            BtnConnect = new System.Windows.Forms.Button();
            listBox1 = new System.Windows.Forms.ListBox();
            panel3 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            CmbSubMqttQuality = new System.Windows.Forms.ComboBox();
            txbSubscribe = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            BtnSubscribe = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            label8 = new System.Windows.Forms.Label();
            CmbPubMqttQuality = new System.Windows.Forms.ComboBox();
            TxbTopic = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            panel5 = new System.Windows.Forms.Panel();
            TxbPayload = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            BtnSend = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(933, 638);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(listBox1, 0, 2);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel4, 0, 3);
            tableLayoutPanel1.Controls.Add(panel5, 0, 4);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            tableLayoutPanel1.Size = new System.Drawing.Size(933, 638);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnMultiDisConnect);
            panel2.Controls.Add(BtnMultiConnect);
            panel2.Controls.Add(TxbConnectCount);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(BtnDisConnect);
            panel2.Controls.Add(TxbPort);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(TxbServer);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(BtnConnect);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(4, 4);
            panel2.Margin = new System.Windows.Forms.Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(925, 49);
            panel2.TabIndex = 0;
            // 
            // BtnMultiDisConnect
            // 
            BtnMultiDisConnect.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            BtnMultiDisConnect.Location = new System.Drawing.Point(835, 6);
            BtnMultiDisConnect.Margin = new System.Windows.Forms.Padding(4);
            BtnMultiDisConnect.Name = "BtnMultiDisConnect";
            BtnMultiDisConnect.Size = new System.Drawing.Size(86, 37);
            BtnMultiDisConnect.TabIndex = 26;
            BtnMultiDisConnect.Text = "DisConnect";
            BtnMultiDisConnect.UseVisualStyleBackColor = true;
            BtnMultiDisConnect.Click += BtnMultiDisConnect_Click;
            // 
            // BtnMultiConnect
            // 
            BtnMultiConnect.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            BtnMultiConnect.Location = new System.Drawing.Point(732, 6);
            BtnMultiConnect.Margin = new System.Windows.Forms.Padding(4);
            BtnMultiConnect.Name = "BtnMultiConnect";
            BtnMultiConnect.Size = new System.Drawing.Size(86, 37);
            BtnMultiConnect.TabIndex = 25;
            BtnMultiConnect.Text = "Connect";
            BtnMultiConnect.UseVisualStyleBackColor = true;
            BtnMultiConnect.Click += BtnMultiConnect_Click;
            // 
            // TxbConnectCount
            // 
            TxbConnectCount.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            TxbConnectCount.Location = new System.Drawing.Point(608, 7);
            TxbConnectCount.Margin = new System.Windows.Forms.Padding(4);
            TxbConnectCount.Name = "TxbConnectCount";
            TxbConnectCount.Size = new System.Drawing.Size(116, 23);
            TxbConnectCount.TabIndex = 24;
            TxbConnectCount.Text = "10";
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(539, 16);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(42, 17);
            label6.TabIndex = 23;
            label6.Text = "Count";
            // 
            // BtnDisConnect
            // 
            BtnDisConnect.Location = new System.Drawing.Point(388, 6);
            BtnDisConnect.Margin = new System.Windows.Forms.Padding(4);
            BtnDisConnect.Name = "BtnDisConnect";
            BtnDisConnect.Size = new System.Drawing.Size(88, 40);
            BtnDisConnect.TabIndex = 5;
            BtnDisConnect.Text = "DisConnect";
            BtnDisConnect.UseVisualStyleBackColor = true;
            BtnDisConnect.Click += BtnDisConnect_Click;
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
            // BtnConnect
            // 
            BtnConnect.Location = new System.Drawing.Point(294, 4);
            BtnConnect.Margin = new System.Windows.Forms.Padding(4);
            BtnConnect.Name = "BtnConnect";
            BtnConnect.Size = new System.Drawing.Size(88, 40);
            BtnConnect.TabIndex = 0;
            BtnConnect.Text = "Connect";
            BtnConnect.UseVisualStyleBackColor = true;
            BtnConnect.Click += BtnConnect_Click;
            // 
            // listBox1
            // 
            listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new System.Drawing.Point(4, 118);
            listBox1.Margin = new System.Windows.Forms.Padding(4);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(925, 402);
            listBox1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(CmbSubMqttQuality);
            panel3.Controls.Add(txbSubscribe);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(BtnSubscribe);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(4, 61);
            panel3.Margin = new System.Windows.Forms.Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(925, 49);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(544, 16);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(160, 17);
            label3.TabIndex = 22;
            label3.Text = "MqttQualityOfServiceLevel";
            // 
            // CmbSubMqttQuality
            // 
            CmbSubMqttQuality.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            CmbSubMqttQuality.FormattingEnabled = true;
            CmbSubMqttQuality.Location = new System.Drawing.Point(732, 11);
            CmbSubMqttQuality.Margin = new System.Windows.Forms.Padding(4);
            CmbSubMqttQuality.Name = "CmbSubMqttQuality";
            CmbSubMqttQuality.Size = new System.Drawing.Size(96, 25);
            CmbSubMqttQuality.TabIndex = 21;
            // 
            // txbSubscribe
            // 
            txbSubscribe.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txbSubscribe.Location = new System.Drawing.Point(49, 11);
            txbSubscribe.Margin = new System.Windows.Forms.Padding(4);
            txbSubscribe.Name = "txbSubscribe";
            txbSubscribe.Size = new System.Drawing.Size(487, 23);
            txbSubscribe.TabIndex = 20;
            txbSubscribe.Text = "/home/temp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(4, 17);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(44, 17);
            label5.TabIndex = 19;
            label5.Text = "TOPIC";
            // 
            // BtnSubscribe
            // 
            BtnSubscribe.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            BtnSubscribe.Location = new System.Drawing.Point(835, 6);
            BtnSubscribe.Margin = new System.Windows.Forms.Padding(4);
            BtnSubscribe.Name = "BtnSubscribe";
            BtnSubscribe.Size = new System.Drawing.Size(86, 37);
            BtnSubscribe.TabIndex = 18;
            BtnSubscribe.Text = "Subscribe";
            BtnSubscribe.UseVisualStyleBackColor = true;
            BtnSubscribe.Click += BtnSubscribe_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(label8);
            panel4.Controls.Add(CmbPubMqttQuality);
            panel4.Controls.Add(TxbTopic);
            panel4.Controls.Add(label4);
            panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            panel4.Location = new System.Drawing.Point(4, 528);
            panel4.Margin = new System.Windows.Forms.Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(925, 49);
            panel4.TabIndex = 3;
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(637, 17);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(160, 17);
            label8.TabIndex = 24;
            label8.Text = "MqttQualityOfServiceLevel";
            // 
            // CmbPubMqttQuality
            // 
            CmbPubMqttQuality.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            CmbPubMqttQuality.FormattingEnabled = true;
            CmbPubMqttQuality.Location = new System.Drawing.Point(825, 13);
            CmbPubMqttQuality.Margin = new System.Windows.Forms.Padding(4);
            CmbPubMqttQuality.Name = "CmbPubMqttQuality";
            CmbPubMqttQuality.Size = new System.Drawing.Size(96, 25);
            CmbPubMqttQuality.TabIndex = 23;
            // 
            // TxbTopic
            // 
            TxbTopic.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            TxbTopic.Location = new System.Drawing.Point(49, 11);
            TxbTopic.Margin = new System.Windows.Forms.Padding(4);
            TxbTopic.Name = "TxbTopic";
            TxbTopic.Size = new System.Drawing.Size(581, 23);
            TxbTopic.TabIndex = 17;
            TxbTopic.Text = "/home/temp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(4, 17);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(44, 17);
            label4.TabIndex = 16;
            label4.Text = "TOPIC";
            // 
            // panel5
            // 
            panel5.Controls.Add(TxbPayload);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(BtnSend);
            panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            panel5.Location = new System.Drawing.Point(4, 585);
            panel5.Margin = new System.Windows.Forms.Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(925, 49);
            panel5.TabIndex = 4;
            // 
            // TxbPayload
            // 
            TxbPayload.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            TxbPayload.Location = new System.Drawing.Point(65, 10);
            TxbPayload.Margin = new System.Windows.Forms.Padding(4);
            TxbPayload.Name = "TxbPayload";
            TxbPayload.Size = new System.Drawing.Size(752, 23);
            TxbPayload.TabIndex = 22;
            TxbPayload.Text = "23";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(4, 16);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(61, 17);
            label7.TabIndex = 21;
            label7.Text = "Message";
            // 
            // BtnSend
            // 
            BtnSend.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            BtnSend.Location = new System.Drawing.Point(835, 6);
            BtnSend.Margin = new System.Windows.Forms.Padding(4);
            BtnSend.Name = "BtnSend";
            BtnSend.Size = new System.Drawing.Size(86, 37);
            BtnSend.TabIndex = 20;
            BtnSend.Text = "Send";
            BtnSend.UseVisualStyleBackColor = true;
            BtnSend.Click += BtnSend_Click;
            // 
            // FrmMqttClient
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 638);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "FrmMqttClient";
            Text = "Mqtt Client";
            Load += FrmMqttClient_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnDisConnect;
        private System.Windows.Forms.TextBox TxbPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnMultiDisConnect;
        private System.Windows.Forms.Button BtnMultiConnect;
        private System.Windows.Forms.TextBox TxbConnectCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbSubscribe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSubscribe;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TxbTopic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TxbPayload;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbSubMqttQuality;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbPubMqttQuality;
    }
}

