using System;
namespace inheritance
{
    //inheritance
    //encapsulation
    //abstraction

    class program
    {
        static void Main(string[] args)
        {


            // bikeclass bikeclass = new bikeclass("shine","2020"); //bileclass
            //Bike bike = new Bike("shine", "2020");
            // bikeclass.PrintInfo();

            //Bike Bike = new Bike("shine","2020");   //Bike
            //Bike bike1 = new Bike();
            //bike1.PrintInfo();

            //child c= new child();
            //c.Property = "i need father property";  //inheritance(genr)
            //Console.WriteLine(c.Property);

            //Fulltimeemployee e=new Fulltimeemployee();
            //e.Name = "Sauravi";
            //e.salary = 90000;
            //e.age = 18;
            //e.Id = 25;
            //e.PaidLeave();
            //e.Benefits();
            //Console.WriteLine($"Name is {e.Name},salary is{e.salary},age is{e.age},id is {e.Id}" );

            //Parttimeemployee p=new Parttimeemployee();
            //p.Name = "aastha";
            //p.salary = 20000;
            //p.age = 20;
            //p.Id = 26;
            //p.PaidLeave();
            //p.Benefits();
            //Console.WriteLine($"Name is {p.Name},salary is{p.salary},age is{p.age},id is {p.Id}");
            father g = new father();
            g.name = "baba";

            g.age = 55;
            g.property = 200000;

            Console.WriteLine($"Name is {g.fname},age is{g.age},property is {g.property}");

            Child c = new Child();
            c.cname = "aastha";
            c.age = 18;
            c.Fproperty = 2000000;


            Console.WriteLine($"Name is {c.cname},salary is{c.Fproperty},age is{c.age}");
            Console.ReadLine();
        }



        internal class grandfather
        {
            public string name;
            public int age;
            public int property;


        }

        class father : grandfather
        {
            public string fname;
            public int Fproperty;
        }
        class Child : father
        {
            public string cname;
        }



        public class inheritance
        {
            child c = new child();

        }
        public class Father
        {
            public string Name;
            public string Property;
            public int age;


        }
        public class child : Father
        {
            public string childName;

            public int childage;

        }


    }


    internal class employeee
    {
        public int Id;
        public string Name;
        public int age;
        public int salary;
        public string position;


        public void PaidLeave()
        {
            Console.WriteLine("Employee will get full leave");
        }



    }
    class Fulltimeemployee : employeee
    {

        public int fullsalary;
        public void Benefits()
        {
            Console.WriteLine("100% benefits for company");
        }

    }
    class Parttimeemployee : employeee
    {

        public int partsalary;
        public void Benefits()
        {
            Console.WriteLine("50% benefits for company");
        }


        internal class bikeclass
        {

            public string Name;
            public string _model;
            //public   void Bike()
            //{
            //    Console.WriteLine("this is bike");
            //}
            public bikeclass(string Name, string model)
            {
                this.Name = Name;
                _model = model;
            }
            public void PrintInfo()//methods
            {
                Console.WriteLine($"bike name is {Name} and model is {_model}");
            }
            internal class Bike
            {

                public string Name;
                public string _model;

                //static constructor
                public Bike()
                {
                    Console.WriteLine("this is instance constructor");
                }
                static Bike()
                {
                    Console.WriteLine("this is static constructor");
                }
                public Bike(string Name, string model)
                {
                    this.Name = Name;
                    _model = model;
                }
                public void PrintInfo()//methods
                {
                    Console.WriteLine($"bike name is {Name} and model is {_model}");
                }





            }
        }


    }



    class Bike
    {
        public string Name;
        public string _model;
        public Bike()
        {
            Console.WriteLine("this is bike");
        }


        public Bike(string Name, string model)
        {
            this.Name = Name;
            _model = model;
        }
        public void PrintInfo()//methods
        {
            Console.WriteLine($"bike name is {Name} and model is {_model}");
        }

    }
}