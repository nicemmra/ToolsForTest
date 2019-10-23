using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;

namespace TFT.DataServer
{
    /// <summary>
    /// 串口类
    /// </summary>
    public class SerialPortHelper : IDataServer
    {
        private SerialPort serialPort = null;

        public event Action<string> AntDataReceived;

        public SerialPortHelper(string portName, int baudRate)
        {
            serialPort = new SerialPort(portName, baudRate);
        }

        public void CloseConnect()
        {
            serialPort.Close();
        }

        public void OpenConnect()
        {
            serialPort.Open();
            serialPort.DataReceived += SerialPort_DataReceived;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string str = serialPort.ReadLine();
            if (AntDataReceived != null) AntDataReceived.Invoke(str);
        }

        public void Write(string str)
        {
            serialPort.WriteLine(str);
        }
    }
}
