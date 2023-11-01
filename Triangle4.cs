using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Triangle
{
    class Triangle4
    {
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }

        public Triangle4(float a, float b, float c)
        {
            A = a;
            B = b;
            C = c;
        }

        public string GetType()
        {
            if (A == B && B == C)
            {
                return "rovnostranný";
            }
            else if (A == B || B == C || A == C)
            {
                if (Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2)
                    || Math.Pow(B, 2) + Math.Pow(C, 2) == Math.Pow(A, 2)
                    || Math.Pow(A, 2) + Math.Pow(C, 2) == Math.Pow(B, 2))
                {
                    return "rovnoramenný a pravoúhlý";
                }
                return "rovnoramenný";
            }
            else
            {
                if (Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2)
                    || Math.Pow(B, 2) + Math.Pow(C, 2) == Math.Pow(A, 2)
                    || Math.Pow(A, 2) + Math.Pow(C, 2) == Math.Pow(B, 2))
                {
                    return "pravoúhlý";
                }
                return "běžný";
            }
        }
    }

    class TestTriangle4
    {
        public static void Mainx(string[] args)
        {
            Triangle4 T1 = new Triangle4(3, 4, 5);
            Triangle4 T2 = new Triangle4(3, 3, 3);
            Triangle4 T3 = new Triangle4(3, 4, 4);
            Triangle4 T4 = new Triangle4(3, 4, 6);

            Console.WriteLine("Typ trojúhelníka T1: " + T1.GetType());
            Console.WriteLine("Typ trojúhelníka T2: " + T2.GetType());
            Console.WriteLine("Typ trojúhelníka T3: " + T3.GetType());
            Console.WriteLine("Typ trojúhelníka T4: " + T4.GetType());
        }
    }
}
