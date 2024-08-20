using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5d5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many many number in array we have");
            int n = Convert.ToInt32(Console.ReadLine());
            // aaj ho ga array Dattebyoo!!! !!!
            string[] name = new string[n];
            for(int i =0; i<n;i++)
            {

                name[i] = Console.ReadLine();
            }
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}
            foreach (string i in name)
            {
                Console.WriteLine(i);
            }
            //Console.WriteLine(name);
                        Console.ReadLine();

        }
    }
}
