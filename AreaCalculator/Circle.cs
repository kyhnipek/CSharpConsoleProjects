namespace AreaCalculator
{
    class Circle : Shape
    {
        private int radius;

        public Circle()
        {
            GetDimensions();
            ShowResults();
        }

        public int Radius
        { get => radius; set => radius = value; }

        public override double CalculateArea()
        {
            return 3.14 * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * 3.14 * Radius;
        }
        public override void GetDimensions()
        {
            Console.Write("Yarıçap: ");
            radius = Utils.CheckInt();
        }

        public override void ShowResults()
        {
            Console.WriteLine("Dairenin çevresi: {0}, alanı {1}", CalculatePerimeter(), CalculateArea());
            Menu.Show();
        }
    }
}