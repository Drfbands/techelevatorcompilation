using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class SPU_4_Day_Ground : IDeliveryDriver
    {
        

        public SPU_4_Day_Ground(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public double CalculateRate(int distance, double weight, string inputType)
        {
            double rate = ((weight * 0.0050) * distance);
            if (inputType == "o")
            
            return rate / 16; 
            else
            {
                return rate;
            }

            
          
        }
    }
}
