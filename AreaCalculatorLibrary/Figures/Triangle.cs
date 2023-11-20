using AreaCalculatorLibrary.Interfaces;

namespace AreaCalculatorLibrary.Figures
{
    public class Triangle : ICalculateArea
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        private bool _isRightangle;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || 
                sideB <= 0 || 
                sideC <= 0 ||
                sideA + sideB <= sideC ||
                sideA + sideC <= sideB ||
                sideB + sideC <= sideA)
            {
                throw new ArgumentException("Triangle with such sides cannot exist");
            }

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
            _isRightangle = this.IsRightangle();
        }

        public double CalculateArea()
        {
            return CalculateTriangleArea();
        }

        private double CalculateTriangleArea()
        {
            if (!_isRightangle)
            {
                double halfPerimetr = (_sideA + _sideB + _sideC) / 2;

                return Math.Sqrt(halfPerimetr * (halfPerimetr - _sideA) * (halfPerimetr - _sideB) * (halfPerimetr - _sideC));
            }

            if (Math.Max(_sideA, Math.Max(_sideB, _sideC)) == _sideA)
            {
                return (_sideB * _sideC) / 2;
            }

            if (Math.Max(_sideA, Math.Max(_sideB, _sideC)) == _sideB)
            {
                return (_sideA * _sideC) / 2;
            }

            return (_sideA * _sideB) / 2;
        }

        private bool IsRightangle()
        {
            if (_sideA * _sideA + _sideB * _sideB == _sideC * _sideC ||
                _sideA * _sideA + _sideC * _sideC == _sideB * _sideB ||
                _sideB * _sideB + _sideC * _sideC == _sideA * _sideA)
            {
                return true;
            }

            return false;
        }
    }
}
