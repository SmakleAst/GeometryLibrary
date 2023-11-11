using GeometryLibrary.Abstract;

namespace GeometryLibrary.Figures
{
    public class Circle : Figure
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть отрицательным", nameof(radius));
            }

            _radius = radius;
        }
        
        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
