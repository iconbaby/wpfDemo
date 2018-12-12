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
    /// Interaction logic for CheckBoxWindow.xaml
    /// </summary>
    public partial class CheckBoxWindow : Window
    {
        public CheckBoxWindow()
        {
            InitializeComponent();
        }

        private void CbAllFeature_Checked(object sender, RoutedEventArgs e)
        {
            bool newVal = cbAllFeature.IsChecked == true;
            cbFeatureAbc.IsChecked = newVal;
            cbFeatureXyz.IsChecked = newVal;
            cbFeatureWww.IsChecked = newVal;
        }


        private void CbFeatureAbc_Checked(object sender, RoutedEventArgs e)
        {
            cbAllFeature.IsChecked = null;
            if (cbFeatureAbc.IsChecked == true && cbFeatureXyz.IsChecked == true && cbFeatureWww.IsChecked == true) {
                cbAllFeature.IsChecked = true;
            }
            if (cbFeatureAbc.IsChecked ==false && cbFeatureXyz.IsChecked == false && cbFeatureWww.IsChecked == false)
            {
                cbAllFeature.IsChecked = false;
            }

        }
    }
}
