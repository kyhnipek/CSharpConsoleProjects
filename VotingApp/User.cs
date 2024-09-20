using System.Collections;

namespace VotingApp
{
    class User
    {
        private int userId;
        private string userName;
        private bool isVoted;
        private List<User> userList = new List<User>();

        public User()
        {
            userList.Add(new User(0, "Ali", false));
            userList.Add(new User(1, "Ahmet", false));
            userList.Add(new User(2, "Mehmet", false));
            userList.Add(new User(3, "Veli", false));
        }

        public User(int userId, string userName, bool isVoted)
        {
            this.userId = userId;
            this.userName = userName;
            this.isVoted = isVoted;
        }
        public User(string userName)
        {
            this.userName = userName;
        }


        public int UserId { get => userId; set => userId = userList.Count + 1; }
        public string UserName { get => userName; set => userName = value; }
        public bool IsVoted { get => isVoted; set => isVoted = (value != null && value); }
        internal List<User> UserList { get => userList; set => userList = value; }

        public bool UserCheck(string param)
        {
            foreach (var user in userList)
            {
                if (user.userName.ToLower() == param.ToLower())
                    return true;
            }
            return false;
        }
        public void UserRegister(string uname)
        {
            userList.Add(new User(uname));
            Console.WriteLine("Kayıt başarılı");
        }
    }
}