using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name1 = new string[] { "蔣靜如", "張全蛋", "侯婉君", "陳語彥", "林玟君", "邱佩樺", "林韋星", "吳世屏", "李泓昌", "林士映" };
            int[] score1 = new int[10];
            string[] name2 = new string[] { "談詩欣","吳怡伶","阮采綺","蕭宗穎","許淑芳","賴則政","蔡家銘","黃心凱","張哲榮","蘇堯儒"};
            int[] score2 = new int[10];

            Console.WriteLine("please input the score for 1st class: ");
            for(int i = 0; i < name1.Length; i++)
            {
                int a = 0;
                Console.Write(name1[i] + " : ");
                a = int.Parse(Console.ReadLine());
                score1[i] = a;
            }

            Console.WriteLine("\n -----------華麗的分割綫-----------\n");

            Console.WriteLine("please input the score for 2nd class: ");
            for (int i = 0; i < name2.Length; i++)
            {
                int a = 0;
                Console.Write(name2[i] + " : ");
                a = int.Parse(Console.ReadLine());
                score2[i] = a;
            }

            Array.Sort(score1, name1);
            Array.Reverse(score1);
            Array.Reverse(name1);
            Array.Sort(score2, name2);
            Array.Reverse(score2);
            Array.Reverse(name2);

            Console.WriteLine("\n -----------華麗的分割綫-----------\n");
            Console.WriteLine("Sort: ");
            Console.WriteLine("1st class : "+"      "+ "2nd class : ");
            for (int i = 0; i < name2.Length; i++)
            {
                Console.WriteLine(name1[i] + " : " + score1[i]+"    "+ name2[i] + " : " + score2[i]);
            }
            Console.Read();
        }
    }
}
