using AreaCalculatorLibrary.Figures;
using NUnit.Framework;

namespace AreaCalculatorTests
{
    public class CalculatingTests
    {
        private const double calculationAccuracy = 0.000001;

        [Test]
        [TestCase(1)]
        [TestCase(12)]
        [TestCase(0.002)]
        public void Circle_Area_Calculated_Correct(double radius)
        {
            // Arrange
            Circle circle = new Circle(radius);
            double mathArea = radius * radius * Math.PI;

            // Act
            double calculatedArea = circle.CalculateArea();

            // Assert
            Assert.IsTrue(Math.Abs(mathArea - calculatedArea) < calculationAccuracy);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-5)]
        public void Circle_Cannot_Be_Created(double radius)
        {
            // Arrange, Act, Assert
            Assert.Throws<ArgumentException>(() =>
            {
                Circle circle = new Circle(radius);
            });
        }

        [Test]
        [TestCase(3, 4, 6)]
        [TestCase(10, 10, 10)]
        [TestCase(9, 8, 7)]
        public void Non_Right_Triangle_Area_Calculated_Correct(double sideA, double sideB, double sideC)
        {
            // Arrange
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double halfPerimetr = (sideA + sideB + sideC) / 2;
            double mathArea = Math.Sqrt(halfPerimetr * (halfPerimetr - sideA) * (halfPerimetr - sideB) * (halfPerimetr - sideC));

            // Act
            double calculatedArea = triangle.CalculateArea();

            // Assert
            Assert.IsTrue(Math.Abs(mathArea - calculatedArea) < calculationAccuracy);
        }

        [Test]
        [TestCase(3, 4, 5)]
        [TestCase(5, 12, 13)]
        [TestCase(8, 15, 17)]
        public void Right_Triangle_Area_Calculated_Correct(double sideA, double sideB, double sideC)
        {
            // Arrange
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double mathArea = (sideA * sideB) / 2;

            // Act
            double calculatedArea = triangle.CalculateArea();

            // Assert
            Assert.IsTrue(Math.Abs(mathArea - calculatedArea) < calculationAccuracy);
        }

        [Test]
        [TestCase(0, 0, 0)]
        [TestCase(-10, 12, 18)]
        [TestCase(1, 52, 1)]
        public void Triangle_Cannot_Be_Created(double sideA, double sideB, double sideC)
        {
            // Arrange, Act, Assert
            Assert.Throws<ArgumentException>(() =>
            {
                Triangle triangle = new Triangle(sideA, sideB, sideC);
            });
        }
    }
}