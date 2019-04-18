// This program converts Meters to Feet
using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {

            // prompt user for feet or meters
            Console.WriteLine("If you want to convert Feet to meters enter F. If you want to convert meters to feet enter M: ");
            string metersOrFeet = Console.ReadLine();
            if (metersOrFeet == "M" || metersOrFeet == "m")
            {
                // Prompt the user to enter meters
                Console.WriteLine("Tell me your meters: ");


                // Read in meters from user and parse the input to an int. 
                string metersAccepted = Console.ReadLine();
                double meters = double.Parse(metersAccepted);

                // Output the value in a formatted string: 
                Console.WriteLine($"your number in feet is {meters * 3.2808399}");
               
            }
            else if (metersOrFeet == "F" || metersOrFeet == "f")
            {
                // Prompt the user to enter meters
                Console.WriteLine("Tell me your feet: ");


                // Read in meters from user and parse the input to an int. 
                string feetAccepted = Console.ReadLine();
                double feet = double.Parse(feetAccepted);

                // Output the value in a formatted string: 
                Console.WriteLine($"your number in feet is {feet * 0.3048}");

            } 
            else
            {
                 Console.WriteLine("I don't understand your input");
            }

          

            Console.ReadKey();
        }
    }
}
