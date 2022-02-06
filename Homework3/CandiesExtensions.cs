using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    public static class CandiesExtensions
    {
        public static double GetTotalWeight(this Candy[] candy)
        {
            double weight = default;
            foreach(var entry in candy)
            {
                weight += entry.Weight;
            }
            return weight;
        }

        public static Candy FindCandyByName(this Candy[] candies, string name)
        {
            foreach (var entry in candies)
            {
                if (entry.Name.Equals(name))
                {
                    return entry;
                }
            }
            return null;
        }
    }
}
