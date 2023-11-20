using AreaCalculatorLibrary.Figures;
using AreaCalculatorLibrary.Interfaces;

namespace AreaCalculatorLibrary
{
    public class Calculator
    {
        public double CalculateArea(ICalculateArea calculateArea)
        {
            return calculateArea.CalculateArea();
        }

        public Circle CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        public Triangle CreateTriangle(double sideA, double sideB, double sideC)
        {
            return new Triangle(sideA, sideB, sideC);
        }
    }
}
