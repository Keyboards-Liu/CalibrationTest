using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CalibrationTest.View;
using CalibrationTest.View.NetView;
using CalibrationTest.View.BaseView;
using CalibrationTest.View.SerialView;


namespace CalibrationTest.View.BaseView
{
    /// <summary>
    /// SerialBase.xaml 的交互逻辑
    /// </summary>
    public partial class CommandSpace : UserControl
    {
        public static CommandSpace NewCommandSpace;
        private static SerialPortMessageBox _newSerialPortMessageBox;


        public CommandSpace()
        {
            InitializeComponent();
            NewCommandSpace = this;
        }


        private void SerialDebuggingAssistant_OnClick(object sender, RoutedEventArgs e)
        {
            _newSerialPortMessageBox = new SerialPortMessageBox();
            _newSerialPortMessageBox.ShowDialog();
            NetUserInterface.NewUserInterface.Visibility = Visibility.Hidden;

        }
    }
}
