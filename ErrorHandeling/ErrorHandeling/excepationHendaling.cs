using System;
using System.IO;


namespace ErrorHandeling
{
     class excepationHendaling
    {
        public void divide()
        {
            try
            {
                int[] num = new int[3] {1, 2, 3};
                Console.WriteLine("Enter 1st Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
          
                double div = num1 / num2;
                Console.WriteLine("The result in {0}", div);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Given Number shall be in teger type {0}", ex.Message);
            }
            catch (DivideByZeroException err)
            {
                Console.WriteLine("Please enter valid {0}", err);
            }

            catch (Exception ex)
            {
                string pathNae = "C:\\Users\\seva\\OneDrive\\Desktop\\Adarasha\\cSharpWriting\\one.txt.txt";
                StreamWriter sw = new StreamWriter(pathNae);
                if (File.Exists(pathNae))
                {
                    sw.Write("Hello Worldiii");
                    sw.Close();
                }
                else
                {
                    throw new FileNotFoundException("File not found {0} ", ex.Message, ex);
                    //Console.WriteLine("File not found");
                }
                Console.WriteLine("The error is {0}", ex.Message);
                Console.WriteLine("More details error is {0}", ex.StackTrace);
            }
            Console.ReadKey();
        }

    }
}
