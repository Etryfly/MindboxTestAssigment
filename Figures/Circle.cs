using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    public class Circle : IFigure
    {
        private int Radius;

        public Circle(int Radius)
        {
            this.Radius = Radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
