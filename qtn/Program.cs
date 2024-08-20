using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qtn
{
    internal class Program
    {
        static int FindMax(int[] a)
        {
            if (a == null || a.Length == 0)
            {
                throw new ArgumentException("Array is null or empty", nameof(a));
            }

            int max = a[0];
            for (int i = 1; i < a.Length; i++) 
            {
                if (a[i] > max)
                {
                    max = a[i]; 
                }
            }
            return max; 
        }

        static void Main(string[] args)
        {
            int[] arr = new int[5] { 3, 5, 7, 2, 8 };
            int max = FindMax(arr); 
            Console.WriteLine($"Maximum value: {max}");
            Console.ReadLine();
        }
    }
}
