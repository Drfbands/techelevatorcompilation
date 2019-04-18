using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given three ints, a b c, return true if it is possible to add two of the ints to get the third.
         TwoAsOne(1, 2, 3) → true
         TwoAsOne(3, 1, 2) → true
         TwoAsOne(3, 2, 2) → false
         */
        public bool TwoAsOne(int a, int b, int c)

        {
            int sumAB = a + b;
            int sumAC = a + c;
            int sumBC = b + c;


            if (sumAB == c || sumAC == b || sumBC == a)
            {
                return true;
            }
         
            {

                return false;
            }

        }
    }
}