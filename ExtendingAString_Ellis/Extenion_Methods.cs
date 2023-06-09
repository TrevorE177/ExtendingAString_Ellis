using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendingAString_Ellis
{
    public static class Extenion_Methods
    {
        // 1: Create an Extension Method which would check if a string is a palindrome (true/false) overloaded to allow for a case-sensitive switch.
        public static bool IsPalindrome(this string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsPalindrome(this string str, bool isCaseSensitive)
        {

        }

        // 2: Create an Extension Method which would reverse a string.  By default the casing moves with the letter.  Overload to allow for the casing to remain at the original string location (true) or travel with the character (false and the default).
        public static string ReverseString(this string str)
        {
            var charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // 3: Create an Extension Method which allows for a search parameter for either char or string and returns the number of occurrences of the pattern as an int, with -1 returned if no match is found.
        public static int SearchString(this string str, char letter)
        {
            int count = 0;
            var charArray = str.ToCharArray();
            foreach (var c in charArray)
            {
                if (c == letter)
                {
                    count++;
                }
            }
            return count;
        }

        // 4: Create an Extension Method which removes any duplicate characters found and preserves one of the duplicates ("dogfood" returns "dogf").  All visible characters (spaces, punctuation, etc.) are targets.
        public static string RemoveDuplicateCharacters(this string str)
        {
            StringBuilder sb = new StringBuilder(str);
            for (int i = 0; i < sb.Length; i++)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }

        // 5: Create an Extension Method which returns the maximum occurrences of a character in the string as an int; overload to allow for an enumeration of MAX_OCCURENCE, MIN_OCCURRENCE, MAX_OCCURRENCE_VOWELS, and MIN_OCCURRENCE VOWELS.
        public static int CountOccurrences(this string str)
        {
            Dictionary<char, int> maxOcc = new Dictionary<char, int>();
            int length = str.Length;
            int count = 0;

            for (int i = 0; i < length; i++)
            {
                if (maxOcc.ContainsKey(str[i]))
                {
                    maxOcc[str[i]]++;
                }
                else
                {
                    maxOcc.Add(str[i], 1);
                }
                if (count < maxOcc[str[i]])
                {
                    count = maxOcc[str[i]];
                }
            }
            return count;
        }

        public enum choice
        {
            maxOcc,
            minOcc,
            maxOccVow,
            minOccVow,
        }

        public static int CountOccurrences(this string str, choice ch)
        {
            if (ch == choice.maxOcc)
            {
                
            }
            else if (ch == choice.minOcc)
            {

            }
            else if (ch == choice.maxOccVow)
            {

            }
            else if (ch == choice.minOccVow)
            {

            }
        }
    }
}
