using System;

namespace CrackingTheCodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. check if string contains Unique chars.
            //UniqueCharacterProblem ucp = new UniqueCharacterProblem();
            //Console.WriteLine(ucp.UniqueCharacters("shubham"));


            //2. check if one string is permutation of other string.
            CheckIfOneStringIsPermutationOfOther perm = new CheckIfOneStringIsPermutationOfOther();
            Console.WriteLine(perm.isPermutation("abc", "bacd"));


            Console.ReadLine();
        }
    }
}
