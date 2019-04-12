using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] name1 = new string[10,2] {{ "蔣靜如", ""}, {"張全蛋", ""}, {"侯婉君", ""}, { "陳語彥", ""}, { "林玟君", ""}, { "邱佩樺", ""}, { "林韋星", ""}, { "吳世屏", ""}, { "李泓昌", ""}, { "林士映", ""}};
            string[,] name2 = new string[10,2] {{ "談詩欣", ""}, {"吳怡伶", ""}, {"阮采綺", ""}, { "蕭宗穎", ""}, { "許淑芳", ""}, { "賴則政", ""}, { "蔡家銘", ""}, { "黃心凱", ""}, { "張哲榮", ""}, { "蘇堯儒" ,""}};
            string[,] score = new string[10, 2];
            Console.WriteLine("please input the score for 1st class: \n");
            for (int i = 0; i < 2; i++)
            {
                if(i == 1)
                {
                    Console.WriteLine("\n please input the score for 2nd class: \n");
                }
                for(int j = 0; j < 10; j++)
                {
                    if (i == 0)
                    {
                        string a = null;
                        Console.Write(name1[j,0]+": ");
                        a = Console.ReadLine();
                        score[j, i] = a;
                    }
                    else
                    {
                        string a = null;
                        Console.Write(name2[j,0] + ": ");
                        a = Console.ReadLine();
                        score[j, i] = a;
                    }
                    
                }
            }

            Console.WriteLine("\n -----------華麗的分割綫-----------\n");

            Console.WriteLine("two class average: ");
            Console.WriteLine(Average(score));

            Console.WriteLine("\n -----------華麗的分割綫-----------\n");

            Console.WriteLine("two class score sort in descending: ");
            Sort(name1, name2, score);
            Console.Read();
        }
        public static string Average(string[,] score)
        {
            string[,] score1 = score;
            int a = 0;
            int b = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0)
                    {
                        
                        a += int.Parse(score1[j, 0]);
                    }
                    else
                    {
                        
                       b += int.Parse(score1[j, 1]);
                    }

                }
            }

            a = a / 10;
            b = b / 10;

            string c = "1st class: "+a+"    2nd class: "+b;
            return c;
        }

        public static void Sort(string[,] name1, string[,] name2, string[,] score)
        {
            string[,] name11 = name1;
            string[,] name22 = name2;
            string[,] score1 = score;
            string[] nameA = new string[10];
            string[] nameB = new string[10];
            int[] scoreA = new int[10];
            int[] scoreB = new int[10];


                for (int j = 0; j < 10; j++)
                {
                        nameA[j] = name11[j, 0];
                        nameB[j] = name22[j, 0];
                        scoreA[j] = int.Parse(score1[j, 0]);
                        scoreB[j] = int.Parse(score1[j, 1]);
                }

            Array.Sort(scoreA, nameA);
            Array.Reverse(scoreA);
            Array.Reverse(nameA);
            Array.Sort(scoreB, nameB);
            Array.Reverse(scoreB);
            Array.Reverse(nameB);


                Console.WriteLine("1st class sorted: \n");

            for (int i = 0; i < 2; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("\n2nd class sorted: \n");
                }
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0)
                    {
                        name11[j, 0] = nameA[j];
                        name11[j, 1] = scoreA[j].ToString();
                        Console.WriteLine(name11[j, 0]+": "+ name11[j, 1]);
                    }
                    else
                    {
                        name22[j, 0] = nameB[j];
                        name22[j, 1] = scoreB[j].ToString();
                        Console.WriteLine(name22[j, 0] + ": " + name22[j, 1]);
                    }
                }
            }
        }
    }
}
