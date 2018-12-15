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
using System.Collections.Generic;
using System.ComponentModel;
namespace HelloWpf
{
    /// <summary>
    /// Interaction logic for ListViewWindow.xaml
    /// </summary>
    public partial class ListViewWindow : Window
    {
        private GridViewColumnHeader listViewSortCol = null;
        private SortAdorner listViewSortAdorner = null;
        public ListViewWindow()
        {
            InitializeComponent();
            List<UserList> listItem = new List<UserList>();
            listItem.Add(new UserList { Name = "jone", Age = 12, Email = "jone@163.com" ,Sex = SexType.Male});
            listItem.Add(new UserList { Name = "mike", Age = 24, Email = "mike@163.com",Sex=SexType.Male });
            listItem.Add(new UserList { Name = "alien", Age = 87, Email = "alien@163.com", Sex=SexType.Male });
            listItem.Add(new UserList { Name = "jane", Age = 25, Email = "jane@163.com" ,Sex = SexType.Female});
            lv_connect.ItemsSource = listItem;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lv_connect.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Sex");
            //view.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
            //view.SortDescriptions.Add(new SortDescription("Age", ListSortDirection.Ascending));
            view.GroupDescriptions.Add(groupDescription);


        }

        private void lvUsersColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader column = (sender as GridViewColumnHeader);
            string sortBy = column.Tag.ToString();
            if (listViewSortCol != null)
            {
                AdornerLayer.GetAdornerLayer(listViewSortCol).Remove(listViewSortAdorner);
                lv_connect.Items.SortDescriptions.Clear();
            }

            ListSortDirection newDir = ListSortDirection.Ascending;
            if (listViewSortCol == column && listViewSortAdorner.Direction == newDir)
                newDir = ListSortDirection.Descending;

            listViewSortCol = column;
            listViewSortAdorner = new SortAdorner(listViewSortCol, newDir);
            AdornerLayer.GetAdornerLayer(listViewSortCol).Add(listViewSortAdorner);
            lv_connect.Items.SortDescriptions.Add(new SortDescription(sortBy, newDir));
        }
    }

    public class SortAdorner : Adorner
    {
        private static Geometry ascGeometry =
            Geometry.Parse("M 0 4 L 3.5 0 L 7 4 Z");

        private static Geometry descGeometry =
            Geometry.Parse("M 0 0 L 3.5 4 L 7 0 Z");

        public ListSortDirection Direction { get; private set; }

        public SortAdorner(UIElement element, ListSortDirection dir)
            : base(element)
        {
            this.Direction = dir;
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            if (AdornedElement.RenderSize.Width < 20)
                return;

            TranslateTransform transform = new TranslateTransform
                (
                    AdornedElement.RenderSize.Width - 15,
                    (AdornedElement.RenderSize.Height - 5) / 2
                );
            drawingContext.PushTransform(transform);

            Geometry geometry = ascGeometry;
            if (this.Direction == ListSortDirection.Descending)
                geometry = descGeometry;
            drawingContext.DrawGeometry(Brushes.Black, null, geometry);

            drawingContext.Pop();
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
