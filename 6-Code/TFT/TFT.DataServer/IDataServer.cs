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
    }
}
