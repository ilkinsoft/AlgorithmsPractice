using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.Strings_Arrays
{
    public static class StringCompressionClass
    {
        public static string StringCompression(string str)
        {
            int count = 1;
            StringBuilder newStr = new StringBuilder();

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1]) // same
                    count++;
                else                      // different
                {
                    newStr.Append(str[i - 1]);
                    newStr.Append(count);
                    count = 1;
                }

                if (i == str.Length - 1)
                {
                    newStr.Append(str[i]);
                    newStr.Append(count);
                }
            }

            return newStr.Length == str.Length ? str : newStr.ToString();
        }
    }
}
