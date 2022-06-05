using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview
{
    class UniqueCharacterProblem
    {
        //solution to find if the string has the unique characters.

        public bool UniqueCharacters(string input)
        {
            int checker = 0;

            foreach(var ch in input)
            {
                int val = ch;

                if ((checker & (1 << val)) > 0)
                {
                    return false;
                }

                checker |= (1<<val);
            }

            return true;
        }
    }
}
