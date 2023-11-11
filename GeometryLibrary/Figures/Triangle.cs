using GeometryLibrary.Abstract;

namespace GeometryLibrary.Figures
{
    public class Triangle : Figure
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide) =>
            (_firstSide, _secondSide, _thirdSide) = (firstSide, secondSide, thirdSide);

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

        }
    }
}
