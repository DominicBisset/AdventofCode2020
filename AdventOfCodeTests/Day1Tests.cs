using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Lib;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class TestDay1
    {
        [TestMethod]
        public void TestDay1A()
        {
            int[] numbers = new int[] { 1721, 979, 366, 299, 675, 1456};
            int expectedOutput = 514579;
            Day1 day1 = new Day1();
            
            var actualOutut = day1.ExpensesAmount1A(numbers);


            Assert.AreEqual(expectedOutput, actualOutut);
        }

        [TestMethod]
        public void TestDay1B()
        {
            int[] numbers = new int[] { 1721, 979, 366, 299, 675, 1456 };
            int expectedOutput = 241861950;
            Day1 day1 = new Day1();

            var actualOutut = day1.ExpensesAmount1B(numbers);


            Assert.AreEqual(expectedOutput, actualOutut);
        }
    }
}
