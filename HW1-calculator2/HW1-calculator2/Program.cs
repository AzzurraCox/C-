using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input 2 number and an operator. 405530027");

            while (true)
            {
                Console.Write("1st Number: ");
                var a = int.Parse(Console.ReadLine());

                Console.Write("2nd Number: ");
                var b = int.Parse(Console.ReadLine());

                Console.Write("Operator : ");
                var c = Console.ReadLine();


                if (c == "+")
                {
                    Console.WriteLine("Answer: " + Add(a, b));
                }
                else if (c == "-")
                {
                    Console.WriteLine("Answer: " + Sub(a, b));
                }
                else if (c == "*")
                {
                    Console.WriteLine("Answer: " + Multi(a, b));
                }
                else if (c == "/")
                {
                    try
                    {
                        Console.WriteLine("Answer: " + Div(a, b));
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Answer: Attempted divide by zero.");
                    }

                }
                Console.WriteLine();
            }

        }

        public static float Add(float a, float b)
        {
            float ans = a + b;
            return ans;
        }
        public static float Sub(float a, float b)
        {
            float ans = a - b;
            return ans;
        }
        public static float Multi(float a, float b)
        {
            float ans = a * b;
            return ans;
        }
        public static float Div(float a, float b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            float ans = a / b;
            return ans;
        }
    }
}
