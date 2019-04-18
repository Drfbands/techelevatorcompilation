using System;
using System.Collections.Generic;
using TollBoothCalculator.Classes;

namespace TollBoothCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> Automobiles = new List<IVehicle>();
            Random rnd = new Random();
            int totalDistance = 0;
            decimal tollTotal = 0;

            Automobiles.Add(new Car(false, "car !,  "));
            Automobiles.Add(new Car(true, "car True,"));
            Automobiles.Add(new Truck(4, "truck 4,"));
            Automobiles.Add(new Truck(6, "Truck 6,"));
            Automobiles.Add(new Truck(8, "Truck 8,"));
            Automobiles.Add(new Tank("Tank,   "));

            Console.WriteLine("Vehicle\t   Distance Traveled\t\tToll$");
            Console.WriteLine("===========================================================");

            foreach (IVehicle automobile in Automobiles)
            {
                int distance = rnd.Next(10, 240);

                Console.WriteLine($"{automobile.Description}            {distance}\t\t   {automobile.CalculateToll(distance)}");
                totalDistance += distance;
                tollTotal += automobile.CalculateToll(distance);
            }
            // need totals still
            Console.WriteLine($"\nTotal Miles Traveled: {totalDistance}\nTotal Tollbooth Revenue: {tollTotal}");

            Console.ReadLine();





        }
    }
}


   


