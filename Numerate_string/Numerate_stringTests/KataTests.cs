using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numerate_string;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerate_string.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void Alphabet_PositionTest()
        {
            //Assert.AreEqual("a b c d e f g", Kata.Alphabet_Position("gfedcba"));
            Assert.AreEqual("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11", Kata.Alphabet_Position("The sunset sets at twelve o' clock."));
            Assert.AreEqual("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20", Kata.Alphabet_Position("The narwhal bacons at midnight."));
        }
    }
}