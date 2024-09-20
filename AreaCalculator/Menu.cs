using System.Reflection.Metadata;

namespace AreaCalculator
{
    static class Menu
    {
        public static void Show()
        {
            Console.WriteLine("Lütfen işlem yapmak istediğiniz geometrik şekili seçiniz.\n (1) Daire\n (2) Üçgen\n (3) Kare\n (4) Dikdörtgen");
            Console.Write("Seçim: ");
            int selection = Utils.CheckInt();
            switch (selection)
            {
                case 1:
                    new Circle();
                    break;
                case 2:
                    new Triangle();
                    break;
                case 3:
                    new Square();
                    break;
                case 4:
                    new Rectangular();
                    break;
                default:
                    Console.WriteLine("Yanlış giriş yaptınız.");
                    Menu.Show();
                    break;
            }
        }

    }
}