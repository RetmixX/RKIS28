using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Linq;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    public class UserInfoWindowViewModel: BaseViewModel
    {
        private User _selectedUser = Connection.selectUser;
        public ObservableCollection<Task> Tasks { get; set; }

        public UserInfoWindowViewModel()
        {
            Tasks = new ObservableCollection<Task>(Connection.db.Tasks.Include(x => x.PubUserNavigation).Include(x => x.TakeUserNavigation).Include(x => x.Status).Where(x => x.TakeUser == _selectedUser.Id&&x.StatusId==1));
        }
    }
}
