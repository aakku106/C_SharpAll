using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter ur name \t");
            string name = Console.ReadLine();
            Console.WriteLine("ur name is " + name + " and you may be 20 years old.");
            Console.ReadLine();
            Console.WriteLine("Enter the name of ur friends");
            string[] fr = new string[3];
            for (int i = 0; i < fr.Length; i++) 
            {

                fr[i] = Console.ReadLine();
            }
            for (int i = 0; i < fr.Length; i++)
            {
                Console.Write(fr[i]);
            }
            Console.ReadLine();
        }
    }
}
