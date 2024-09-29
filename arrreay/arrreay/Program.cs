using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrreay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n ;
            Console.WriteLine("Enter the number of elements");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
                Console.WriteLine("Enter the number");
            for (int i = 0; i < n; i++)
            {
                arr[i]= int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]);
            }
            Console.ReadKey();

            Console.WriteLine("weeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");



            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            object a = 1;
            object s = "hello";
            Console.WriteLine(s.GetType());


            List<int> num = new List<int>();
            int input = int.Parse(Console.ReadLine());
            num.Add(input);



            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

           Console.ReadKey();

            list.Remove(2);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            list.RemoveAt(0);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();


































        }
    }
}
