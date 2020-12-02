using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Lib.Day2;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class TestDay2
    {
        [TestMethod]
        public void TestDay2A()
        {
            string[] passwordAndPolicyStrings = new string[] { 
                "1-3 a: abcde",
                "1-3 b: cdefg",
                "2-9 c: ccccccccc"
            };
            int expectedOutput = 2;
            Day2 day2 = new Day2();

            var actualOutut = day2.CountPasswordsCorrect2A(passwordAndPolicyStrings);


            Assert.AreEqual(expectedOutput, actualOutut);
        }

        [TestMethod]
        public void TestDay2B()
        {
            string[] passwordAndPolicyStrings = new string[] {
                "1-3 a: abcde",
                "1-3 b: cdefg",
                "2-9 c: ccccccccc"
            };
            int expectedOutput = 1;
            Day2 day2 = new Day2();

            var actualOutut = day2.CountPasswordsCorrect2B(passwordAndPolicyStrings);


            Assert.AreEqual(expectedOutput, actualOutut);
        }
    }
}
