using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3__3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.Write("Please input x: ");
            a = int.Parse(Console.ReadLine());

            for (int b = 0; b <= a; b++){
                for(int c = 0; c<= b; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
