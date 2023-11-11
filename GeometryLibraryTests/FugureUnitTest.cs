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

                Assert.AreEqual(Math.PI * Math.Pow(radius, 2), circle.GetArea());
            }
        }

        [TestMethod]
        public void Triangle_GetArea_ReturnsCorrectArea()
        {
            for (double firstSide = 3, secondSide = 4, thirdSide = 5;
                thirdSide < 100; firstSide += 0.1, secondSide += 0.1, thirdSide += 0.1)
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

        [TestMethod]
        public void TriangleIsRightTriangle_ReturnsTrue_WhenTriangleIsRight()
        {
            var rightTriangles = new List<Triangle>()
            {
                new Triangle(3, 4, 5),
                new Triangle(5, 12, 13),
                new Triangle(8, 15, 17),
                new Triangle(7, 24, 25),
                new Triangle(20, 21, 29),
                new Triangle(12, 35, 37),
                new Triangle(9, 40, 41),
                new Triangle(28, 45, 53),
                new Triangle(11, 60, 61),
                new Triangle(16, 63, 65),
                new Triangle(33, 56, 65),
                new Triangle(48, 55, 73),
                new Triangle(13, 84, 85),
                new Triangle(36, 77, 85),
                new Triangle(39, 80, 89),
                new Triangle(65, 72, 97)
            };

            rightTriangles.ForEach(rightTriangle =>
            {
                Assert.IsTrue(rightTriangle.IsRightTriangle());
            });
        }

        [TestMethod]
        public void TriangleIsRightTriangle_ReturnsFalse_WhenTriangleIsNotRight()
        {
            var notRightTriangles = new List<Triangle>()
            {
                new Triangle(4, 4, 5),
                new Triangle(6, 12, 13),
                new Triangle(9, 15, 17),
                new Triangle(8, 24, 25),
                new Triangle(21, 21, 29),
                new Triangle(13, 35, 37),
                new Triangle(10, 40, 41),
                new Triangle(29, 45, 53),
                new Triangle(12, 60, 61),
                new Triangle(17, 63, 65),
                new Triangle(34, 56, 65),
                new Triangle(49, 55, 73),
                new Triangle(14, 84, 85),
                new Triangle(37, 77, 85),
                new Triangle(40, 80, 89),
                new Triangle(66, 72, 97)
            };

            notRightTriangles.ForEach(notRightTriangle =>
            {
                Assert.IsFalse(notRightTriangle.IsRightTriangle());
            });
        }
    }
}
