using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Delegates
    {
        public static int sum(int a, int b)
        {
            return a + b;
        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Rank { get; set; }

        public void StudentRank(List<Student> students)
        {
            foreach (Student student in students)
            {
                if (student.Rank >= 5)
                {
                    Console.WriteLine(student.Name + "Promoted");

                }
            }
        }
    }


}
