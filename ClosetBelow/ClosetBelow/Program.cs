using System;
using System.Collections.Generic;
using System.Linq;

namespace ClosetBelow
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<Double> { 1.02, 0.9, 1.04, 0.8 };
            var pivot = 1;
            var closestBelow = Convert.ToDouble(pivot) - numbers.Where(n => n <= pivot).Min(n => pivot - n);

            Console.WriteLine("Hello World!");
        }
    }
}
