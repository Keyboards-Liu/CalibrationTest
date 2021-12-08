using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationTest.Model
{
    class ComParameter : NotificationObject
    {
        #region 字段列表
        // 串口参数: 可用端口
        private ObservableCollection<string> port = new ObservableCollection<string>() { "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8" };
        // 串口参数: 可用波特率
        private ObservableCollection<int> baudRate = new ObservableCollection<int>() { 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 43000, 56000, 57600, 115200, 128000, 230400, 256000 };
        // 串口参数: 可用数据位
        private ObservableCollection<int> dataBit = new ObservableCollection<int>() { 5, 6, 7, 8 };
        // 串口参数: 可用校验位
        private ObservableCollection<string> parity = new ObservableCollection<string>() { "无", "偶校验", "奇校验" };
        // 串口参数: 可用停止位
        private ObservableCollection<string> stopBit = new ObservableCollection<string>() { "1", "1.5", "2" };
        #endregion

        #region 属性列表
        /// <summary>
        /// 串口参数: 可用端口
        /// </summary>
        public ObservableCollection<string> Port
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
        /// 串口参数: 可用波特率
        /// </summary>
        public ObservableCollection<int> BaudRate
        {
            get => baudRate;
            set
            {
                if (BaudRate != value)
                {
                    baudRate = value;
                    RaisePropertyChanged("BaudRate");
                }
            }
        }
        /// <summary>
        /// 串口参数: 可用数据位
        /// </summary>
        public ObservableCollection<int> DataBit
        {
            get { return dataBit; }
            set
            {
                if (DataBit != value)
                {
                    dataBit = value;
                    RaisePropertyChanged("DataBit");
                }

            }
        }
        /// <summary>
        /// 串口参数: 可用校验位
        /// </summary>
        public ObservableCollection<string> Parity
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
        /// 串口参数: 可用停止位
        /// </summary>
        public ObservableCollection<string> StopBit
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
    }
}
