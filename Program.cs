using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
          Console.Clear();
          Console.WriteLine("What do you want to do? ") ;
          Console.WriteLine("1 - Sum");
          Console.WriteLine("2 - Subtraction");
          Console.WriteLine("3 - Division");
          Console.WriteLine("4 - Multiplication");
          Console.WriteLine("5 - Exit");
          
          Console.WriteLine("-------------------");
          Console.Write("Chose an option: ");
          short res = short.Parse(Console.ReadLine());

          switch(res)
          {
            case 1: Soma(); break;
            case 2: Subtraction(); break;
            case 3: Division(); break;
            case 4: Multiplication(); break;
            case 5: System.Environment.Exit(0); break;
            default:
                Console.Clear();
                Console.WriteLine("Invalid input try again.");
                Console.ReadKey();
                Menu(); break;
          }
        }
        static void Soma()
        {
            Console.Clear();
            Console.Write("First Value: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Second Value: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultSum = v1 + v2;
            Console.WriteLine("The result of the sum is: " + resultSum);
            Console.ReadKey();
            Menu();
        }

        static void Subtraction()
        {
            Console.Clear();
            Console.Write("First Value: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.Write("Second Value: ");
            double v2 = double.Parse(Console.ReadLine());

            double resultSub = v1 - v2;
            Console.WriteLine("");
            Console.WriteLine("The result of subtraction is: (" + resultSub + ")");
            Console.ReadKey();
            Menu();
        }

        static void Division()
        {
            Console.Clear();
            Console.Write("First Value: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Second Value: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultDiv = v1 / v2;
            Console.Write("");
            Console.WriteLine("The result of division is: " + resultDiv);
            Console.ReadKey();
            Menu();
        }

        static void Multiplication()
        {
            Console.Clear();
            Console.Write("First Value: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Second Value: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultMulti = v1 * v2;
            Console.WriteLine("");
            Console.WriteLine("The result of multiplication is: " + resultMulti);
            Console.ReadKey();
            Menu();
        }
    }
}

