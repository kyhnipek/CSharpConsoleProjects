namespace AreaCalculator
{
    abstract class Shape
    {
        public abstract void GetDimensions();
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        public abstract void ShowResults();
    }
}