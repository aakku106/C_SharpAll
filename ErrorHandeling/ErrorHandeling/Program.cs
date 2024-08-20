using System;
using System.IO;


namespace ErrorHandeling
{
     class Program
    {
        static void Main(string[] args)
        {
            excepationHendaling ex = new excepationHendaling();
            ex.divide();
            string pathNae = "C:\\Users\\seva\\OneDrive\\Desktop\\Adarasha\\cSharpWriting\\one.txt";
            StreamWriter sw = new StreamWriter(pathNae);
           
            if(File.Exists(pathNae))
            {
                sw.Write("Hello Worldiii");
                sw.Close();
            }
            else
            {
                throw new FileNotFoundException("File not found {0} ");
                Console.WriteLine("File not found");
            }
            Console.ReadKey();

        }
       

    }
}
