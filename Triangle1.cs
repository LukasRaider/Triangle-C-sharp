using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }

        public Triangle(float a)
        { A = a;B = a; C = a; }
        public Triangle(float a,float b)
        { A = a;B = b;C = a; }
        public Triangle(float a,float b, float c)
        { A = a;B = b;C = c; }
        public bool Exists()
        {
            return A + B > C && B + C > A && A + C > B;
        }
        public double Perimeter()
        {
            if (Exists()) { return A + B + C; }
            else { return 0.0; }
        }
    }
    class TestTriangle
    {
        public static void Mainx(string[] args)
        {
            Triangle triangle = new Triangle(3, 4, 5);

            if (triangle.Exists())
            {
                Console.WriteLine($"Trojúhelník existuje s obvodem {triangle.Perimeter()}");
            }
            else
            {
                Console.WriteLine("Trojúhelník neexistuje.");
            }

            // Vytvoření rovnostranného trojúhelníka se stranou délky 6.
            Triangle equilateralTriangle = new Triangle(6);

            if (equilateralTriangle.Exists())
            {
                Console.WriteLine($"Rovnostranný trojúhelník existuje s obvodem {equilateralTriangle.Perimeter()}");
            }
            else
            {
                Console.WriteLine("Rovnostranný trojúhelník neexistuje.");
            }
        }
    }
}
