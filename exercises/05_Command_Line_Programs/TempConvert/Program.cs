using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)

        {
            // Promt the user
            Console.WriteLine("Enter the temperture today: ");

            // Get Temperature From the User
            string getTemperature = Console.ReadLine();

            int enteredTemperature = int.Parse(getTemperature);

            Console.WriteLine($"The temperature in celsius is {(enteredTemperature - 32) / 1.8} ");

            Console.ReadKey();





    }
    }
}
