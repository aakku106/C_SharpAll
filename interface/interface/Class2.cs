using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{


    public class ClassA
    {
        public int Sum(int a = 9, int b = 8)
        {
            {
                return a + b;
            }
        }

    }
    public class ClassB : ClassA
    {
        public new int Sum(int a = 5, int b = 4)
        {
            {
                base.Sum(4, 5);
                return (a + b);
            }
        }
    }

}