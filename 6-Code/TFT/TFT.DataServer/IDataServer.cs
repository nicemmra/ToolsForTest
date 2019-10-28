using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT.DataServer
{
    interface IDataServer
    {
        /// <summary>
        /// 打开连接，打开串口或网口
        /// </summary>
        void OpenConnect();

        /// <summary>
        /// 关闭连接，关串口或网口
        /// </summary>
        void CloseConnect();

        /// <summary>
        /// 接收网口或串口的数据
        /// </summary>
        event Action<string> AntDataReceived;

        /// <summary>
        /// 向串口或网口发送数据
        /// </summary>
        /// <param name="str"></param>
        void SendData(string str);
    }
}
