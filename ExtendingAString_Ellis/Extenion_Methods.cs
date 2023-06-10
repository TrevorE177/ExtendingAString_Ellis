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
        
        public static void IsPalindrome(this string str, bool isCaseSensitive)
        {
            string reverse;
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            reverse = new string(ch);

            if (isCaseSensitive == true)
            {
                if (str == reverse)
                {
                    Console.WriteLine(str + " is a Palindrome!");
                }
                else if(str != reverse)
                {
                    Console.WriteLine(str + " is not a Palindrome!");
                }
            }
            else if (isCaseSensitive == false)
            {
                bool b = str.Equals(reverse, StringComparison.OrdinalIgnoreCase);
                if (b == true)
                {
                    Console.WriteLine("" + str + " is a Palindrome!");
                }
                else
                {
                    Console.WriteLine(" " + str + " is not a Palindrome!");
                }
            }
        }

        // 2: Create an Extension Method which would reverse a string.  By default the casing moves with the letter.  Overload to allow for the casing to remain at the original string location (true) or travel with the character (false and the default).
        public static string ReverseString(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static void ReverseString(this string str, bool keepCasing)
        {
            if (keepCasing == false)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = str.Length -1; i >=0; i--)
                {
                    sb.Append(str[i]);
                }
                Console.WriteLine(sb.ToString());
            }
            else
            {
                char[] charArray = str.ToCharArray();
                Array.Reverse(charArray);
                Console.WriteLine(new string(charArray));
            }

        }

        // 3: Create an Extension Method which allows for a search parameter for either char or string and returns the number of occurrences of the pattern as an int, with -1 returned if no match is found.
        public static int SearchString(this string str, char letter)
        {
            int count = 0;
            var charArray = str.ToCharArray();
            if (str.Contains(letter))
            {
                foreach (var c in charArray)
                {
                    if (c == letter)
                    {
                        count++;
                    }
                }
                return count;
            }
            else
            {
                return -1;
            }
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
            else if (ch == choice.minOcc)
            {
                Dictionary<char, int> minOcc = new Dictionary<char, int>();
                int count = 0;

                foreach (char c in str)
                {
                    int i;
                    minOcc.TryGetValue(c, out i);
                    i++;
                    if (i > count)
                    {
                        count = i;
                    }
                    minOcc[c] = i;
                }
                return count;
            }
            else if (ch == choice.maxOccVow)
            {
                return -1;
            }
            else if (ch == choice.minOccVow)
            {
                return -1;
            }
            return 0;
        }
    }
}
