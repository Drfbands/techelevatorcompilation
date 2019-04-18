using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    interface IDeliveryDriver
    {
        string Name { get; }

        double CalculateRate(int distance, double weight, string inputType);
        
    }
}
