using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hellowWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello CCN");// lekhay poxi line dinxa
            Console.Write("east or west ");// line xod dhoina
            Console.WriteLine("AAkku is the best");//  best poxi line xod xa
            Console.ReadLine();// hold console jaba samma enter ya line diyenna.
            Console.WriteLine("gayab");// instant gayab hunxa ek chotti show goraypoxi..

            Console.WriteLine(":its gonna hold"); 
            Console.Read();
            int cat = 5;
            string cats = "Neko";
            Console.WriteLine($@" we have {cat} 
    and its called {cats} in jap");
            Console.Read();
            Console.ReadLine();
            int[] a = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
            string [] name = { "Aakku", "CCN", "TOffu"};
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write($@" {name[i] } ");
            }
            Console.ReadLine();
            string firstName = "Bob";
            int widgetsSold = 7;
            Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
            Console.ReadLine();
            int quotient = 7 / 5;
            Console.WriteLine("Quotient: " + quotient);
            Console.ReadLine();
            decimal qtn = 7m / 5;
            Console.WriteLine("Quotient: " + qtn);
            Console.ReadLine();
            decimal decimalQuotient = 7 / 5;
            Console.WriteLine(decimalQuotient);
            Console.ReadLine();
            int fahrenheit = 94;
            Console.Write("Temperature is ");
            Console.WriteLine((5 / 9m) * (fahrenheit - 32) + " celsius.");
            Console.ReadLine();
        }
    }
}
