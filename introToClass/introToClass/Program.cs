using System;

namespace introToClass
{
     class Program
    {
        static void Main(string[] args)
        {
            Biki bike = new Biki ();
            Biki bike1 = new Biki();
            Biki bike01 = new Biki ("ccn",123,"red","aa");
            bike.PrintInfo();
            bike01.PrintInfo();
            bike1.getdata();
            bike1.PrintInfo();
            Console.ReadKey();
        }
    }   



}
