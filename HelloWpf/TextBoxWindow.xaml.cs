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
    /// Interaction logic for TextBoxWindow.xaml
    /// </summary>
    public partial class TextBoxWindow : Window
    {
        public TextBoxWindow()
        {
            InitializeComponent();
        }

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextBox tb =  sender as TextBox;
            txtStatus.Text = "Selection starts at charater #" + tb.SelectionStart + Environment.NewLine;
            txtStatus.Text += "selection is " + tb.SelectionLength + "characters（s）long" + Environment.NewLine;
            txtStatus.Text += "selected text: " + tb.SelectedText + "";
           

        }
    }
}
