using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figures
{
    public class Triangle : IFigure
    {

        private int[] Sides = new int[3];

        public Triangle(int FirstSide, int SecondSide, int ThirdSide)
        {
            Sides[0] = FirstSide;
            Sides[1] = SecondSide;
            Sides[2] = ThirdSide;
        }
        public double GetArea()
        {
            double p = (Sides.Sum()) / 2;
            return Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
        }

        public bool IsRectangle()
        {
            if (Sides[0] * Sides[0] + Sides[1] * Sides[1] == Sides[2] * Sides[2] ||
                Sides[0] * Sides[0] + Sides[2] * Sides[2] == Sides[1] * Sides[1] ||
                Sides[2] * Sides[2] + Sides[1] * Sides[1] == Sides[0] * Sides[0]) return true;
            return false;
        }
    }
}
