using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class FedEd : IDeliveryDriver
    {
        
        

        public FedEd(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public double CalculateRate(int distance, double weight, string inputType)
        {
            double rate = 20.00;
            

            if(distance > 500)
            {
              rate += 5.00;
            }
           if ((inputType == "o" && weight > 48) || (inputType == "p" && weight > 3))
            {
                rate += 3.00;
            }
          
           
                return rate; 
            
        }

    }
}
