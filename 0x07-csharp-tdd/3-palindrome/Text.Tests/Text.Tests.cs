using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void TestEmptyString()
        {
            string empty = "";
            bool isPalindrome = Text.Str.IsPalindrome(empty);

            Assert.IsTrue(isPalindrome);
        }

        [TestCase("pOp")]
        [TestCase("Wassamassaw")]
        [TestCase("raceCar")]
        [TestCase("testSet")]
        [TestCase("deifieD")]
        [TestCase("lEvel")]
        [TestCase("radAr")]
        [TestCase("ciVic")]
        [TestCase("kayAk")]
        public void TestCaseSensitive(string palindrome)
        {
            bool isPalindrome = Text.Str.IsPalindrome(palindrome);

            Assert.IsTrue(isPalindrome);
        }

        [TestCase("Lewd did I live & evil I did dwel.")]
        [TestCase("A man, a plan, a canal: Panama.")]
        [TestCase("Able was I ere I saw Elba")]
        [TestCase("Too bad--I hid a boot...")]
        [TestCase("Do geese: see God?")]
        [TestCase("Murder for a jar of red rum. :()")]
        [TestCase("Drab as a fool, aloof as a bard.")]
        public void TestIgnoringPunctuations(string palindrome)
        {
            bool isPalindrome = Text.Str.IsPalindrome(palindrome);

            Assert.IsTrue(isPalindrome);
        }
    }
}
