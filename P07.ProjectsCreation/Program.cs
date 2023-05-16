using System;

namespace P07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string name = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int timeToFinish = count * 3;
            Console.WriteLine($"The architect {name} will need {timeToFinish} hours to complete {count} project/s.");
        }
    }
}