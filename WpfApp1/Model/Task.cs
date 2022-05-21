using System;
using WpfApp1.Model;

namespace WpfApp1
{
    public partial class Task : BaseViewModel
    {
        private int _id;
        private string _title;
        private DateTime _datePub;
        private int _pubUser;
        private int? _takeUser;
        private string _description;
        private int _statusId;

        public int Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged("Id"); }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; OnPropertyChanged("Title"); }
        }
        public DateTime DatePub
        {
            get { return _datePub; }
            set { _datePub = value; OnPropertyChanged("DatePub"); }
        }
        public int PubUser
        {
            get { return _pubUser; }
            set { _pubUser = value; OnPropertyChanged("PubUser"); }
        }
        public int? TakeUser
        {
            get { return _takeUser; }
            set { _takeUser = value; OnPropertyChanged("TakeUser"); }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChanged("Description"); }
        }
        public int StatusId
        {
            get { return _statusId; }
            set { _statusId = value; OnPropertyChanged("StatusId"); }
        }

        public virtual User PubUserNavigation { get; set; } = null!;
        public virtual Status Status { get; set; } = null!;
        public virtual User? TakeUserNavigation { get; set; }
    }
}
