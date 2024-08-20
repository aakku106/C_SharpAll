using System;


namespace introToClass
{
    internal class Biki
    {
        private string name;
        private int model;
        private string color;
        private string breed;
        public void PrintInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Breed: " + breed);
        }
        public void getdata()
        {
            Console.WriteLine("name of bike:");
            name = Console.ReadLine();
            Console.WriteLine("model of bike:");
            model = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("color of bike:");
            color = Console.ReadLine();
            Console.WriteLine("breed of bike:");
            breed = Console.ReadLine();
        }

        public Biki()
        {

            name = "Baki";
            model = 106;
            color = "BlackPink";
            breed = "Londa";
        }
        public Biki(string nam, int model, string col, string bre)
        {
            name = nam;
            this.model = model;
            color = col;
            breed = bre;
        }
    }
}
