using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle3
    {
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }
        public bool IsRightAngled { get; set; }

        public Triangle3(float a)
        { A = a; B = a; C = a; }
        public Triangle3(float a, float b)
        { A = a; B = b; C = a; }
        public Triangle3(float a, float b, float c, bool isRightAngled = false)
        {
            A = a; B = b; C = c; IsRightAngled = isRightAngled;
        }
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
    class TestTriangle3
    {
        public static void Mainx(string[] args)
        {
            Triangle3 T1 = new Triangle3(3, 4, 5, true);
            Triangle3 T2 = new Triangle3(3, 3, 3, false);

            Console.WriteLine("Existuje trojúhelník T1? " + T1.Exists());
            Console.WriteLine("Existuje trojúhelník T2? " + T2.Exists());
        }
    }
}
