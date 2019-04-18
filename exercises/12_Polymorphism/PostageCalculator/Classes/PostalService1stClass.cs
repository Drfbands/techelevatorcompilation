using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class PostalService1stClass : IDeliveryDriver
    {
        public string InputType { get; set; }

        public string Name { get; }

        public PostalService1stClass(string name)
        { 

            Name = name;
        }



    public double CalculateRate(int distance, double weight, string inputType)
        {
            
            double total = 0;

            if (inputType == "o")
            {
                if (weight <= 2)
                {
                    total = distance * 0.035;
                    return total;
                }
                else if (weight > 2  && weight <= 8)
                {
                    total = distance * 0.040;
                    return total;
                }
                else if (weight > 8 && weight <= 15)
                {
                    total = distance * 0.047;
                    return total;
                }
            }
            else
            if (weight >= 1 && weight <= 3)
            {
                total = distance * 0.195;
                return total;
            }
            else if (weight > 3 && weight <= 8)
            {
                total = distance * 0.450;
                return total;
            }else
                total = distance * 0.500;
            return total;

        } 
    }
}
