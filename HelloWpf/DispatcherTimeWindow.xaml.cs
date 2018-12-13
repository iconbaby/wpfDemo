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
using System.Windows.Threading;

namespace HelloWpf
{
    /// <summary>
    /// Interaction logic for DispatcherTimeWindow.xaml
    /// </summary>
    public partial class DispatcherTimeWindow : Window
    {
        public DispatcherTimeWindow()
        {
            InitializeComponent();
            DispatcherTimer dt = new DispatcherTimer();
            //dt.Interval = TimeSpan.FromSeconds(1);
            dt.Interval = TimeSpan.FromMilliseconds(1);
            dt.Tick += TickTok;
            dt.Start();

        }
        public void TickTok(object sender, EventArgs e)
        {
            //lbTime.Content = DateTime.Now.ToLongTimeString();
            lbTime.Content = DateTime.Now.ToString("HH:mm:ss:fff");
        }
    }
}
