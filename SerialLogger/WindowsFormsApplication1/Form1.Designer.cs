namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "接続\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "切断\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 164);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 211);
            this.textBox1.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea3.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
            chartArea3.AxisX.Maximum = 50000D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisY.Interval = 256D;
            chartArea3.AxisY.Maximum = 1024D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Cursor = System.Windows.Forms.Cursors.IBeam;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(148, 164);
            this.chart1.Margin = new System.Windows.Forms.Padding(1);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Series2";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "Series3";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "Series4";
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(424, 211);
            this.chart1.TabIndex = 3;
            this.chart1.Text = " ";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM4";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // cmbPortName
            // 
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(19, 14);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(121, 20);
            this.cmbPortName.TabIndex = 4;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(177, 14);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(121, 20);
            this.cmbBaudRate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "No.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "No.2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "No.3";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "No.4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 12);
            this.label8.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "最大値";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 12);
            this.label10.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(200, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 12);
            this.label11.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(200, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 12);
            this.label12.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(200, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 12);
            this.label13.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 394);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBaudRate);
            this.Controls.Add(this.cmbPortName);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

