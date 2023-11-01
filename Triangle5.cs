using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Triangle
{
    class Point
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X:F2}; {Y:F2})";
        }
    }

    class Triangle5
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }

        public Triangle5(float a, float b, float c)
        {
            A = new Point(0, a);
            B = new Point(0, 0);
            C = new Point(b, 0);
        }

        public Triangle5(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }

        public string GetType()
        {
            double sideA = Math.Sqrt(Math.Pow(B.X - C.X, 2) + Math.Pow(B.Y - C.Y, 2));
            double sideB = Math.Sqrt(Math.Pow(A.X - C.X, 2) + Math.Pow(A.Y - C.Y, 2));
            double sideC = Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));

            if (sideA == sideB && sideB == sideC)
            {
                return "rovnostranný";
            }
            else if (sideA == sideB || sideB == sideC || sideA == sideC)
            {
                if (sideA * sideA + sideB * sideB == sideC * sideC
                    || sideB * sideB + sideC * sideC == sideA * sideA
                    || sideA * sideA + sideC * sideC == sideB * sideB)
                {
                    return "rovnoramenný a pravoúhlý";
                }
                return "rovnoramenný";
            }
            else
            {
                if (sideA * sideA + sideB * sideB == sideC * sideC
                    || sideB * sideB + sideC * sideC == sideA * sideA
                    || sideA * sideA + sideC * sideC == sideB * sideB)
                {
                    return "pravoúhlý";
                }
                return "běžný";
            }
        }

        public override string ToString()
        {
            return $"Trojúhelník s vrcholy: A={A}, B={B}, C={C}.";
        }
    }

    class TestTriangle5
    {
        public static void Mainx(string[] args)
        {
            Triangle5 T1 = new Triangle5(3, 4, 5);
            Triangle5 T2 = new Triangle5(new Point(0, 3), new Point(0, 0), new Point(4, 0));

            Console.WriteLine(T1);
            Console.WriteLine("Typ trojúhelníka T1: " + T1.GetType());

            Console.WriteLine(T2);
            Console.WriteLine("Typ trojúhelníka T2: " + T2.GetType());
        }
    }
}

