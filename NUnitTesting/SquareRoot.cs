using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    internal class SquareRoot
    {
        internal static void Sqrt()
        {
            Console.WriteLine("enter a number to find its square root ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Square root of {c} is :");
            double t = c;
            double epsilon = 1.0e-15;
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }
            Console.WriteLine(t);
        }
    }
}
