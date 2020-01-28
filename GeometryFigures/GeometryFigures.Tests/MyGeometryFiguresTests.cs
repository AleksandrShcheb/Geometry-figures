using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryFigures.Tests
{
    [TestClass]
    public class MyGeometryFiguresTests
    {
        [TestMethod]
        public void TestCorrectCircleArea()
        {
            double radius = 5;
            double expected = 78.53981633974483;

            var circle = new Circle(radius);
            double areaResult = circle.Area();

            Assert.AreEqual(expected, areaResult);
        }
        [TestMethod]
        public void TestCorrectTriangleArea()
        {
            double[] sides = { 5, 9, 12 };
            double expected = 20.396078054371138;

            var triangle = new Triangle(5, 9, 12);
            double areaResult = triangle.Area();

            Assert.AreEqual(expected, areaResult);
        }
    }
}

