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
    /// Interaction logic for TabControlWindow.xaml
    /// </summary>
    public partial class TabControlWindow : Window
    {
        public TabControlWindow()
        {
            InitializeComponent();
        }

        private void Btn_selected_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Selected Item" + (tc_control.SelectedItem as TabItem).Content);
        }

        private void Btn_next_Click(object sender, RoutedEventArgs e)
        {
            int  newIndex =  tc_control.SelectedIndex + 1;
            if (newIndex >= tc_control.Items.Count) {
                newIndex = 0;
            }
            tc_control.SelectedIndex = newIndex;
        }

        private void Btn_prev_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tc_control.SelectedIndex - 1;
            if (newIndex < 0) {
                newIndex = tc_control.Items.Count - 1;
            }
            tc_control.SelectedIndex = newIndex;
        }
    }
}
