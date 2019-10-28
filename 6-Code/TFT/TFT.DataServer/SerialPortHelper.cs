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
        #region 串口类public内容

        /// <summary>
        /// 串口数据接收公开事件，string参数为“整行”的参数
        /// </summary>
        public event Action<string> AntDataReceived;

        /// <summary>
        /// 串口类构造函数
        /// </summary>
        /// <param name="portName">端口名</param>
        /// <param name="baudRate">波特率</param>
        public SerialPortHelper(string portName, int baudRate)
        {
            serialPort = new SerialPort(portName, baudRate);
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
                if (AntDataReceived != null) AntDataReceived.Invoke(ex.Message);
            }
            finally
            {
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
                Closing_Flag = false;
                serialPort.ReadTimeout = 100;
                serialPort.Open();
                serialPort.DataReceived += SerialPort_DataReceived;
            }
            catch (Exception ex)
            {
                if (AntDataReceived != null) AntDataReceived.Invoke(ex.Message);
            }
        }
        /// <summary>
        /// 向串口发送数据：“整行”数据
        /// </summary>
        /// <param name="str"></param>
        public void SendData(string str)
        {
            if (serialPort.IsOpen) serialPort.WriteLine(str);
        }

        #endregion

        private SerialPort serialPort = null;

        private bool Listening_Flag = false;
        private bool Closing_Flag = false;
        private StringBuilder receiveBuf = new StringBuilder();
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (Closing_Flag) return;
            try
            {
                Listening_Flag = true;
                receiveBuf.Clear();
                receiveBuf.Append(this.serialPort.ReadLine());
                if (AntDataReceived != null) AntDataReceived.Invoke(receiveBuf.ToString());
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
    }
}
