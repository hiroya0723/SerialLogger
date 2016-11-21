using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;




namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string RxString;
        const int SENSER_NUM = 4;
        int[] maxy = new int[SENSER_NUM];

        public Form1()
        {
            InitializeComponent();
        }

        private class BuadRateItem : Object
        {
            private string m_name = "";
            private int m_value = 0;

            // 表示名称
            public string NAME
            {
                set { m_name = value; }
                get { return m_name; }
            }

            // ボーレート設定値.
            public int BAUDRATE
            {
                set { m_value = value; }
                get { return m_value; }
            }

            // コンボボックス表示用の文字列取得関数.
            public override string ToString()
            {
                return m_name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = cmbPortName.SelectedItem.ToString();
            BuadRateItem baud = (BuadRateItem)cmbBaudRate.SelectedItem;
            serialPort1.BaudRate = baud.BAUDRATE;
            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadLine();
            this.Invoke(new EventHandler(DisplayText));
            this.Invoke(new EventHandler(showChart));
        }

        private void DisplayText(object sender, EventArgs e)
        {
            textBox1.AppendText(RxString + Environment.NewLine);
        }

        private void showChart(object sender, EventArgs e)
        {
            String[] strArrayData = RxString.Split(',');
            int[] y = new int[SENSER_NUM];
            int x = int.Parse(strArrayData[0]);
            for(int i = 1; i <= 4; i++){
                y[i-1] = int.Parse(strArrayData[i]);
                if (maxy[i - 1] < y[i - 1])
                    maxy[i - 1] = y[i - 1];
            }
            WriteCsv(x,y);

            chart1.Series["Series1"].Points.AddXY(x, y[0]);
            chart1.Series["Series2"].Points.AddXY(x, y[1]);
            chart1.Series["Series3"].Points.AddXY(x, y[2]);
            chart1.Series["Series4"].Points.AddXY(x, y[3]);

            label2.Text = y[0].ToString();
            label4.Text = y[1].ToString();
            label6.Text = y[2].ToString();
            label8.Text = y[3].ToString();

            label13.Text = maxy[0].ToString();
            label10.Text = maxy[1].ToString();
            label11.Text = maxy[2].ToString();
            label12.Text = maxy[3].ToString();

            chart1.ChartAreas[0].AxisX.Maximum = 50000;
            chart1.ChartAreas[0].AxisX.Minimum = 0;

            //if (x > chart1.ChartAreas[0].AxisX.Maximum)
            //{
            //    chart1.Series["Series1"].Points.Clear();
            //    chart1.Series["Series2"].Points.Clear();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private static void WriteCsv(int x,int[] y)
        {
            try
            {
                var append = true;
                using (var sw = new System.IO.StreamWriter(@"test.csv", append)){
                    sw.Write(x);
                    sw.Write(",");
                    for(int i = 0; i < SENSER_NUM; i++){
                        sw.Write(y[i]);
                        sw.Write(",");
                    }
                    sw.Write("\n");
                }
            }
            catch (System.Exception e)
            {
            System.Console.WriteLine(e.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] PortList = SerialPort.GetPortNames();

            cmbPortName.Items.Clear();

            foreach (string PortName in PortList)
            {
                cmbPortName.Items.Add(PortName);
            }
            if (cmbPortName.Items.Count > 0)
            {
                cmbPortName.SelectedIndex = 0;
            }

            cmbBaudRate.Items.Clear();

            BuadRateItem baud;
            baud = new BuadRateItem();
            baud.NAME = "4800bps";
            baud.BAUDRATE = 4800;
            cmbBaudRate.Items.Add(baud);

            baud = new BuadRateItem();
            baud.NAME = "9600bps";
            baud.BAUDRATE = 9600;
            cmbBaudRate.Items.Add(baud);

            baud = new BuadRateItem();
            baud.NAME = "19200bps";
            baud.BAUDRATE = 19200;
            cmbBaudRate.Items.Add(baud);

            baud = new BuadRateItem();
            baud.NAME = "115200bps";
            baud.BAUDRATE = 115200;
            cmbBaudRate.Items.Add(baud);
            cmbBaudRate.SelectedIndex = 1;

            
        }

       
    }
}
