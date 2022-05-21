using System.Collections.ObjectModel;
using System.Linq;
using WpfApp1.Model;
using System.Windows;
using WpfApp1.View;

namespace WpfApp1.ViewModel
{
    internal class ViewModelMainWindow:BaseViewModel
    {
        private User _user;
        private RealyCommand _commandSignUp;
        private RealyCommand _registration;

        public User User
        {
            get { return _user; }
            set { _user = value; OnPropertyChanged("User"); }
        }

        public RealyCommand CommandSignUp
        {
            get 
            {
                return _commandSignUp ?? (_commandSignUp = new RealyCommand(x =>
                {
                    var user = Connection.db.Users.FirstOrDefault(x => x.Login == _user.Login && x.Password == _user.Password);
                    if (user != null)
                    {
                        Connection.userAuth = user;
                        new MenuWindow().Show();
                        Application.Current.MainWindow.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка!", "Проверка");
                    }
                }));
            }
        }

        public RealyCommand Registration
        {
            get
            {
                return _registration ?? (_registration = new RealyCommand(x =>
                {
                    new RegistrationWindow().ShowDialog();
                }));
            }
        }

        public ObservableCollection<User> Users { get; set; }

        public ViewModelMainWindow()
        {
            _user = new User();
        }
    }
}
