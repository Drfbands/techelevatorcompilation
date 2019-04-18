using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int var = 0;
            int var2 = 1;
            int var3 = 1;

            Console.WriteLine("Enter a number: ");
          string userInput =  Console.ReadLine();
            int num = int.Parse(userInput);

            if (num == 0)
            {
                Console.WriteLine("0");
            }
            else if (num == 1)
            {
                Console.WriteLine("1");
            }
            else
                Console.WriteLine("0");
               
            do
            {
                Console.WriteLine(var3);
                var3 = var + var2;
                var = var2;
                var2 = var3;
               
            }

            while (var3 < num);
     



          
            Console.ReadKey();

        }
      
    }
}
