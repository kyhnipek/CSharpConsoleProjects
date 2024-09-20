namespace ATM
{
    public static class Utils
    {
        public static void Seperator()
        {
            Console.WriteLine("******************************");
        }
        public static int GetInt()
        {
            string param = Console.ReadLine();
            if (int.TryParse(param, out int result) && result > 0)
            {
                return result;
            }
            else
            {
                Console.Write("Hatalı giriş yaptınız, lütfen tekrar deneyin: ");
                return GetInt();
            }
        }
        public static double GetDouble()
        {
            string param = Console.ReadLine();
            if (double.TryParse(param, out double result) && result > 0)
            {
                return result;
            }
            else
            {
                Console.Write("Hatalı giriş yaptınız, lütfen tekrar deneyin: ");
                return GetDouble();
            }
        }
    }
}