using System.Windows;

namespace WpfApp1.View
{
    public partial class MyTaskInfoWindow : Window
    {
        private bool _canChange = false;
        public MyTaskInfoWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Des.IsReadOnly = _canChange;
            if (_canChange)
            {
                _canChange = false;
                Save.Content = "Изменить";
                return;
            }
            Save.Content = "Готово";
            _canChange = true;
        }
    }
}
