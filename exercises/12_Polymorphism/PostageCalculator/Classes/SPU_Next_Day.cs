using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class SPU_Next_Day : IDeliveryDriver
    {
      

        public SPU_Next_Day(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public double CalculateRate(int distance, double weight, string inputType)
        {
            double rate = (weight * 0.075) * distance;
            if (inputType == "o")

                return rate / 16;
            else
            {
                return rate;
            }

            
        }
    }
}
