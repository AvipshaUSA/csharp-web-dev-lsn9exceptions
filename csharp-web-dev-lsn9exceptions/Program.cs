using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            // Write your code here!
            if (y == 0) // if y is 0 throw to catch
            {
                throw new ArgumentOutOfRangeException("Value is zero");
                
            }
            double z = x / y;
            return z;
        }

        static int CheckFileExtension(string fileName)
        {
            int point=0 ;
            // Write your code here!
            if (fileName.Contains(".cs"))
            {
                 point = 1;
            }else if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("no file included");
            }
            return point;
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int x = int.Parse(input);
            Console.Write("Enter 2nd number: ");
            int y = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine("\n Your result is "+Divide(x, y)); // if not devide by 0 will show the answer.
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Number can not devided by 0.");
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");
            foreach(var file in students)
            {
                try
                {
                   Console.WriteLine( " \n  " + file.Key + " got "+CheckFileExtension(file.Value) + " Point.");
                }
                catch(ArgumentNullException e)
                {
                    Console.WriteLine("\n No file include by " + file.Key + ". "+ file.Key + " got 0 point.");
                }
            }

        }
    }
}
