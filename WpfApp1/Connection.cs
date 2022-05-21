namespace WpfApp1
{
    public class Connection
    {
        public static TaskSystemBaseContext db = new TaskSystemBaseContext();

        public static User userAuth = new User();
        public static Task selectTask = new Task();
        public static User selectUser = new User();

    }
}
