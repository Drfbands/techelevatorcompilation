using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// Represents a "simple" calculator
    /// </summary>
    public class Calculator
    {
        public int Result { get; private set; }


        public Calculator(int startingResult)
        {
            Result = startingResult;
        }
        public int Add(int addend)
        {
            Result = Result + addend;
            return Result;
        }
        public int Subtract(int subtrahend)
        {
            Result = Result - subtrahend;
            return Result;
        }

        public int Multiply(int multiplier)
        {
            Result = Result * multiplier;
            return Result;
        }
    

        public int Power(int exponent)
        {

            if (exponent < 0)
            {
                exponent = (exponent) * (-1);
            }
                Result = (int)Math.Pow(Result, exponent);
                return Result;
                 

        }
        

        public void Reset()
        {
            Result = 0;
                        
        }


    }
}
