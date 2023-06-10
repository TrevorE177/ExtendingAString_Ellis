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
            Console.WriteLine("#1:");

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
            Console.WriteLine();
            _testPalindrome2.IsPalindrome(true);
            _testPalindrome2.IsPalindrome(false);

            Console.WriteLine();

            // 2:
            Console.WriteLine("#2:");

            string _reverseString1 = "D= oppiH";
            string _reverseString2 = "Oppih";

            Console.WriteLine(_reverseString1.ReverseString());
            _reverseString2.ReverseString(false);
            _reverseString2.ReverseString(true);

            Console.WriteLine();

            // 3:
            Console.WriteLine("#3:");

            string _multipleCharacters = "beetles";
            char _letter1 = 'e';
            char _letter2 = 'z';
            Console.WriteLine(_letter1 + " : " + _multipleCharacters.SearchString(_letter1));
            Console.WriteLine(_letter2 + " : " + _multipleCharacters.SearchString(_letter2));

            Console.WriteLine();

            // 4:
            Console.WriteLine("#4:");

            string _removeMultiples = "grasshopper";

            Console.WriteLine(_removeMultiples.RemoveDuplicateCharacters);

            Console.WriteLine();

            // 5:
            Console.WriteLine("#5:");

            string _string = "noodles";

            Console.WriteLine(_string.CountOccurrences());
            Console.WriteLine(_string.CountOccurrences(Extenion_Methods.choice.maxOcc));
            Console.WriteLine(_string.CountOccurrences(Extenion_Methods.choice.minOcc));
            Console.WriteLine(_string.CountOccurrences(Extenion_Methods.choice.maxOccVow));
            Console.WriteLine(_string.CountOccurrences(Extenion_Methods.choice.minOccVow));
        }
    }
}