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

namespace HelloWpf
{
    /// <summary>
    /// Interaction logic for InputDialogTestWindow.xaml
    /// </summary>
    public partial class InputDialogTestWindow : Window
    {
        public InputDialogTestWindow()
        {
            InitializeComponent();
        }

        private void PopDiolog_Click(object sender, RoutedEventArgs e)
        {
            InputDialog dialog =  new InputDialog("how");
            if (dialog.ShowDialog() == true) {
                string answer = dialog.Answer;
                Console.WriteLine(answer);
            }
            
        }
    }
}
