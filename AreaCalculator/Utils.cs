namespace AreaCalculator
{
    public static class Utils
    {
        public static int CheckInt()
        {
            string param = Console.ReadLine();
            if (int.TryParse(param, out int result) && result > 0)
            {
                return result;
            }
            else
            {
                Console.Write("Hatalı giriş yaptınız, lütfen tekrar deneyin: ");
                return CheckInt();
            }
        }
    }
}