using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FiguresTests
{
    public class FigureTest
    {

        [Fact]
        public void FigureCircleTest()
        {
            int radius = 2;
            double expected = 4 * Math.PI;
            Figures.IFigure figure = new Figures.Circle(radius);

            double actual = figure.GetArea();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FigureTriangleTest()
        {
            int a = 6;
            int b = 8;
            int c = 10;
            Figures.IFigure figure = new Figures.Triangle(a, b, c);
            double expected = 24;


            double actual = figure.GetArea();

            Assert.Equal(expected, actual);
        }
    }
}
