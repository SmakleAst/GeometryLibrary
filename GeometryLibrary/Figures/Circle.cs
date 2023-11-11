using GeometryLibrary.Abstract;

namespace GeometryLibrary.Figures
{
    public class Circle : Figure
    {
        private double _radius;

        public Circle(double radius) =>
            _radius = radius;
        
        public override double GetArea()
        {
            return Math.PI * _radius;
        }
    }
}
