using ExtendingAString_Ellis;
using System.Security.Cryptography.X509Certificates;

namespace ExtendingAString_Tests
{
    [TestClass]
    public class Test_1
    {
        [TestMethod]
        public void testPalindrome()
        {
            string palindrome = "rotator";
            string reversed = "rotator";
            palindrome.IsPalindrome();
            Assert.AreEqual(reversed, palindrome);
        }

        [TestMethod]
        public void testPalindromeTrue()
        {
            string palindrome = "Rotator";
            string reversed = "rotatoR";
            Assert.IsFalse(reversed.Equals(palindrome, StringComparison.Ordinal));
        }

        [TestMethod]
        public void testPalindromeFalse()
        {
            string palindrome = "Rotator";
            string reversed = "rotatoR";
            Assert.IsTrue(reversed.Equals(palindrome, StringComparison.OrdinalIgnoreCase));
        }
    }
}