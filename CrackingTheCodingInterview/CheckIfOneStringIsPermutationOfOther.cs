using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview
{
    class CheckIfOneStringIsPermutationOfOther
    {

        public bool isPermutation(string str1 , string str2)
        {
            var result1 =  performSort(str1);
            var result2 = performSort(str2);
            return result1 == result2;
        }

        private string performSort(string str)
        {
            char[] ch = str.ToCharArray();
            Array.Sort(ch);
            return new string(ch);
        }
    }
}
