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
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            for (int i = 0; i < str.Length -1; i++)
            {
                if (str[i + 1].Equals("x"))
                {
                    str = str.Replace("x", ",");
                }
             
            }
            return str;
        }
    }
}
