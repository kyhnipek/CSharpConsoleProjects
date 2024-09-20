namespace AreaCalculator
{
    class Square : Shape
    {
        private int side;

        public Square()
        {
            GetDimensions();
            ShowResults();
        }

        public int Side { get => side; set => side = value; }

        public override double CalculateArea()
        {
            return Side * Side;
        }

        public override double CalculatePerimeter()
        {
            return 4 * Side;
        }

        public override void GetDimensions()
        {
            Console.Write("Kenar uzunluğu: ");
            Side = Utils.CheckInt();
        }

        public override void ShowResults()
        {
            Console.WriteLine("Karenin çevresi: {0}, alanı {1}", CalculatePerimeter(), CalculateArea());
            Menu.Show();
        }
    }
}