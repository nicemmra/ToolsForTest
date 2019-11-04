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
    /// 串口类封装
    /// </summary>
    public class SerialPortHelper : IDataServer
    {
        private SerialPort serialPort = null;
        private static Dictionary<string, SerialPort> dicSerialPort = new Dictionary<string, SerialPort>();

        private bool Listening_Flag = false;
        private bool Closing_Flag = false;
        private char[] receiveBuf = new char[1024];

        /// <summary>
        /// 串口数据接收事件
        /// </summary>
        public event Action<string> AntDataReceived;

        /// <summary>
        /// 串口类构造函数
        /// </summary>
        /// <param name="portName">端口名</param>
        /// <param name="baudRate">波特率</param>
        public SerialPortHelper(string portName, int baudRate)
        {
            if (dicSerialPort.Keys.Contains(portName))
            {
                serialPort = dicSerialPort[portName];
            }
            else
            {
                serialPort = new SerialPort(portName, baudRate);
                dicSerialPort.Add(portName, serialPort);
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (Closing_Flag) return;
            try
            {
                Listening_Flag = true;
                Array.Clear(receiveBuf, 0, receiveBuf.Length);
                int readCount = serialPort.BytesToRead;
                serialPort.Read(receiveBuf, 0, readCount);
                if (AntDataReceived != null) AntDataReceived.Invoke(new string(receiveBuf));
            }
            catch (Exception ex)
            {
                if (AntDataReceived != null) AntDataReceived.Invoke(string.Format("接收出错：{0}\r\n", ex.Message));
            }
            finally
            {
                Listening_Flag = false;
            }
        }
        /// <summary>
        /// 关闭串口
        /// </summary>
        public void CloseConnect()
        {
            try
            {
                Closing_Flag = true;
                while (Listening_Flag) ;// Application.DoEvents();
                serialPort.DataReceived -= SerialPort_DataReceived;
                serialPort.Close();
            }
            catch (Exception ex)
            {
                if (AntDataReceived != null) AntDataReceived.Invoke(string.Format("{0}\r\n", ex.Message));
            }
            finally
            {
                dicSerialPort.Remove(serialPort.PortName);
                serialPort.Dispose();
            }
        }
        /// <summary>
        /// 打开串口
        /// </summary>
        public void OpenConnect()
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    if (AntDataReceived != null) AntDataReceived.Invoke(string.Format("{0}已打开！\r\n", serialPort.PortName));
                    return;
                }
                Closing_Flag = false;
                // serialPort.ReadTimeout = 100;
                serialPort.ReadBufferSize = 1024;
                serialPort.Open();
                serialPort.DataReceived += SerialPort_DataReceived;
            }
            catch (Exception ex)
            {
                if (AntDataReceived != null) AntDataReceived.Invoke(string.Format("{0}\r\n", ex.Message));
            }
        }
        /// <summary>
        /// 向串口发送数据
        /// </summary>
        /// <param name="str"></param>
        public void SendData(string str)
        {
            if (serialPort.IsOpen) serialPort.Write(str);
        }
    }
}
