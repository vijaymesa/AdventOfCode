﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var score = new Day9.Models.Score();
            const string input = "{}";
            const int shoulBe = 1;
            var result = score.CountTotalScore(input);

            Assert.AreEqual(result, shoulBe, $"result should be {shoulBe} but is {result}");
        }
    }
}
