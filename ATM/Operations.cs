namespace ATM
{
    class Operations
    {
        public static User user;
        public static User Login()
        {
            Console.Write("Kullanıcı adınız: ");
            string u = Console.ReadLine();
            Console.Write("Şifreniz: ");
            string p = Console.ReadLine();
            user = User.users.FirstOrDefault(item => item.UserName.ToLower() == u.ToLower() && item.Password.ToLower() == p.ToLower());
            if (user != null)
            {
                Console.WriteLine("Giriş başarılı");
                Logs.WriteLog("Login", "Successfull");
                Utils.Seperator();
                return user;
            }
            else
            {
                Logs.WriteLog("Login", "Failed");
            }
            return null;
        }
        public static void WithdrawMoney()
        {
            Console.Write("Güncel bakiyeniz {0} TL, çekmek istediğiniz miktar: ", user.Balance);
            double amount = Utils.GetDouble();
            user.Balance -= amount;
            Logs.WriteLog("Withdraw Money", amount + " TL money withdraw successfull, current balance: " + user.Balance + " TL");
            Utils.Seperator();
            ShowBalance();
            Menu.Show();
        }
        public static void DepositMoney()
        {
            Console.Write("Güncel bakiyeniz {0} TL, yatırmak istediğiniz miktar: ", user.Balance);
            double amount = Utils.GetDouble();
            user.Balance += amount;
            Logs.WriteLog("Withdraw Money", amount + " TL money deposit successfull, current balance: " + user.Balance + " TL");
            Utils.Seperator();
            ShowBalance();
            Menu.Show();
        }
        public static void SendMoney()
        {

            Console.Write("Güncel bakiyeniz {0} TL, para göndermek istediğiniz kişinin hesap numarası: ", user.Balance);
            int id = Utils.GetInt();
            var receiver = User.users.FirstOrDefault(item => item.UserId == id);
            if (receiver != null)
            {
                Console.Write("Göndermek istediğiniz miktar: ");
                double amount = Utils.GetDouble();
                if (amount < user.Balance)
                {
                    Console.Write("{0} kişisine {1} TL gönderilecektir\nİşlemi onaylıyor musunuz ? (e/h): ", receiver.UserName, amount);
                    var s = Console.ReadLine();
                    if (s == "e")
                    {
                        user.Balance -= amount;
                        receiver.Balance += amount;
                        Logs.WriteLog("Withdraw Money", amount + " TL send to " + receiver.UserName + " successfully, current balance: " + user.Balance + " TL");
                        Utils.Seperator();
                        ShowBalance();
                    }
                    else
                    {
                        SendMoney();
                    }
                }
                else
                {
                    Logs.WriteLog("Withdraw Money", amount + " TL send to " + receiver.UserName + " failed, current balance: " + user.Balance + " TL");
                    Console.WriteLine("Bakiyeniz yetersiz");
                    SendMoney();
                }
            }
            else
            {
                SendMoney();
            }
            Menu.Show();
        }
        public static void ShowBalance()
        {
            Console.WriteLine("Güncel bakiyeniz {0} TL", user.Balance);
        }
    }
}