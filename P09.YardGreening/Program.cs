using System;

namespace P09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double green = double.Parse(Console.ReadLine());
            double priceMeter = 7.61;
            double finalPrice = green * priceMeter;
            double disscount = finalPrice * 0.18;
            Console.WriteLine($"The final price is: {finalPrice - disscount} lv.");
            Console.WriteLine($"The discount is: {disscount} lv.");

        }
    }
}
