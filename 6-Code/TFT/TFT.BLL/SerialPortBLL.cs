using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFT.DAL;

namespace TFT.BLL
{
    public class SerialPortBLL
    {
        private SerialPortDAL serialPortDAL = null;

        public event Action<string> AntDataReceivedBLL;

        public SerialPortBLL(string portName, int baudRate)
        {
            serialPortDAL = new SerialPortDAL(portName, baudRate);
            serialPortDAL.AntDataReceivedDal += SerialPortDAL_AntDataReceivedDal;
        }

        private void SerialPortDAL_AntDataReceivedDal(string obj)
        {
            if (AntDataReceivedBLL != null)
            {
                AntDataReceivedBLL.Invoke(obj);
            }
        }

        public void OpenConnect()
        {
            serialPortDAL.OpenConnect();
        }

        public void Write(string str)
        {
            serialPortDAL.Write(str);
        }
    }
}
