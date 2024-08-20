using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            string name;
            string name2;
            Console.WriteLine("Enter ur name and age");

            name = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            name2 = Console.ReadLine();
            Console.WriteLine($@" Your name is {name} and age is {age}");
            Console.ReadLine();
        }
    }
}
