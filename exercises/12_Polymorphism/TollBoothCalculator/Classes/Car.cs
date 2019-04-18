using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    public class Car : IVehicle
    {

        // Car Properties 
        public bool HasTrailer { get; }
        public string Description { get; }

        // Car Constructor 
        public Car(bool hasTrailer, string description)
        {
            HasTrailer = hasTrailer;
            Description = description;
        }

        public decimal CalculateToll(int distance)
        {
            decimal toll = distance * (decimal)0.020;
            decimal trailertoll = toll + 1.00m;
            if (!HasTrailer)
            {

                return toll;
            }
            else
            {
                return trailertoll;
            }

        }
    }
}
