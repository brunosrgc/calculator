using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiplication();
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
        }

        static void Subtraction()
        {
            Console.Clear();
            Console.Write("First Value: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Second Value: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultSub = v1 - v2;
            Console.WriteLine("");
            Console.WriteLine("The result of subtraction is: " + resultSub);
            Console.ReadKey();
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
        }
    }
}

