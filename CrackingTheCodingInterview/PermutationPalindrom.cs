using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview
{
    class PermutationPalindrom
    {
        public bool PermutationPalindromProblem(string input)
        {
            int checker = toggleBit(input);
            return 0 == checker || checkIfPermutationPlandrom(checker) == 0;
        }

        private int toggleBit(string input)
        {
            int checker = 0;

            foreach(var ch in input)
            {
                int val = ch;

                if ((checker & (1 << val)) == 0)
                {
                    checker |= 1 << val;
                }
                else
                {
                    checker &= ~(1 << val);
                }                
            }

            return checker;
        }

        private int checkIfPermutationPlandrom(int checker)
        {
            return (checker & (checker - 1));
        }

    }
}
