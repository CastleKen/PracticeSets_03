using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS03_01
{
    class Program
    {
        static double TriangleArea(double a, double b, double c, double s, double t)
        {
            t = s * (s - a) * (s - b) * (s - c); 
            t = Math.Sqrt(t);
            return t;
        }

        static void Main(string[] args)
        {
            Console.Write("1st side: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("2nd side: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("3rd side: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double s = (a + b + c) / 2;

            double t = 0;

            double Area = TriangleArea(a, b, c, s, t);

            Console.WriteLine($"The area of the triangle is {Area}");
        }
    }
}