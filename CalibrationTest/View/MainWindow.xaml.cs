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
using System.Windows.Shapes;

namespace CalibrationTest.View
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow NewMainWindow;
        public MainWindow()
        {
            try
            {
                InitializeComponent();
                NewMainWindow = this;
            }
            catch (Exception ex)
            {
                string str = ex.StackTrace;
                Console.WriteLine(str);
            }
        }

        private void SerialBase_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void SerialPortStatusBar_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void NetPortStatusBar_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
