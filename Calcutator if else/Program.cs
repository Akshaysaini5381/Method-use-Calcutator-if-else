using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcutator_if_else
{
    class Program
    {
        static void print(int num, int num1, string choice)
        {
            if (choice == "+")
                Console.WriteLine(num + num1);
            else if (choice == "-")
                Console.WriteLine(num - num1);
            else if (choice == "*")
                Console.WriteLine(num * num1);
            else if (choice == "/")
                Console.WriteLine(num / num1);
            else
                Console.WriteLine("Not found result");
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the number:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter the number:");
            string c = (Console.ReadLine());
            print(a, b, c);
            Console.ReadLine();
        }
    }
}
