using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    public class ChocoCandy : Candy, ITaste
    {
        public ChocoCandy(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public virtual string GetTaste()
        {
            return "Candy with choco taste!";
        }
    }
}
