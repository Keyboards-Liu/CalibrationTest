using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationTest.Model
{
    /// <summary>
    /// 变送器类 (对应测试中实际存在的表)
    /// POCO 类是不需要任何特殊接口或继承的类
    /// 在WPF MVVM术语中，POCO类是不触发PropertyChanged事件的类
    /// </summary>
    class PocoTransmitter
    {

        /// <summary>
        /// 通信协议
        /// </summary>
        public string Protocol { get; set; }
        /// <summary>
        /// 网络地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 厂商号
        /// </summary>
        public string Vendor { get; set; }
        /// <summary>
        /// 仪表类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 仪表组号
        /// </summary>
        public string Group { get; set; }
        /// <summary>
        /// 仪表表号
        /// </summary>
        public string Number { get; set; }
    }

}