using System.Collections;

namespace ATM
{
    public class Menu
    {
        public static void Show()
        {
            Utils.Seperator();
            Console.WriteLine(" (1) Para Çekme\n (2) Para Yatırma\n (3) Para Gönderme\n (4) Bakiye Görüntüleme\n (5) İşlem Geçmişim\n (6) Çıkış");
            Utils.Seperator();
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz: ");
            int selection = Utils.GetInt();

            switch (selection)
            {
                case 1:
                    Operations.WithdrawMoney();
                    break;
                case 2:
                    Operations.DepositMoney();
                    break;
                case 3:
                    Operations.SendMoney();
                    break;
                case 4:
                    Operations.ShowBalance();
                    break;
                case 5:
                    Logs.ReadLog();
                    break;
                default:
                    break;
            }
        }

    }
}