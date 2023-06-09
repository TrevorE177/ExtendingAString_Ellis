using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ExtendingAString_Ellis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1:
            string _testPalindrome1 = "rotator";
            string _testPalindrome2 = "Rotator";

            if (_testPalindrome1.IsPalindrome())
            {
                Console.WriteLine("\"" + _testPalindrome1 + "\" is a palindrome");
            }
            else
            {
                Console.WriteLine("\"" + _testPalindrome1 + "\" is not a palindrome");
            }

            // 2:
            string _reverseString1 = "D= oppiH";
            string _reversed = _reverseString1.ReverseString();

            Console.WriteLine(_reversed);

            // 3:
            string _multipleCharacters = "checking for like characters in a string";
            char _letter1 = 'e';
            char _letter2 = 'c';
            Console.WriteLine(_letter1 + " : " + _multipleCharacters.SearchString(_letter1));
            Console.WriteLine(_letter2 + " : " + _multipleCharacters.SearchString(_letter2));

            // 4:
            string _removeMultiples = "grasshopper";

            Console.WriteLine(_removeMultiples.RemoveDuplicateCharacters);

            // 5:
            string _string = "wowza";

            Console.WriteLine(_string.CountOccurrences());
        }
    }
}