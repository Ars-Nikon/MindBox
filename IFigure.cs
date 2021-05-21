using System;
using System.Collections.Generic;
using System.Text;

namespace Figure_area
{
    public interface IFigure
    {
        public double GetArea();
    }

    public class Circle : IFigure
    {
        private readonly double Radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new Exception("Radius must not be zero or less than zero");
            }
            else
            {
                Radius = radius;
            }
        }
        public double GetArea() => Math.PI * Math.Pow(Radius, 2);
    }

    public class Triangle : IFigure
    {
        private readonly double Side1, Side2, Side3;

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0)
            {
                throw new Exception("Side must not be zero or less than zero");
            }
            if (side2 <= 0)
            {
                throw new Exception("Side must not be zero or less than zero");
            }
            if (side3 <= 0)
            {
                throw new Exception("Side must not be zero or less than zero");
            }
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            if (!(Side1 + Side2 > Side3 && Side2 + Side3 > Side1 && Side1 + Side3 > Side2))
            {
                throw new Exception("A triangle with such values does not exist");
            }
        }

        public bool IsRightTriangle()
        {
            double maxSide = Math.Max(Math.Max(Side1, Side2), Side3);

            if (maxSide == Side1)
            {
                return Math.Sqrt(Math.Pow(Side2, 2) + Math.Pow(Side3, 2)) == Side1;
            }
            if (maxSide == Side2)
            {
                return Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side3, 2)) == Side2;
            }
            else
            {
                return Math.Sqrt(Math.Pow(Side2, 2) + Math.Pow(Side1, 2)) == Side3;
            }

        }






        public double GetArea()
        {
            double semiperimeter = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - Side1) * (semiperimeter - Side2) * (semiperimeter - Side3));
        }

    }

    public class Square : IFigure
    {
        private readonly double Width, Length;

        public Square(double width, double length)
        {
            if (width <= 0)
            {
                throw new Exception("Width must not be zero or less than zero");
            }
            Width = width;
            if (length <= 0)
            {
                throw new Exception("Length must not be zero or less than zero");
            }
            Length = length;
        }

        public double GetArea()
        {

            return Length * Width;
        }
    }



}


