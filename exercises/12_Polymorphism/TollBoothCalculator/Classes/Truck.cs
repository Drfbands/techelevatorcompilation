using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    public class Truck : IVehicle
    {
        // truck class properties 
        public int NumberOfAxles { get; }
        public string Description { get; }

        // construtor 
        public Truck(int numberOfAxles, string description)
        {
            NumberOfAxles = numberOfAxles;
            Description = description;
        }

        // Method

        public decimal CalculateToll(int distance)
        {
            decimal toll = 0.0m;
            if (NumberOfAxles == 4)
            {
                toll = (decimal)0.040 * distance;
                return toll;

            }
            else if (NumberOfAxles == 6)
            {
                toll = (decimal)0.045 * distance;
                return toll;

            }
            else if (NumberOfAxles >= 8)
            {
                toll = (decimal)0.048 * distance;
                return toll;

            }
            else
            {
                return 0.00m;
            }
        }
    }
}
