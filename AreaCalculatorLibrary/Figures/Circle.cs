using AreaCalculatorLibrary.Interfaces;

namespace AreaCalculatorLibrary.Figures
{
    public class Circle : ICalculateArea
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Circle must have radius greater than 0");
            }

            _radius = radius;
        }

        public double CalculateArea()
        {
            return CalculateCircleArea();
        }

        private double CalculateCircleArea()
        {
            return _radius * _radius * Math.PI;
        }
    }
}
