using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    interface IVehicle

      

    {
        string Description { get; }

        decimal CalculateToll(int distance);

    }
}
