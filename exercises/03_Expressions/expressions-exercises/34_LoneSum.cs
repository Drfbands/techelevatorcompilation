﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given 3 int values, a b c, return their sum. However, if one of the values is the same as another
         of the values, it does not count towards the sum.
         LoneSum(1, 2, 3) → 6
         LoneSum(3, 2, 3) → 2
         LoneSum(3, 3, 3) → 0
         */
        public int LoneSum(int a, int b, int c)
        {
            int sum = a + b + c;
            if (a == b && b == c)
            {
                return 0;
            }
            else if (b == c)
            {
                return a;
            }
            else if (c == a)
            {
                return b;
            }
            else if (a == b)
            {
                return c;
            }
            {
                return sum;
            }

        }
    }
}
