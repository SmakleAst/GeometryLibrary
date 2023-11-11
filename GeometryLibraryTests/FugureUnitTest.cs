using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;
using GeometryLibrary.Figures;

namespace GeometryLibraryTests
{
    [TestClass]
    public class FigureTests
    {
        [TestMethod]
        public void Circle_GetArea_ReturnsCorrectArea()
        {
            for (double radius = 0; radius < 100; radius += 0.3)
            {
                var circle = new Circle(radius);

                Assert.AreEqual(Math.Round(Math.PI * radius * radius, 8),
                    Math.Round(circle.GetArea(), 8));
            }
        }

        [TestMethod]
        public void Triangle_GetArea_ReturnsCorrectArea()
        {
            for (double firstSide = 0, secondSide = 1, thirdSide = 3;
                thirdSide < 100; firstSide += 0.1, secondSide += 0.2, thirdSide += 0.3)
            {
                var triangle = new Triangle(firstSide, secondSide, thirdSide);

                double triangleSemiperimeter = (firstSide + secondSide + thirdSide) / 2;

                Assert.AreEqual(Math.Sqrt(triangleSemiperimeter *
                        (triangleSemiperimeter - firstSide) *
                        (triangleSemiperimeter - secondSide) *
                        (triangleSemiperimeter - thirdSide)),
                    triangle.GetArea());
            }
        }
    }
}
