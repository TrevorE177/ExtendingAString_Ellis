using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ExtendingAString_Ellis
{
    public static class Extension_Methods
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
            if (!isCaseSensitive)
            {
                str = str.ToLower();
            }
            Console.WriteLine(str.IsPalindrome());
        }

        // 2: Create an Extension Method which would reverse a string.  By default the casing moves with the letter.  Overload to allow for the casing to remain at the original string location (true) or travel with the character (false and the default).
        public static string ReverseString(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string ReverseString(this string str, bool keepCasing)
        {
            if (keepCasing == true)
            {
                List<int> index = new List<int>();
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i].ToString() == str[i].ToString().ToUpper())
                    {
                        index.Add(i);
                    }
                }
                char[] charArray = str.ToLower().ToCharArray();
                Array.Reverse(charArray);

                for (int i = 0; i < index.Count; i++)
                {
                    charArray[index[i]] = Convert.ToChar(charArray[index[i]].ToString().ToUpper());
                }

                return new string(charArray);
            }
            else
            {
                return str.ReverseString();
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
            var charArray = str.ToCharArray().Distinct().ToArray();
            return new string(charArray);
        }

        // 5: Create an Extension Method which returns the maximum occurrences of a character in the string as an int; overload to allow for an enumeration of MAX_OCCURENCE, MIN_OCCURRENCE, MAX_OCCURRENCE_VOWELS, and MIN_OCCURRENCE VOWELS.
        public static int CountOccurrences(this string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int count = 1;

            foreach (char c in str)
            {
                int i;
                dict.TryGetValue(c, out i);
                i++;
                if (i > count)
                {
                    count = i;
                }
                dict[c] = i;
            }
            return dict.Values.Max();
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
            Dictionary<char, int> dict = new Dictionary<char, int>();            
            int count = 1;

            foreach (char c in str)
            {
                int i;
                dict.TryGetValue(c, out i);
                i++;
                if (i > count)
                {
                    count = i;
                }
                dict[c] = i;
            }

            if (ch == choice.maxOcc)
            {
                return dict.Values.Max();               
            }
            else if (ch == choice.minOcc)
            {
                return dict.Values.Min();
            }
                        
            string vowels = "aeiouAEIOU";
            int lowVowel = 0;
            int highVowel = 0;
            int firstVowel = 0;
            int newInt = 0;
            int oldInt = 0;

            foreach (char c in vowels)
            {
                int j = 0;
                dict.TryGetValue(c, out j);
                if (j != 0)
                {
                    oldInt = newInt;
                    newInt = j;

                    if (newInt > oldInt)
                    {
                        highVowel = j;
                        lowVowel = oldInt; 
                        if (firstVowel == 0)
                        {
                            firstVowel = 1;
                            lowVowel = j;
                        }
                    }
                    else
                    {
                        lowVowel = j;
                    }
                }
            }

            if (ch == choice.maxOccVow)
            {
                return highVowel;
            }
            else
            {
                return lowVowel;
            }
        }
    }
}
