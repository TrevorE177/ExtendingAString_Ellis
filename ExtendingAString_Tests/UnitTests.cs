using ExtendingAString_Ellis;
using System.Security.Cryptography.X509Certificates;

namespace ExtendingAString_Tests
{
    [TestClass]
    public class UnitTests
    {
        // #1
        [TestMethod]
        public void truePalindrome()
        {
            string palindrome = "rotator";
            string reversed = "rotator";
            palindrome.IsPalindrome();
            Assert.AreEqual(reversed, palindrome);
        }

        [TestMethod]
        public void falsePalindrome()
        {
            string reversed = "Athena";
            Assert.IsFalse(reversed.IsPalindrome());
        }

        // #2
        [TestMethod]
        public void ReverseStringTrue()
        {
            string str = "Oppih";
            string reversed = "Hippo";
            Assert.AreEqual(str.ReverseString(true), reversed);
        }

        [TestMethod]
        public void ReverseStringFalse()
        {
            string str = "Oppih";
            string reversed = "hippO";
            Assert.AreEqual(str.ReverseString(false), reversed);
        }

        // #3
        [TestMethod]
        public void SearchString()
        {
            string str = "watermelon";
            char letter = 'e';
            int count = 2;
            Assert.AreEqual(str.SearchString(letter), count);
        }

        [TestMethod]
        public void FailedSearchString()
        {
            string str = "watermelon";
            char letter = 'p';
            int count = -1;
            Assert.AreEqual(str.SearchString(letter), count);
        }

        // #4
        [TestMethod]
        public void RemoveMultiples()
        {
            string str = "Grasshopper";
            string revised = "Grashope";
            Assert.AreEqual(str.RemoveDuplicateCharacters(), revised);
        }

        // #5
        [TestMethod]
        public void CountOccurrences()
        {
            string str = "noodles";
            int count = 2;
            Assert.AreEqual(str.CountOccurrences(), count);
        }

        [TestMethod]
        public void MaxOcc()
        {
            string str = "noodles";
            int count = 2;
            Assert.AreEqual(str.CountOccurrences(Extension_Methods.choice.maxOcc), count);
        }

        [TestMethod]
        public void MinOcc()
        {
            string str = "xxxOOOO";
            int count = 3;
            Assert.AreEqual(str.CountOccurrences(Extension_Methods.choice.minOcc), count);
        }

        [TestMethod]
        public void MaxVowel()
        {
            string str = "THReee";
            int count = 3;
            Assert.AreEqual(str.CountOccurrences(Extension_Methods.choice.maxOccVow), count);
        }

        [TestMethod]
        public void MinVowel()
        {
            string str = "FooooUR";
            int count = 1;
            Assert.AreEqual(str.CountOccurrences(Extension_Methods.choice.minOccVow), count);
        }
    }
}