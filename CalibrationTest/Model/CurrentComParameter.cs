using System;
using System.Collections.Generic;
using System.Linq;
using System.IO.Ports;
using System.Windows;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationTest.Model
{
    class CalibrationSerialPort : NotificationObject
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public CalibrationSerialPort()
        {

        }

        #region 串口基本参数
        #region 字段列表
        private string port;            // 串口参数: 当前端口
        private int baudRate;           // 串口参数: 当前波特率
        private int dataBit;            // 串口参数: 当前数据位
        private string parity;          // 串口参数: 当前校验位
        private string stopBit;         // 串口参数: 当前停止位
        #endregion

        #region 属性列表
        /// <summary>
        /// 串口参数: 当前端口
        /// </summary>
        public string Port
        {
            get => port;
            set
            {
                if (port != value)
                {
                    port = value;
                    RaisePropertyChanged("Port");
                }
            }
        }
        /// <summary>
        /// 串口参数: 当前波特率
        /// </summary>
        public int BaudRate
        {
            get => baudRate;
            set
            {
                if (baudRate != value)
                {
                    baudRate = value;
                    RaisePropertyChanged("BaudRate");
                }

            }
        }
        /// <summary>
        /// 串口参数: 当前数据位
        /// </summary>
        public int DataBit
        {
            get => dataBit;
            set
            {
                if (dataBit != value)
                {
                    dataBit = value;
                    RaisePropertyChanged("DataBit");
                }
            }
        }
        /// <summary>
        /// 串口参数: 当前校验位
        /// </summary>
        public string Parity
        {
            get => parity;
            set
            {
                if (parity != value)
                {
                    parity = value;
                    RaisePropertyChanged("Parity");
                }

            }
        }
        /// <summary>
        /// 串口参数: 当前停止位
        /// </summary>
        public string StopBit
        {
            get => stopBit;
            set
            {
                if (stopBit != value)
                {
                    stopBit = value;
                    RaisePropertyChanged("StopBit");
                }
            }
        }
        #endregion
        #endregion

        #region 串口运行参数   
        #region 字段列表
        private SerialPort serialPort;      // 运行参数: 串口类

        #endregion

        #region 属性列表
        /// <summary>
        /// 运行参数: 串口类
        /// </summary>
        public SerialPort SerialPort
        {
            get => serialPort;
            set
            {
                if (serialPort != value)
                {
                    serialPort = value;
                    RaisePropertyChanged("SerialPort");
                }

            }
        }
        #endregion

        #endregion

        
    }
}
