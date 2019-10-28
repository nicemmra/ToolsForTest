using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT.Models
{
    /// <summary>
    /// 惯导标定数据
    /// </summary>
    public class VM_CailbAdu
    {
        /// <summary>
        /// 惯导航向
        /// </summary>
        public float InsHead { get; set; }
        /// <summary>
        /// 惯导俯仰
        /// </summary>
        public float InsPitch { get; set; }
        /// <summary>
        /// 惯导横滚
        /// </summary>
        public float InsRoll { get; set; }
    }
}
