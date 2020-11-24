using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.Strings_Arrays
{
    public static class IsUniqueClass
    {
        public static bool IsUnique(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i+1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                        return false;
                }
            }
            return true;
        }
    }
}
