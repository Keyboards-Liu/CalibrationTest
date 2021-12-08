using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationTest.Model
{
    /// <summary>
    /// 报文类
    /// </summary>
    class Message : NotificationObject
    {
        private string _frameHeader;
        private string _frameLength;
        private string _frameCommand;
        private string _frameAddress;
        private string _frameUnparsed;
        private string _frameContent;
        private string _frameCRC;

        /// <summary>
        /// 帧头 (指示协议类型)
        /// </summary>
        public string FrameHeader
        {
            get => _frameHeader;
            set
            {
                if (_frameHeader != value)
                {
                    _frameHeader = value;
                    RaisePropertyChanged("FrameHeader");
                }
            }
        }
        /// <summary>
        /// 长度域 (指示报文长度)
        /// </summary>
        public string FrameLength
        {
            get => _frameLength;
            set
            {
                if (_frameLength != value)
                {
                    _frameLength = value;
                    RaisePropertyChanged("FrameLength");
                }
            }
        }
        /// <summary>
        /// 命令域 (指示协议中报文类型)
        /// </summary>
        public string FrameCommand
        {
            get => _frameCommand;
            set
            {
                if (_frameCommand != value)
                {
                    _frameCommand = value;
                    RaisePropertyChanged("FrameCommand");
                }
                _frameCommand = value;
            }
        }
        /// <summary>
        /// 地址域 (指示数据来源地址)
        /// </summary>
        public string FrameAddress
        {
            get => _frameAddress;
            set
            {
                if (_frameAddress != value)
                {
                    _frameAddress = value;
                    RaisePropertyChanged("FrameAddress");
                }
                _frameAddress = value;
            }
        }
        /// <summary>
        /// 非解析域 (报文中包含的不需要解析的信息)
        /// </summary>
        public string FrameUnparsed
        {
            get => _frameUnparsed;
            set
            {
                if (_frameUnparsed != value)
                {
                    _frameUnparsed = value;
                    RaisePropertyChanged("FrameUnparsed");
                }
                _frameUnparsed = value;
            }
        }
        /// <summary>
        /// 数据内容域 (报文中包含的仪表数据信息)
        /// </summary>
        public string FrameContent
        {
            get => _frameContent;
            set
            {
                if (_frameContent != value)
                {
                    _frameContent = value;
                    RaisePropertyChanged("FrameContent");
                }
                _frameContent = value;
            }
        }
        /// <summary>
        /// 校验码 (用来校验报文是否为有效报文)
        /// </summary>
        public string FrameCRC
        {
            get => _frameCRC;
            set
            {
                if (_frameCRC != value)
                {
                    _frameCRC = value;
                    RaisePropertyChanged("FrameCRC");
                }
                _frameCRC = value;
            }
        }

    }
    /// <summary>
    /// 接收报文类
    /// </summary>
    class RecieveMessage : Message
    {

    }

    class SendMessage : Message
    {

    }

}
