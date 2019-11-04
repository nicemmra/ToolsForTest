using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFT.DataServer;

namespace TFT.DAL
{
    public class SerialPortDAL
    {
        private SerialPortHelper dataServer = null;

        public event Action<string> AntDataReceivedDal;

        public SerialPortDAL(string portName, int baudRate)
        {
            dataServer = new SerialPortHelper(portName, baudRate);
            dataServer.AntDataReceived += DataServer_AntDataReceived;
        }

        private void DataServer_AntDataReceived(string obj)
        {
            if (AntDataReceivedDal != null)
            {
                AntDataReceivedDal.Invoke(obj);
            }
        }

        public void OpenConnect()
        {
            dataServer.OpenConnect();
        }

        public void SendData(string str)
        {
            dataServer.SendData(str);
        }

        public void CloseConnect()
        {
            dataServer.CloseConnect();
        }
    }
}
