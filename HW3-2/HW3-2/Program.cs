using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please continuous win N round.");
            Console.WriteLine("1: rock , 2: scissor , 3: paper");
            Console.WriteLine();

            int a = 0, b = 0;
            Boolean winner = true;
            int win = 0;

            int N = 0;
            Console.Write("Input win round: ");
            N = int.Parse(Console.ReadLine());

            while (winner)
            {
                

                Boolean number = true;
                while(number)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Your turn: ");
                    a = int.Parse(Console.ReadLine());

                    if(a > 0 && a <= 3)
                    {
                        number = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please input again.");
                        Console.WriteLine();

                    }
                }


                Random rnd = new Random();
                b = rnd.Next(1, 4);


                Console.ForegroundColor = ConsoleColor.Magenta;
                if(a == b)
                {
                    Console.WriteLine("You: "+a+" Computer: "+b+"  DRAW");
                }
                else if ((a == 1 && b == 2) || (a == 2 && b ==3 ) || (a == 3 && b == 1))
                {
                    Console.WriteLine("You: " + a + " Computer: " + b + "  WIN");
                    win++;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("win: " + win);
                }
                else
                {
                    Console.WriteLine("You: " + a + " Computer: " + b + "  LOSE");
                }
                
                if(win == N)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("YOU WIN. Application Close");
                    winner = false;
                }
            }
            Console.Read();
        }
    }
}