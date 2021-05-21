using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FiguresTests
{
    public class CircleTest
    {

        [Fact]
        public void AreaTest()
        {
            int radius = 2;
            double expected = 4 * Math.PI;
            Figures.Circle circle = new Figures.Circle(radius);

            double actual = circle.GetArea();

            Assert.Equal(expected, actual);
        }
    }
}
