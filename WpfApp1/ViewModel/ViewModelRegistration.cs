using WpfApp1.Model;
using WpfApp1.View;

namespace WpfApp1.ViewModel
{
    public class ViewModelRegistration:BaseViewModel
    {
        private User _user;
        private RealyCommand _reg;

        public User User
        {
            get { return _user; }
            set { _user = value; OnPropertyChanged("User"); }
        }

        public RealyCommand Reg
        {
            get
            {
                return _reg ?? (_reg = new RealyCommand(x =>
                {
                    Connection.db.Add(User);
                    Connection.db.SaveChanges();
                    CloseWindow();

                }));
            }
        }

        public ViewModelRegistration()
        {
            _user = new User();
        }

        public void CloseWindow()
        {
            foreach (var win in App.Current.Windows)
            {
                if (win is RegistrationWindow registrationWindow)
                {
                    registrationWindow.Close();
                }
            }
        }
    }
}
