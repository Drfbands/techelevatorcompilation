using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class PostalService2ndClass : IDeliveryDriver
    {


        public PostalService2ndClass(string name)
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
                    total = distance * 0.0035;
                    return total;
                }
                else if (weight > 2 && weight <= 8)
                {
                    total = distance * 0.0040;
                    return total;
                }
                else if (weight > 8 && weight <= 15)
                {
                    total = distance * 0.0047;
                    return total;
                }
            }
            else
                     if (weight >= 1 && weight <= 3)
            {
                total =  distance * 0.0195 ;
                return total;
            }
            else if (weight > 3 && weight <= 8)
            {
                total = distance * 0.0450;
                return total;
            }
            else
            {
                total = distance * 0.0500;
                return total;


            

            }
            return total;
        }
    }
}

