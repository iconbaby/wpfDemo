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
    /// Interaction logic for ListViewWindow.xaml
    /// </summary>
    public partial class ListViewWindow : Window
    {
        public ListViewWindow()
        {
            InitializeComponent();
            List<UserList> listItem = new List<UserList>();
            listItem.Add(new UserList { Name = "jone", Age = 12, Email = "jone@163.com" ,Sex = SexType.Male});
            listItem.Add(new UserList { Name = "mike", Age = 24, Email = "mike@163.com",Sex=SexType.Male });
            listItem.Add(new UserList { Name = "jane", Age = 25, Email = "jane@163.com" ,Sex = SexType.Female});
            lv_connect.ItemsSource = listItem;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lv_connect.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Sex");
            view.GroupDescriptions.Add(groupDescription);
        }
    }
    public enum SexType { Male,Female}

    public class UserList
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public SexType Sex { get; set; }
    }
}
