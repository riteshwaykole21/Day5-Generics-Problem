using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracticeProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            IntegerFindMax integerFindMax = new IntegerFindMax();
            integerFindMax.FindMaxValue(10,20,30);
            Console.ReadLine();
        }
    }
}
