using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview
{
    class OneAway
    {

        public bool OneAwayCheck(string s1, string s2)
        {
            if(s1.Length == s2.Length)
            {
                return editAway(s1, s2);
            }
            if(s1.Length + 1 == s2.Length)
            {
                return insertWay(s2, s1);
            }
            if(s1.Length-1 == s2.Length)
            {
                return insertWay(s1, s2);
            }

            return false;

        }

        private bool editAway(string s1, string s2)
        {
            bool nomatchFound = false;

            for(int i = 0; i< s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    if (nomatchFound)
                    {
                        return false;
                    }
                    nomatchFound = true;
                }
            }
            return true;
        }

        private bool insertWay(string s1, string s2)
        {
            int index1 = 0;
            int index2 = 0;

            while(index1 < s1.Length && index2 < s2.Length)
            {
                if(s1[index1] != s2[index2])
                {
                    if(index1 != index2)
                    {
                        return false;
                    }
                    index1++;
                }
                else
                {
                    index1++;
                    index2++;
                }
            }
            return true;
        }
    }
}
