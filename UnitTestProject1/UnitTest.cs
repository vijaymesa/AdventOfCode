using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var score = new Day9.Models.Score();
            const string input = "{}";
            const int shouldBe = 1;
            var result = score.CountTotalScore(input);

            Assert.AreEqual(result, shouldBe, $"result should be {shouldBe} but is {result}");
        }
    }
}
