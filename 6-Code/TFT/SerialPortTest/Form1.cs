using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        }

        private void btnOpenConnect_Click(object sender, EventArgs e)
        {
            string portName = txtPortName.Text;
            int baudRate = int.Parse(txtBaudRate.Text);
            serialPortBLL = new SerialPortBLL(portName, baudRate);
            serialPortBLL.OpenConnect();
            serialPortBLL.AntDataReceivedBLL += SerialPortBLL_AntDataReceivedBLL;
        }

        private void SerialPortBLL_AntDataReceivedBLL(string obj)
        {
            //TaskFactory taskFactory = new TaskFactory();
            //taskFactory.StartNew(() => rtxtReceiveData.AppendText(obj));
            //this.Invoke(() => rtxtReceiveData.AppendText(obj));
            //Invoke((MethodInvoker)(() => { rtxtReceiveData.AppendText(obj); }));
            rtxtReceiveData.AppendText(obj);
        }

        private void btnSendCommand_Click(object sender, EventArgs e)
        {
            string str = rtxtSendCommand.Text;
            serialPortBLL.Write(str);
        }
    }
}
