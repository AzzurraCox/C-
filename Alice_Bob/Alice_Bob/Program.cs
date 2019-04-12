using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice_Bob

{
    class Program
    {
        struct people{
            public string name;
            public double salary;
        }

        static void Main(string[] args)
        {
            const int price = 200;

            Random rnd = new Random();

            people people1;
            people people2;

            people1.name = "Alice";
            people1.salary = rnd.Next(23000, 50000);

            people2.name = "Bob";
            people2.salary = rnd.Next(23000, 50000);

            Console.WriteLine(people1.name + "   Salary: " + people1.salary);
            Console.Write("quantity of clothes: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Promotion Discount: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine(people2.name + "   Salary: " + people2.salary);
            Console.Write("quantity of clothes: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Promotion Discount: ");
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("The rate of buying clothes with salary");
            double total1 = ((a * price)*((100-b)/100));
            double rate1 = (total1 / people1.salary);
            Console.WriteLine("Alice Total: "+ total1 + "  rate: " + rate1);
            double total2 = ((c * price) * ((100-d) / 100));
            double rate2 = (total2 / people2.salary);
            Console.WriteLine("Bob Total  : "+ total2 + "  rate: " + rate2);

            Console.WriteLine();

            if(rate2 == rate1)
            {
                Console.WriteLine("The rate is same");
            }
            else if(rate2 > rate1)
            {
                Console.WriteLine("Bob higher than Alice. True.");
            }
            else
            {
                Console.WriteLine("Alice higher than Bob. false");
            }

            Console.Read();
        }
    }
}
