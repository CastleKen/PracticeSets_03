using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS03_02
{
    class Program
    {
        static void LeapYear(int Year)
        {
            if (Year % 4 == 0 && Year % 100 != 0 || Year % 400 == 0)
            {
                Console.WriteLine($"The year {Year} is a leap year.");               
            }

            else
            {
                Console.WriteLine($"The year {Year} is not a leap year.");               
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the year: ");
            int Year = Convert.ToInt32(Console.ReadLine());

            LeapYear(Year);            
        }
    }
}