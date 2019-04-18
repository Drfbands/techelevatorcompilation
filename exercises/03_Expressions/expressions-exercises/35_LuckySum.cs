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
         Given 3 int values, a b c, return their sum. However, if one of the values is 13 then it does not
         count towards the sum and values to its immediate right do not count. So for example, if b is 13, then both
         b and c do not count.
         LuckySum(1, 2, 3) → 6
         LuckySum(1, 2, 13) → 3
         LuckySum(1, 13, 3) → 1
         LuckySum(13, 1, 3) → 3
         LuckySum(13, 13, 3) → 0
         */
        public int LuckySum(int a, int b, int c)
        {
            // add a, b, and c to a list and then add 0 to the list; 
            // then make the loop so that if a[i] == 13 then a[i] = 0, and a[i+1] = 0
            // else add the number to the filtered list 
            // loop the filtered list, and then add up all the numbers 
            // 

            List<int> intitalNums = new List<int>();
            List<int> filterdNums = new List<int>();




            bool a13 = a == 13;
            bool b13 = b == 13;
            bool c13 = c == 13;
            bool ab13 = a13 && b13;
            bool ac13 = a13 && c13;
            bool bc13 = b13 && c13; 
            bool abc13 = a13 && b13 && c13;
            int sumABC = a + b + c; 


            if (abc13)
            {
                return 0;
            }

            else if (bc13)
            {
                return a;
            }
            else if (ac13)
            {
                return 0;
            }
            else if (ab13)
            {
                return 0;
            }
            else if (c13)
            {
                return a + b;
            }
            else if (b13)
            {
                return a;
            }
            else if (a13)
            {
                return c;
            }

            return  sumABC;
        }
     

    }
  

}

