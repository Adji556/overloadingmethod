using System;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers number = new Numbers();
            Console.WriteLine("Minimum #1: {0}", number.findMinimum(3, 1));
            Console.WriteLine("Minimum #2: {0}", number.findMinimum(3, 2, 4));
            Console.WriteLine();
            Console.WriteLine("Maximum #1: {0}", number.findMaximum(3, 1));
            Console.WriteLine("Maximum #2: {0}", number.findMaximum(3, 2, 4));
        }
    }
}
