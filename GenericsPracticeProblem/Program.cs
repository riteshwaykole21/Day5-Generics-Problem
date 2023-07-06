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
            Console.WriteLine("Welcome To Genrics Use CXases");
            Console.WriteLine("1 : Find Max Interger Float And String");
            Console.WriteLine("2 : Find Maximum Using Generics Method");
            Console.WriteLine("Enter A Optiom");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    IntegerFindMax integerFindMax = new IntegerFindMax();
                    integerFindMax.FindMaxValue(10, 20, 30);
                    integerFindMax.FindMaxValue(10.20f, 20.30f, 50.60f);
                    integerFindMax.FindMaxValue("Ritesh", "Rushikesh", "Ronit");
                    break;
                case 2:
                    Refactor1 refactor1 = new Refactor1();
                    refactor1.FindMaxValue<int>(10, 20, 30);
                    refactor1.FindMaxValue<float>(10.20f, 20.30f, 50.60f);
                    refactor1.FindMaxValue<string>("Ritesh", "Rushikesh", "Ronit");
                    break;
            }
            Console.ReadLine();
        }
    }
}
