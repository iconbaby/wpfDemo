using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HelloWpf
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        //private void Application_Startup(object sender, StartupEventArgs e)
        //{
        //    ExceptionWindow wnd = new ExceptionWindow();
        //    wnd.Title = "ExceptionWindow ";
        //    if (e.Args.Length == 1) {
        //        //MessageBox.Show("Now opening file:\n\n" + e.Args[0]);
        //    }
        //    wnd.Show();
        //}
        //处理全局的异常
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Exception" + e.Exception.Message, "Exception", MessageBoxButton.OK, MessageBoxImage.Warning);
            e.Handled = true;
        }
    }
}
