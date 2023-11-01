using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Triangle
{
    class OrthogonalTriangle : Triangle2 { 
        public OrthogonalTriangle(float a, float b) : base(a, b) {
            A = a;
            B = b;
            Double result = 0.0;
            result = Math.Sqrt(a * a + b * b);
            C = (float)result;
        }
    }
    class Triangle2
    {
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }

        public Triangle2(float a)
        { A = a; B = a; C = a; }
        public Triangle2(float a, float b)
        { A = a; B = b; C = a; }
        public Triangle2(float a, float b, float c)
        { A = a; B = b; C = c; }
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
    class TestTriangle2 {
        public static void Mainx(string[] args)
        {
            Triangle2 T1 = new Triangle2(100, 1, 1);
            Triangle2 T2 = new Triangle2(3, 4, 5);
            Triangle2 T3 = new Triangle2(3, 4);
            Triangle2 T4 = new Triangle2(3);
            OrthogonalTriangle T5 = new OrthogonalTriangle(3, 4);

            Console.WriteLine("Existuje trojúhelník T1? " + T1.Exists());
            Console.WriteLine("Existuje trojúhelník T2? " + T2.Exists());
            Console.WriteLine("Obvod T4: " + T4.Perimeter());
            Console.WriteLine("Obvod pravoúhlého T5: " + T5.Perimeter());
        }
    }
}
