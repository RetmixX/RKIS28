using System.Collections.Generic;
using WpfApp1.Model;

namespace WpfApp1
{
    public partial class User : BaseViewModel
    {
        public User()
        {
            TaskPubUserNavigations = new HashSet<Task>();
            TaskTakeUserNavigations = new HashSet<Task>();
        }

        private int _id;
        private string _name;
        private string _surname;
        private string _lastname;
        private string _login;
        private string _password;
        private string _phone;

        public int Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged("Id"); }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged("Name"); }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; OnPropertyChanged("Surname"); }
        }
        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; OnPropertyChanged("Lastname"); }
        }
        public string Login
        {
            get { return _login; }
            set { _login = value; OnPropertyChanged("Login"); }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged("Password"); }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; OnPropertyChanged("Phone"); }
        }

        public virtual ICollection<Task> TaskPubUserNavigations { get; set; }
        public virtual ICollection<Task> TaskTakeUserNavigations { get; set; }
    }
}
