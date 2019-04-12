using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Please input two number to create Multiplication table.");

            Console.Write("Input First Number: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Input Second Number: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Output:");

            for(int d = 1; d <= a; d++)
            {
                for (int c = 1; c <= b; c++)
                {
                    Console.Write(c + " * " + d + " = " + (c * d)+ "\t");
                }
                Console.Write("\n");
            }
            

            Console.Read();
        }
    }
}
