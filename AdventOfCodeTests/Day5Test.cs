using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Lib.Puzzles.Day4;
using AdventOfCode.Lib.Helpers;
using System.Numerics;
using System;
using AdventOfCode.Lib.Puzzles.Day5;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class TestDay5
    {
        [TestMethod]
        public void TestPartA_BoardingPass1()
        {
            string inputData = "FBFBBFFRLR";
            int expectedOutput = 357;

            var boardingPass = new BoardingPass(inputData);

            //Shouldn't need to change these lines
            var actualOutut = boardingPass.SeatID();
            Assert.AreEqual(expectedOutput, actualOutut);
        }

        [TestMethod]
        public void TestPartA_BoardingPass2()
        {
            string inputData = "BFFFBBFRRR";
            int expectedOutput = 567;

            var boardingPass = new BoardingPass(inputData);

            //Shouldn't need to change these lines
            var actualOutut = boardingPass.SeatID();
            Assert.AreEqual(expectedOutput, actualOutut);
        }
        [TestMethod]
        public void TestPartA_BoardingPass3()
        {
            string inputData = "FFFBBBFRRR";
            int expectedOutput = 119;

            var boardingPass = new BoardingPass(inputData);

            //Shouldn't need to change these lines
            var actualOutut = boardingPass.SeatID();
            Assert.AreEqual(expectedOutput, actualOutut);
        }
        [TestMethod]
        public void TestPartA_BoardingPass4()
        {
            string inputData = "BBFFBBFRLL";
            int expectedOutput = 820;

            var boardingPass = new BoardingPass(inputData);

            //Shouldn't need to change these lines
            var actualOutut = boardingPass.SeatID();
            Assert.AreEqual(expectedOutput, actualOutut);
        }

    }
}
