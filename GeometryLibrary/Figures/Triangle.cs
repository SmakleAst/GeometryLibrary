using GeometryLibrary.Abstract;

namespace GeometryLibrary.Figures
{
    public class Triangle : Figure
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < 0 || secondSide < 0 || thirdSide < 0)
            {
                throw new ArgumentException("Длина стороны треугольника не может быть отрицательной",
                    nameof(firstSide));
            }

            if (firstSide + secondSide <= thirdSide ||
                firstSide + thirdSide <= secondSide ||
                secondSide + thirdSide <= firstSide)
            {
                throw new ArgumentException("Сумма двух сторон треугольника должна быть больше длины третьей стороны",
                    nameof(firstSide));
            }

            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }
            

        public override double GetArea()
        {
            double triangleSemiperimeter = (_firstSide + _secondSide + _thirdSide) / 2;
            return Math.Sqrt(triangleSemiperimeter *
                (triangleSemiperimeter - _firstSide) *
                (triangleSemiperimeter - _secondSide) *
                (triangleSemiperimeter - _thirdSide));
        }

        public bool IsRightTriangle()
        {
            double[] sides = { _firstSide, _secondSide, _thirdSide };
            Array.Sort(sides);
            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
    }
}
