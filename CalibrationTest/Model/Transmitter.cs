using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationTest.Model
{
    /// <summary>
    /// 变送器类
    /// </summary>
    class Transmitter : NotificationObject
    {
        #region 字段列表
        private string protocol;               // 协议参数: 通信协议
        private string address;                // 协议参数: 网络地址
        private string vendor;                 // 协议参数: 厂商号
        private string type;                   // 协议参数: 仪表类型
        private string group;                  // 协议参数: 仪表组号
        private string number;                 // 协议参数: 仪表表号
        private string functionData;           // 协议参数: 数据类型

        private string successRate;            // 常规数据: 通信效率（成功率）
        private string batteryVoltage;         // 常规数据: 电池电压
        private string sleepTime;              // 常规数据: 休眠时间
        private string statue;                 // 常规数据: 仪表状态
        private string runTime;                // 常规数据: 运行时间
        private string realTimeData;           // 常规数据: 实时数据

        private string model;                  // 基本参数: 仪表型号
        private string serialNumber;           // 基本参数: 系列号
        private string firmwareVersion;        // 基本参数: 固件版本
        private string softwareVersion;        // 基本参数: 软件版本
        private string lowRange;               // 基本参数: 量程下限
        private string highRange;              // 基本参数: 量程上限
        private string measurementAccuracy;    // 基本参数: 测量精度
        private string protectionLevel;        // 基本参数: 防护等级
        private string explosionProofGrade;    // 基本参数: 防爆等级
        private string illustrate;             // 基本参数: 说明
        #endregion

        #region 属性列表
        #region 协议参数 (报文中用于定位某个具体表的信息)
        /// <summary>
        /// 协议参数: 通信协议
        /// </summary>
        public string Protocol
        {
            get => protocol;
            set
            {
                if (protocol != value)
                {
                    protocol = value;
                    RaisePropertyChanged("Protocol");
                }
            }
        }
        /// <summary>
        /// 协议参数: 网络地址
        /// </summary>
        public string Address
        {
            get => address;
            set
            {
                if (address != value)
                {
                    address = value;
                    RaisePropertyChanged("Address");
                }
            }
        }
        /// <summary>
        /// 协议参数: 厂商号
        /// </summary>
        public string Vendor
        {
            get => vendor;
            set
            {
                if (vendor != value)
                {
                    vendor = value;
                    RaisePropertyChanged("Vendor");
                }
            }
        }
        /// <summary>
        /// 协议参数: 仪表类型
        /// </summary>
        public string Type
        {
            get => type;
            set
            {
                if (type != value)
                {
                    type = value;
                    RaisePropertyChanged("Type");
                }
            }
        }
        /// <summary>
        /// 协议参数: 仪表组号
        /// </summary>
        public string Group
        {
            get => group;
            set
            {
                if (group != value)
                {
                    group = value;
                    RaisePropertyChanged("Group");
                }
            }
        }
        /// <summary>
        /// 协议参数: 仪表表号
        /// </summary>
        public string Number
        {
            get => number;
            set
            {
                if (number != value)
                {
                    number = value;
                    RaisePropertyChanged("Number");
                }
            }
        }
        /// <summary>
        /// 协议参数: 数据类型
        /// </summary>
        public string FunctionData
        {
            get => functionData;
            set
            {
                if (functionData != value)
                {
                    functionData = value;
                    RaisePropertyChanged("FunctionData");
                }
            }
        }
        #endregion

        #region 常规数据 (仪表常规数据帧中的实时信息)
        /// <summary>
        /// 常规数据: 通信效率（成功率）
        /// </summary>
        public string SuccessRate
        {
            get => successRate;
            set
            {
                if (successRate != value)
                {
                    successRate = value;
                    RaisePropertyChanged("SuccessRate");
                }
            }
        }
        /// <summary>
        /// 常规数据: 电池电压
        /// </summary>
        public string BatteryVoltage
        {
            get => batteryVoltage;
            set
            {
                if (batteryVoltage != value)
                {
                    batteryVoltage = value;
                    RaisePropertyChanged("BatteryVoltage");
                }
            }
        }
        /// <summary>
        /// 常规数据: 休眠时间
        /// </summary>
        public string SleepTime
        {
            get => sleepTime;
            set
            {
                if (sleepTime != value)
                {
                    sleepTime = value;
                    RaisePropertyChanged("SleepTime");
                }
            }
        }
        /// <summary>
        /// 常规数据: 仪表状态
        /// </summary>
        public string Statue
        {
            get => statue;
            set
            {
                if (statue != value)
                {
                    statue = value;
                    RaisePropertyChanged("Statue");
                }
            }
        }
        /// <summary>
        /// 常规数据: 运行时间
        /// </summary>
        public string RunTime
        {
            get => runTime;
            set
            {
                if (runTime != value)
                {
                    runTime = value;
                    RaisePropertyChanged("RunTime");
                }
            }
        }
        /// <summary>
        /// 常规数据: 实时数据
        /// </summary>
        public string RealTimeData
        {
            get => realTimeData;
            set
            {
                if (realTimeData != value)
                {
                    realTimeData = value;
                    RaisePropertyChanged("RealTimeData");
                }
            }
        }
        #endregion

        #region 基本参数（仪表基本参数帧中的参数信息）
        /// <summary>
        /// 基本参数: 仪表型号
        /// </summary>
        public string Model
        {
            get => model;
            set
            {
                if (model != value)
                {
                    model = value;
                    RaisePropertyChanged("Model");
                }
            }
        }
        /// <summary>
        /// 基本参数: 系列号
        /// </summary>
        public string SerialNumber
        {
            get => serialNumber;
            set
            {
                if (serialNumber != value)
                {
                    serialNumber = value;
                    RaisePropertyChanged("SerialNumber");
                }
            }
        }
        /// <summary>
        /// 基本参数: 固件版本
        /// </summary>
        public string FirmwareVersion
        {
            get => firmwareVersion;
            set
            {
                if (firmwareVersion != value)
                {
                    firmwareVersion = value;
                    RaisePropertyChanged("FirmwareVersion");
                }
            }
        }
        /// <summary>
        /// 基本参数: 软件版本
        /// </summary>
        public string SoftwareVersion
        {
            get => softwareVersion;
            set
            {
                if (softwareVersion != value)
                {
                    softwareVersion = value;
                    RaisePropertyChanged("SoftwareVersion");
                }
            }
        }
        /// <summary>
        /// 基本参数: 量程下限
        /// </summary>
        public string LowRange
        {
            get => lowRange;
            set
            {
                if (lowRange != value)
                {
                    lowRange = value;
                    RaisePropertyChanged("LowRange");
                }
            }
        }
        /// <summary>
        /// 基本参数: 量程上限
        /// </summary>
        public string HighRange
        {
            get => highRange;
            set
            {
                if (highRange != value)
                {
                    highRange = value;
                    RaisePropertyChanged("HighRange");
                }
            }
        }
        /// <summary>
        /// 基本参数: 测量精度
        /// </summary>
        public string MeasurementAccuracy
        {
            get => measurementAccuracy;
            set
            {
                if (measurementAccuracy != value)
                {
                    measurementAccuracy = value;
                    RaisePropertyChanged("MeasurementAccuracy");
                }
            }
        }
        /// <summary>
        /// 基本参数: 防护等级
        /// </summary>
        public string ProtectionLevel
        {
            get => protectionLevel;
            set
            {
                if (protectionLevel != value)
                {
                    protectionLevel = value;
                    RaisePropertyChanged("ProtectionLevel");
                }
            }
        }
        /// <summary>
        /// 基本参数: 防爆等级
        /// </summary>
        public string ExplosionProofGrade
        {
            get => explosionProofGrade;
            set
            {
                if (explosionProofGrade != value)
                {
                    explosionProofGrade = value;
                    RaisePropertyChanged("ExplosionProofGrade");
                }
            }
        }
        /// <summary>
        /// 基本参数: 说明
        /// </summary>
        public string Illustrate
        {
            get => illustrate;
            set
            {
                if (illustrate != value)
                {
                    illustrate = value;
                    RaisePropertyChanged("Illustrate");
                }
            }
        }
        #endregion
        #endregion

    }
}
