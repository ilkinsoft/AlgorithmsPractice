using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.Strings_Arrays
{
    class UrlifyClass
    {
        public static char[] Urlify(string str, int actualLength)
        {
            // In-place method
            char[] charArr = str.ToCharArray();
            string replace = "%20";
            int loopcount = 1;

            for (int i = actualLength - 1; i >= 0; i--)
            {
                if (charArr[i] == ' ')
                    for (int j = replace.Length - 1; j >= 0; j--)
                    {
                        charArr[charArr.Length - loopcount] = replace[j];
                        loopcount++;
                    }
                else
                {
                    charArr[charArr.Length - loopcount] = charArr[i];
                    loopcount++;
                }
            }
            return charArr;
        }
    }
}
