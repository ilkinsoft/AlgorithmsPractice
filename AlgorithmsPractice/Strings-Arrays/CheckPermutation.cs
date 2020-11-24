using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.Strings_Arrays
{
    public static class CheckPermutationClass
    {
        //  1st try
        public static bool CheckPermutation(string s1, string s2)
        {
            HashSet<char> charSet = new HashSet<char>();
            foreach (var c in s1)
                charSet.Add(c);

            foreach (var c in s2)
                if (!charSet.Contains(c))
                    return false;

            return true;
            // complexity: O(n^2) 
        }

        // 2nd try
        public static bool CheckPermutation2(string s1, string s2)
        {
            return true;
        }
    }
}
