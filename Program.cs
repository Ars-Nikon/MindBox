using System;

namespace Figure_area
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(0.5);
            Console.WriteLine("Площадь круга: " + circle.GetArea());
            Triangle traingle = new Triangle(2, 2, Math.Sqrt(8));
            Console.WriteLine("Площадь треугольника: " + traingle.GetArea());
            if (traingle.IsRightTriangle())
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
            else
            {
                Console.WriteLine("Треугольник не прямоугольный");
            }

            Square square = new Square(2, 5);
            Console.WriteLine("Площадь квадрата: " + square.GetArea());

            try
            {
                Circle circle2 = new Circle(-0.5);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            try
            {
                Triangle traingle2 = new Triangle(1, 22, 6);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
