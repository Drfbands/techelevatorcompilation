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
         * Given an array of non-empty strings, return a Dictionary<string, string> where for every different string in the array,
         * there is a key of its first character with the value of its last character.
         *
         * BeginningAndEnding(["code", "bug"]) → {"b": "g", "c": "e"}
         * BeginningAndEnding(["man", "moon", "main"]) → {"m": "n"}
         * BeginningAndEnding(["muddy", "good", "moat", "good", "night"]) → {"g": "d", "m": "t", "n": "t"}
         */
        public Dictionary<string, string> BeginningAndEnding(string[] words)
        {
           HashSet<string> SavedHashs =  words.ToHashSet();
            Dictionary<string, string> firstAndLast = new Dictionary<string, string>();

            foreach (string word in SavedHashs)
            {
                if (firstAndLast.ContainsKey(words[0]))
                {
                    firstAndLast.Add( null, word[word.Length - 1].ToString()); 
                }
                else
                firstAndLast.Add(word[0].ToString(), word[word.Length -1].ToString());
            }
                return firstAndLast ;
        }
    }
}
