using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview
{
    class StringCompression
    {
        public StringBuilder stringComppressionProblem(string s)
        {
            int consecutiveChars = 0;
            StringBuilder result = new StringBuilder();

            for(int i = 0; i < s.Length; i++)
            {
                consecutiveChars++;

                if((i +1) >= s.Length || s[i] != s[i + 1])
                {
                    result = result.Append(s[i]);
                    result = result.Append(consecutiveChars);
                    consecutiveChars = 0;
                }
            }

            return result;
        }
    }
}
