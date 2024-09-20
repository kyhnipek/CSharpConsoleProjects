namespace AreaCalculator
{
    class Rectangular : Shape
    {
        private int shortSide;
        private int longSide;

        public Rectangular()
        {
            GetDimensions();
            ShowResults();
        }

        public int ShortSide { get => shortSide; set => shortSide = value; }
        public int LongSide { get => longSide; set => longSide = value; }

        public override double CalculateArea()
        {
            return ShortSide * LongSide;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (ShortSide + LongSide);
        }
        public override void GetDimensions()
        {
            Console.Write("Uzun kenar: ");
            LongSide = Utils.CheckInt();
            Console.Write("Kısa kenar: ");
            ShortSide = Utils.CheckInt();
        }

        public override void ShowResults()
        {
            Console.WriteLine("Dikdörtgenin çevresi: {0}, alanı {1}", CalculatePerimeter(), CalculateArea());
            Menu.Show();
        }
    }
}