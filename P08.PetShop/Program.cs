using System;

namespace P08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            double dogFoodPrize = dogFood * 2.50;
            int catFood = int.Parse(Console.ReadLine());
            int catFoodPirze = catFood * 4;
            double totalSum = catFoodPirze + dogFoodPrize;
            Console.WriteLine($"{totalSum} lv.");
        }
    }
}
