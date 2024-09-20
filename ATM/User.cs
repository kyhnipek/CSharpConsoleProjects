using System.Reflection.Metadata;

namespace ATM
{
    class User
    {
        public static List<User> users = new List<User>();
        private int userId;
        private string userName;
        private string password;
        private double balance;
        public static int globalId;

        public User(string userName, string password, double balance = 0)
        {
            this.userName = userName;
            this.password = password;
            this.balance = balance;
            this.userId = Interlocked.Increment(ref globalId);
        }

        public User()
        {
            users.Add(new User("ali", "123", 0));
            users.Add(new User("veli", "123", 0));
        }



        public int UserId { get => userId; set => userId = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public double Balance { get => balance; set => balance = value; }
        public List<User> Users { get => users; set => users = value; }

    }
}