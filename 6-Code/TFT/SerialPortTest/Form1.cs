using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TFT.BLL;

namespace SerialPortTest
{
    public partial class frmSerialPortTest : Form
    {
        private SerialPortBLL serialPortBLL = null;

        //private event Action<string> UpdateUI;
        public frmSerialPortTest()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void frmSerialPortTest_Load(object sender, EventArgs e)
        {
            string[] portNames = SerialPort.GetPortNames();
            txtPortName.Text = portNames[0];
        }

        private void btnOpenConnect_Click(object sender, EventArgs e)
        {
            string portName = txtPortName.Text;
            int baudRate = int.Parse(txtBaudRate.Text);
            serialPortBLL = new SerialPortBLL(portName, baudRate);
            serialPortBLL.AntDataReceivedBLL += SerialPortBLL_AntDataReceivedBLL;
            serialPortBLL.OpenConnect();
        }

        private void SerialPortBLL_AntDataReceivedBLL(string obj)
        {
            //TaskFactory taskFactory = new TaskFactory();
            //taskFactory.StartNew(() => rtxtReceiveData.AppendText(obj));
            //this.Invoke(() => rtxtReceiveData.AppendText(obj));
            //Invoke((MethodInvoker)(() => { rtxtReceiveData.AppendText(obj); }));
            rtxtReceiveData.AppendText(obj);
            rtxtReceiveData.ScrollToCaret();
        }

        private void btnSendCommand_Click(object sender, EventArgs e)
        {
            string str = rtxtSendCommand.Text;
            serialPortBLL.SendData(str);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            serialPortBLL.CloseConnect();
        }
    }
}
