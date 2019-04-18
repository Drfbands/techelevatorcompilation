using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class PostalService3rdClass : IDeliveryDriver
    {

        

        public PostalService3rdClass(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public double CalculateRate(int distance, double weight, string inputType)
        {
            double total = 0;
            if (inputType == "o")
            {
                if (weight <= 2)
                {
                    total = distance * 0.0020;
                    return total;
                }
                else if (weight > 2 && weight <= 8)
                {
                    total = distance * 0.0022;
                    return total;
                }
                else if (weight > 8 && weight <= 15)
                {
                    total = distance * 0.0024;
                    return total;
                }
            }
            else
                      if (weight >= 1 && weight <= 3)
            {
                total = distance * 0.0150;
                return total;
            }
            else if (weight > 3 && weight <= 8)
            {
                total = distance * 0.0160;
                return total;
            }
            else
            {
                total = distance * 0.0170;
                return total;
            }
            return total; 

        }
    }
}
