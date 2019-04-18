using System;
using System.IO;

namespace FizzWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = Environment.CurrentDirectory; // TODO need to change this down 2 files
            string outputFile = "FizzBuzz.txt";
            string outputFullPath = Path.Combine(directory, outputFile); 

            using (StreamWriter sw = new StreamWriter(outputFullPath, true))
            {
                for (int i = 1; i < 301; i++)
                {
                    string foo = FizzBuzzMachine(i);
                    sw.WriteLine(foo);

                }
            }
         
        }

        
        public static string FizzBuzzMachine(int num)
        {
            string convertedNum = num.ToString();
            if (num % 3 == 0 && num % 5 == 0 || (convertedNum.Contains("3") && convertedNum.Contains("5")))
            {
                convertedNum = "FizzBuzz";
            }
            else if (num % 3 == 0 || convertedNum.Contains("3"))
            {
                convertedNum = "Fizz";
            }
            else if (num % 5 == 0 || convertedNum.Contains("5"))
            {
                convertedNum = "Buzz";
            }

            return convertedNum;
        }
    }
}
