using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
         DoubleX("axxbb") → true
         DoubleX("axaxax") → false
         DoubleX("xxxxx") → true
         */
        public bool DoubleX(string str)
        {
            int test = str.IndexOf("x");
            if (test < str.Length - 1)
            {
                string test2 = str.Substring(test + 1, 1);
                if (test2 == "x")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
                
            }
           
        }
    }