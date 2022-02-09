using System;

namespace Homework3
{
    static class Program
    {
        static void Main(string[] args)
        {
            Candy[] candies = new Candy[3];
            candies[0] = new ChocoCandy("Chrismas taste", 0.023);
            candies[1] = new CandyByCompany("Petro's candle", 0.010, "Roshen");
            candies[2] = new CandyWithToy("Kinder surprise", 0.050, "Kinder");

            foreach (var entry in candies)
            {
                Console.Write($"{entry.Name}");
                if (entry is CandyByCompany)
                {
                    Console.WriteLine($"\t{((CandyByCompany)entry).CompanyName}");
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"Total weight: {candies.GetTotalWeight()}");
            string name = "Kinder surprise";
            Candy candy = candies.FindCandyByName(name);
            if (candy != null)
            {
                Console.WriteLine($"\nFound candy is - {candy.Name} {candy.Weight}");
            }
            else
            {
                Console.WriteLine($"Candy called {name} - not found!");
            }
            Array.Sort(candies);

            foreach (var entry in candies)
            {
                Console.Write($"{entry.Name} {entry.Weight}");
                if (entry is CandyByCompany)
                {
                    Console.WriteLine($"\t{((CandyByCompany)entry).CompanyName}");
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
