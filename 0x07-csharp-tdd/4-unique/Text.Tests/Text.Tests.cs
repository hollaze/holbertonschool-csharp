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
            Assert.AreEqual(-1, Text.Str.UniqueChar(null));
        }

        [Test]
        public void TestEmpty()
        {
            Assert.AreEqual(-1, Text.Str.UniqueChar(""));
        }

        [TestCase("ssttrr")]
        [TestCase("tteesstt")]
        [TestCase("testtest")]
        [TestCase("strstr")]
        public void TestNonUniqueChar(string nonUnique)
        {
            Assert.AreEqual(-1, Text.Str.UniqueChar(nonUnique));
        }

        [TestCase("unique")]
        public void TestUniqueChar(string unique)
        {
            Assert.AreEqual(1, Text.Str.UniqueChar(unique));
        }
    }
}
