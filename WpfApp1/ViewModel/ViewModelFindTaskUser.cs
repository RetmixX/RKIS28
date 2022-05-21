using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

namespace WpfApp1.ViewModel
{
    public class ViewModelFindTaskUser: DependencyObject
    {


        public string FilterText
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }
        
        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register("FilterText", typeof(string), typeof(ViewModelFindTaskUser), new PropertyMetadata("", Filter_Change));

        public ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(ViewModelFindTaskUser), new PropertyMetadata(null));

        public ViewModelFindTaskUser()
        {
            Items = CollectionViewSource.GetDefaultView(Connection.db.Tasks.Include(x => x.PubUserNavigation).Include(x => x.TakeUserNavigation).Include(x => x.Status));
            Items.Filter = FilterTask;
        }

        private static void Filter_Change(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var task = d as ViewModelFindTaskUser;
            task.Items.Filter = null;
            task.Items.Filter = task.FilterTask;
        }

        private bool FilterTask(object obj)
        {
            Task task = obj as Task;
            if (!string.IsNullOrWhiteSpace(FilterText)&&task !=null && !task.PubUserNavigation.Login.Contains(FilterText))
            {
                return false;
            }

            return true;
        }
    }
}
