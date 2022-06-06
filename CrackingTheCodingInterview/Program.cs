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
            //CheckIfOneStringIsPermutationOfOther perm = new CheckIfOneStringIsPermutationOfOther();
            //Console.WriteLine(perm.isPermutation("abc", "bacd"));

            //3. Urlify string
            //UrlifyString us = new UrlifyString();
            //string input = "shubham patil from narvel";
            //us.UrlifyStringProblem(input); // using string replace function

            //us.replaceString(input.ToCharArray(), input.Length);//using character array and manually placing %20 instead of spaces

            //4. check if string is palindrom permutation
            PermutationPalindrom pp = new PermutationPalindrom();
            var result = pp.PermutationPalindromProblem("abbakjj");

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
