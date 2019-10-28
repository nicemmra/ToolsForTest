using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT.Models
{
    /// <summary>
    /// 天线标定数据
    /// </summary>
    public class VM_CalibAnt
    {
        /// <summary>
        /// 天线方位
        /// </summary>
        public float AntAzi { get; set; }
        /// <summary>
        /// 天线俯仰
        /// </summary>
        public float AntPitch { get; set; }
        /// <summary>
        /// 天线横滚
        /// </summary>
        public float AntRoll { get; set; }
        /// <summary>
        /// 天线极化
        /// </summary>
        public float AntPol { get; set; }
        /// <summary>
        /// 天线接收极化
        /// </summary>
        public float AntPolReceive { get; set; }
        /// <summary>
        /// 天线发射极化
        /// </summary>
        public float AntPolTransmit { get; set; }
        /// <summary>
        /// 天线接收极化水平
        /// </summary>
        public float AntPolReceiveH { get; set; }
        /// <summary>
        /// 天线接收极化垂直
        /// </summary>
        public float AntPolReceiveV { get; set; }
        /// <summary>
        /// 天线发射极化水平
        /// </summary>
        public float AntPolTransmitH { get; set; }
        /// <summary>
        /// 天线发射极化垂直
        /// </summary>
        public float AntPolTransmitV { get; set; }
    }
}
