using System;

namespace acesmodifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            program2 program2 = new program2();
            program2.num=1;
            program2.numm = 2;
        }
    }
    public class program1
    {    
        public int num;
        private string name;
        internal int numm;
        protected string address="akkuNagar";
    }
    public class program2 : program1
    {
       
        public void print()
        {
            Console.WriteLine("helloo" + num + numm + name + address);
        }
    }
}

namespace AccessModifuer
{

}