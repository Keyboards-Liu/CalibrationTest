using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CalibrationTest.Helpers
{
    /// <summary>
    /// Taken from http://msdn.microsoft.com/zh-cn/magazine/dd419663.aspx
    /// </summary>

    //public class RelayCommand : ICommand
    //{
    //    #region 字段

    //    readonly Action<object> _execute;
    //    readonly Predicate<object> _canExecute;

    //    #endregion // Fields

    //    #region 构造函数

    //    public RelayCommand(Action<object> execute) : this(execute, null) { }

    //    public RelayCommand(Action<object> execute, Predicate<object> canExecute)
    //    {
    //        _execute = execute ?? throw new ArgumentNullException("execute");
    //        _canExecute = canExecute;
    //    }
    //    #endregion // 构造函数

    //    #region ICommand Members

    //    public bool CanExecute(object parameter)
    //    {
    //        return _canExecute == null ? true : _canExecute(parameter);
    //    }

    //    public event EventHandler CanExecuteChanged
    //    {
    //        add
    //        {
    //            CommandManager.RequerySuggested += value;
    //        }
    //        remove
    //        {
    //            CommandManager.RequerySuggested -= value;
    //        }
    //    }

    //    public void Execute(object parameter)
    //    {
    //        _execute(parameter);
    //    }

    //    #endregion // ICommand Members
    //}
}
