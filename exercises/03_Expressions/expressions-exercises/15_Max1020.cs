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
      Given 2 positive int values, return the larger value that is in the range 10..20 inclusive,
      or return 0 if neither is in that range.
      Max1020(11, 19) → 19
      Max1020(19, 11) → 19
      Max1020(11, 9) → 11
      */
        // added comment


        public int Max1020(int a, int b)
        

            {
            bool rangeA10To20 = a >= 10 && a <= 20;
            bool  rangeB10To20 = b >=10  && b <= 20;

            if(!rangeA10To20 && !rangeB10To20)
            {
                return 0;
            }
           else if(rangeA10To20 && !rangeB10To20)
            {
                return a;
            }
          else  if (!rangeA10To20 && rangeB10To20)
            {
                return b;
            }

            else if (rangeA10To20 && rangeB10To20)
            {
                if (a > b){
                    return a;
                }
                else
                {
                    return b;
                }
                
            }

            return 0;
            }

        
    }
}
