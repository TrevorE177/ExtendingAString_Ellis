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
            Console.WriteLine(_reverseString2.ReverseString(true));
            Console.WriteLine(_reverseString2.ReverseString(false));

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

            string _removeMultiples = "Grasshopper";

            Console.WriteLine(_removeMultiples.RemoveDuplicateCharacters());

            Console.WriteLine();

            // 5:
            Console.WriteLine("#5:");

            string _string1 = "noodles";
            string _string2 = "xxxOOOO";
            string _string3 = "voooooweeeels";
            string test = "FooooUR";
            string test1 = "a";

            Console.WriteLine(_string1.CountOccurrences());
            Console.WriteLine(_string1.CountOccurrences(Extension_Methods.choice.maxOcc));
            Console.WriteLine(_string2.CountOccurrences(Extension_Methods.choice.minOcc));
            Console.WriteLine(_string3.CountOccurrences(Extension_Methods.choice.maxOccVow));
            Console.WriteLine(test.CountOccurrences(Extension_Methods.choice.minOccVow));
            Console.WriteLine(test1.CountOccurrences(Extension_Methods.choice.minOccVow));
        }
    }
}