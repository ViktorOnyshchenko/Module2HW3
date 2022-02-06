using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    public abstract class Candy: IComparable<Candy>
    {
        public string Name { get; protected set; }
        public double Weight { get; protected set; }

        public int CompareTo(Candy candy)
        {
            if(Weight >= candy.Weight)
            {
                if (Weight == candy.Weight)
                {
                    return 0;
                }
                return 1;
            }
            return -1;
        }
    }
}
