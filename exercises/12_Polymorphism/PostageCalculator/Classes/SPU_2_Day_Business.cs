using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class SPU_2_Day_Business : IDeliveryDriver
    {
       

        public SPU_2_Day_Business(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public double CalculateRate(int distance, double weight, string inputType)
        {
            double rate = (weight * 0.050) * distance;
            if (inputType == "o")
            {
                return rate / 16;
            }
            else
                return rate;
        }
    }
}
