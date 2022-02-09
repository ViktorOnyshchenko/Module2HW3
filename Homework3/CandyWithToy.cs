using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    public class CandyWithToy : CandyByCompany
    {
        public string Toy { get; protected set; }

        public CandyWithToy(string name, double weight, string companyName) : base(name, weight, companyName)
        {
            RandomizeToy();
        }

        public void RandomizeToy()
        {
            int toy;
            Random random = new Random();
            toy = random.Next(1, 5);
            switch (toy)
            {
                case 1:
                    {
                        Toy = "plastic car";
                        break;
                    }
                case 2:
                case 3:
                    {
                        Toy = "wood cat";
                        break;
                    }
                default:
                    {
                        Toy = "toy wasn't exist";
                        break;
                    }
            }
        }
    }
}
