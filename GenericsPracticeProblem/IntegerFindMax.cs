﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracticeProblem
{
    public class IntegerFindMax
    {
        public void FindMaxValue(int First, int Second, int Third)
        {
            if(First.CompareTo(Second) >= 0 && First.CompareTo(Third) >= 0)
            {
                Console.WriteLine($"{First} is Greater");
            }
            else if (Second.CompareTo(Third) >= 0 && Second.CompareTo(First) >= 0)
            {
                Console.WriteLine($"{Second} is Greater");
            }
            else if(Third.CompareTo(First) >= 0 && Third.CompareTo(Second) >= 0)
            {
                Console.WriteLine($"{Third} is Greater");
            }
        }
    }
}
