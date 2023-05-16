using System;

namespace _04.InchestТoCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inc = double.Parse(Console.ReadLine());
            double cm = (inc * 2.54);
            Console.WriteLine(cm);
        }
    }
}
