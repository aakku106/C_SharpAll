using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 5");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("You entered 1");
                    break;
                case 2:
                    Console.WriteLine("You entered 2");
                    break;
                case 3:
                    Console.WriteLine("You entered 3");
                    break;
                case 4:
                    Console.WriteLine("You entered 4");
                    break;
                case 5:
                    Console.WriteLine("You entered 5");
                    break;
                default:
                    Console.WriteLine("You entered a number that is not between 1 and 5");
                    break;
            }
            Console.ReadLine();
        }
    }
}
