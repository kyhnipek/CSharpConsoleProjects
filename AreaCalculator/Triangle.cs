namespace AreaCalculator
{
    class Triangle : Shape
    {
        private int baseSide;
        private int leftSide;
        private int rightSide;
        public Triangle()
        {
            GetDimensions();
            ShowResults();
        }

        public int BaseSide { get => baseSide; set => baseSide = value; }
        public int LeftSide { get => leftSide; set => leftSide = value; }
        public int RightSide { get => rightSide; set => rightSide = value; }

        public override double CalculateArea()
        {
            double u = 0.5 * CalculatePerimeter();
            return Math.Sqrt(u * (u - baseSide) * (u - leftSide) * (u - rightSide));
        }

        public override double CalculatePerimeter()
        {
            return LeftSide + RightSide + BaseSide;
        }

        public override void GetDimensions()
        {
            Console.Write("Sol kenar: ");
            LeftSide = Utils.CheckInt();
            Console.Write("Sağ kenar: ");
            RightSide = Utils.CheckInt();
            Console.Write("Alt kenar: ");
            BaseSide = Utils.CheckInt();
        }

        public override void ShowResults()
        {
            Console.WriteLine("Üçgenin çevresi: {0}, alanı {1}", CalculatePerimeter(), CalculateArea());
            Menu.Show();
        }
    }
}