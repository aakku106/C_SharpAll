using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter the fist and 2ns number");
            a = Convert.ToInt32( Console.ReadLine());
            b =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine($@"Addition of number is { a + b}
Subtraction is {a-b} 
Division is {(float)a/b}
MUltiplication is {a*b}");
            Console.ReadLine();
            Console.WriteLine("Enter the num ");
            int[] v= new int[];int c;
            for (int i = 0; i < v.Length; i++)
            {
               c =  Convert.ToInt32(Console.ReadLine(v[i]));
            }
        }
    }
}
