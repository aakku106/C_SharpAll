using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicExample
{
    internal class Program
    {
        static void calcu(int a, int b, out int c)
        {
            c = a + b;
            Console.WriteLine($"the sum is : {c}");

            Console.Read();
        }
        static void isEven (int a)
        {
            a = a % 2;
            if(a==0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
        static void swap (int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swap" + (a) + ", " + (b) + " ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the two numbers");
            int a= Convert.ToInt32(  Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("lowest is " + Math.Min(a, b));
            Console.WriteLine(Math.Max(a, b)+" is greatest");
            if (a < b) { 
                Console.WriteLine("second number is greatest");
            }
            else {
                Console.WriteLine("1st was greatest");
            }
            Console.Read();
            int c;
            calcu(a, b, out c);

            Console.ReadLine();

            isEven(a);

            Console.ReadLine();

            Console.WriteLine("Before swap" + (a) + (b));
            swap(a, b);

            Console.ReadLine();

        }
    }
}
