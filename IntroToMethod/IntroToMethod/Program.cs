using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToMethod
{
    internal class Program
    {
        void print()
        {
            Console.WriteLine("hello CCN");   
        }
        static int sum(int a, int b)
        {
            return a + b;
        }
        static void cal (ref int j)
        
        {
            j = 106;
        }
        static void Main(string[] args)
        {
            Program print = new Program();
            //print.print();
            //Console.WriteLine(Program.sum(1, 2));
            int i = 0;
            cal(ref i);

            Console.Read();

        }
    }
}
