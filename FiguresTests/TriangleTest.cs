using System;
using Xunit;

namespace FiguresTests
{
    public class TriangleTest
    {
        [Fact]
        public void AreaOfRectangleTest()
        {
            int a = 6;
            int b = 8;
            int c = 10;
            Figures.Triangle triangle = new Figures.Triangle(a, b, c);
            double expected = 24;


            double actual = triangle.GetArea();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsRectangleTrueTest()
        {
            int a = 6;
            int b = 8;
            int c = 10;
            Figures.Triangle triangle = new Figures.Triangle(a, b, c);

            Assert.True(triangle.IsRectangle());
        }

        [Fact]
        public void IsRectangleFalseTest()
        {
            int a = 6;
            int b = 8;
            int c = 11;
            Figures.Triangle triangle = new Figures.Triangle(a, b, c);

            Assert.False(triangle.IsRectangle());
        }
    }
}
