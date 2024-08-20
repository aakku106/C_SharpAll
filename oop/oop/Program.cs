using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public delegate int AdditionDelegates(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {


            AdditionDelegates additionDelegates = new AdditionDelegates(Delegates.sum);
            int s = additionDelegates(5, 4);
            Console.WriteLine(s);

            List<Student> studentList = new List<Student>();
            studentList.Add(new Student() { ID = 1, Name = "Dhirajan", Age = 20, Rank = 5 });
            studentList.Add(new Student() { ID = 1, Name = "Rijan", Age = 20, Rank = 1 });
            studentList.Add(new Student() { ID = 1, Name = "Sabinaya", Age = 20, Rank = 2 });
            studentList.Add(new Student() { ID = 1, Name = "Aryan", Age = 20, Rank = 3 });
            studentList.Add(new Student() { ID = 1, Name = "Nishant", Age = 20, Rank = 4 });

            Student student = new Student();
            Student.StudentRank(studentList);

            Console.ReadLine();
        }
    }


}
