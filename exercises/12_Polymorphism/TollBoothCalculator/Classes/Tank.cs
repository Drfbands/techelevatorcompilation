using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    public class Tank : IVehicle
    {
        // Class Property
        public string Description { get; }

        //Constructor 
        public Tank(string description)
        {
            Description = description;
        }
        // Method
        public decimal CalculateToll(int distance)
        {

            decimal toll = 0.00m;
            return toll;

        }
    }
}
