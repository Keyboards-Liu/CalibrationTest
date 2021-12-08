using System.Windows.Controls;

namespace CalibrationTest.View.BaseView
{
    /// <summary>
    ///     BottomStatusBar.xaml 的交互逻辑
    /// </summary>
    public partial class BottomStatusBar : UserControl
    {
        public static BottomStatusBar NewBottomStatusBar;
        public BottomStatusBar()
        {
            InitializeComponent();
            NewBottomStatusBar = this;
        }
    }
}