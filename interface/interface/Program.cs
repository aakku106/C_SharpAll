using System;

namespace @interface
{
   
    interface Ifather
    {
        void Printfather();

    }
    interface Imother
    {
        void Printmother();
    }

    public class father : Ifather
    {
        public void Printfather()
        {
            Console.WriteLine("this is father class");
        }

    }
    public class mother : Imother
    {
        public void Printmother()
        {
            Console.WriteLine("This is mother class");

        }


    }
    public class Child : Ifather, Imother
    {
        father Father = new father();
        mother Mother = new mother();
        public void Printfather() { }
        public void Printmother() { }
    }
}