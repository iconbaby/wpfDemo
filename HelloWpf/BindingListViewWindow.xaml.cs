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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Collections.Generic;
namespace HelloWpf
{
    /// <summary>
    /// Interaction logic for BindingListViewWindow.xaml
    /// </summary>
    public partial class BindingListViewWindow : Window
    {
        public ObservableCollection <User> users = new ObservableCollection<User>();
        public BindingListViewWindow()
        {
            InitializeComponent();
            users.Add(new User() { Name = "mike" });
            users.Add(new User() { Name = "Jone" });
            lbDisplay.ItemsSource = users;
        }

        private void Button_Click_DeleteUser(object sender, RoutedEventArgs e)
        {
            if (lbDisplay.SelectedItem != null) {
                users.Remove(lbDisplay.SelectedItem as User);
            }
        }

        private void Button_Click_AddUser(object sender, RoutedEventArgs e)
        {
            users.Add(new User() { Name = "new User" });

        }

        private void Button_Click_ChangeUser(object sender, RoutedEventArgs e)
        {
            if (lbDisplay.SelectedItem != null) {
                (lbDisplay.SelectedItem as User).Name = "Radom Name";
            }
        }

    }

    public class User:INotifyPropertyChanged
    {
        private string name;
        public string Name {
            get { return this.name; }
            set {
                if (this.name != value) {
                    this.name = value;
                    this.NotifyPropertyChanged("Name");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propName) {
            if (this.PropertyChanged != null) {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
