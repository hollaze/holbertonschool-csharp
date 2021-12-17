using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void TestNull()
        {
            Assert.AreEqual(0, Text.Str.CamelCase(null));
        }

        [Test]
        public void TestEmpty()
        {
            Assert.AreEqual(0, Text.Str.CamelCase(""));
        }

        [TestCase("howManyNumbersInThisStringIsThere")]
        public void TestNumberOfWords(string s)
        {
            Assert.AreEqual(8, Text.Str.CamelCase(s));
        }
    }
}
