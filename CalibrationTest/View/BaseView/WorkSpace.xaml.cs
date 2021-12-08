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
using CalibrationTest.View.BaseView;
using CalibrationTest.View.NetView;
using CalibrationTest.View.SerialView;

namespace CalibrationTest.View.BaseView
{
    /// <summary>
    /// WorkSpace.xaml 的交互逻辑
    /// </summary>
    public partial class WorkSpace : UserControl
    {
        public static WorkSpace NewWorkSpace;

        public WorkSpace()
        {
            InitializeComponent();
            NewWorkSpace = this;
        }


    }
}
