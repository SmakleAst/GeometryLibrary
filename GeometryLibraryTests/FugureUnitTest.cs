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
    }
}
