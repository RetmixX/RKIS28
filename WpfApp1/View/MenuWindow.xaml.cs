using System.Windows;
using WpfApp1.ViewModel;

namespace WpfApp1.View
{
    public partial class MenuWindow : Window
    {
        private bool _canChange = false;
        public MenuWindow()
        {
            InitializeComponent();
            DataContext = new ViewModelMenuWindow();
            
            
        }

        private void ChangeProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            nameTBox.IsReadOnly = _canChange;
            surnameTBox.IsReadOnly = _canChange;
            lastnameTBox.IsReadOnly = _canChange;
            loginTBox.IsReadOnly = _canChange;
            phoneTBox.IsReadOnly = _canChange;
            if (_canChange)
            {
                _canChange = false;
                ChangeProfileBtn.Content = "Изменить";
                return;
            }
            ChangeProfileBtn.Content = "Готово";
            _canChange = true;
        }
    }
}
