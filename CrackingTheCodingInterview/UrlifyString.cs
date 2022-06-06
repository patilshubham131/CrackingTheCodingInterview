using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview
{
    class UrlifyString
    {

        public void UrlifyStringProblem(string s)
        {
             s = s.Replace(" ", "%20");

            Console.WriteLine(s);
        }

        public void replaceString(char[] str, int trueLength)
        {
            int spaceCount = 0;

            for(int i = 0; i< str.Length; i++)
            {
                if(str[i] == ' ')
                {
                    spaceCount++;
                }
            }

            trueLength = trueLength + 3 * spaceCount;

            char[] result = new char[trueLength];

            for(int i = str.Length-1, j = trueLength -1; i>=0; i--)
            {
                if(str[i]!= ' ')
                {
                    result[j--] = str[i];
                }
                else
                {
                    result[j] = '0';
                    result[j - 1] = '2';
                    result[j - 2] = '%';
                    j = j - 3;
                }
            }

            foreach(var ch in result)
            {
                Console.Write(ch);
            }

        }
    }
}
