using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Lib.Puzzles.Day4;
using AdventOfCode.Lib.Helpers;
using System.Numerics;
using System;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class TestDay4
    {
        [TestMethod]
        public void TestPartA()
        {
            string[] inputData = new string[] {
                "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd",
                "byr:1937 iyr:2017 cid:147 hgt:183cm",
                "",
                "iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884",
                "hcl:#cfa07d byr:1929",
                "",
                "hcl:#ae17e1 iyr:2013",
                "eyr:2024",
                "ecl:brn pid:760753108 byr:1931",
                "hgt:179cm",
                "",
                "hcl:#cfa07d eyr:2025 pid:166559648",
                "iyr:2011 ecl:brn hgt:59in"
            };
            int expectedOutput = 2;

            var data = new StringData(inputData);
            var solver = new Day4(data);

            //Shouldn't need to change these lines
            var actualOutut = solver.Puzzle1Solution();
            Assert.AreEqual(expectedOutput, actualOutut);
        }

        [TestMethod]
        public void TestPartB_ValidByrField_1()
        {
            var s = "byr:2002";
            bool expected = true;
            var isValid = (new StrictPassport(s).GetField("byr")).IsValid();

            Assert.AreEqual(expected, isValid);
        }

        [TestMethod]
        public void TestPartB_InvalidByrField_1()
        {
            var s = "byr:2003";
            bool expected = false;
            var isValid = (new StrictPassport(s).GetField("byr")).IsValid();

            Assert.AreEqual(expected, isValid);
        }

        [TestMethod]
        public void TestPartB_ValidHgtField_1()
        {
            var s = "hgt:60in";
            bool expected = true;
            var isValid = (new StrictPassport(s).GetField("hgt")).IsValid();

            Assert.AreEqual(expected, isValid);
        }

        [TestMethod]
        public void TestPartB_ValidHgtField_2()
        {
            var s = "hgt:190cm";
            bool expected = true;
            var isValid = (new StrictPassport(s).GetField("hgt")).IsValid();

            Assert.AreEqual(expected, isValid);
        }

        [TestMethod]
        public void TestPartB_InvalidHgtField_1()
        {
            var s = "hgt:190in";
            bool expected = false;
            var isValid = (new StrictPassport(s).GetField("hgt")).IsValid();

            Assert.AreEqual(expected, isValid);
        }

        [TestMethod]
        public void TestPartB_InvalidHgtField_2()
        {
            var s = "hgt:190";
            bool expected = false;
            var isValid = (new StrictPassport(s).GetField("hgt")).IsValid();

            Assert.AreEqual(expected, isValid);
        }


        [TestMethod]
        public void TestPartB_ValidHclField_1()
        {
            var s = "hcl:#123abc";
            bool expected = true;
            var isValid = (new StrictPassport(s).GetField("hcl")).IsValid();

            Assert.AreEqual(expected, isValid);
        }

        [TestMethod]
        public void TestPartB_InvalidHclField_1()
        {
            var s = "hcl:#123abz";
            bool expected = false;
            var isValid = (new StrictPassport(s).GetField("hcl")).IsValid();

            Assert.AreEqual(expected, isValid);
        }

        [TestMethod]
        public void TestPartB_InvalidHclField_2()
        {
            var s = "hcl:123abc";
            bool expected = false;
            var isValid = (new StrictPassport(s).GetField("hcl")).IsValid();

            Assert.AreEqual(expected, isValid);
        }

        [TestMethod]
        public void TestPartB_ValidEclField_1()
        {
            var s = "ecl:brn";
            bool expected = true;
            var isValid = (new StrictPassport(s).GetField("ecl")).IsValid();

            Assert.AreEqual(expected, isValid);
        }

        [TestMethod]
        public void TestPartB_InvalidEclField_1()
        {
            var s = "ecl:wat";
            bool expected = false;
            var isValid = (new StrictPassport(s).GetField("ecl")).IsValid();

            Assert.AreEqual(expected, isValid);
        }

        [TestMethod]
        public void TestPartB_ValidPidField_1()
        {
            var s = "pid:000000001";
            bool expected = true;
            var isValid = (new StrictPassport(s).GetField("pid")).IsValid();

            Assert.AreEqual(expected, isValid);
        }

        [TestMethod]
        public void TestPartB_InvalidPidField_1()
        {
            var s = "pid:0123456789";
            bool expected = false;
            var isValid = (new StrictPassport(s).GetField("pid")).IsValid();

            Assert.AreEqual(expected, isValid);
        }

        [TestMethod]
        public void TestPartB_InvalidPassport_1()
        {
            string[] inputData = new string[] {
                "eyr:1972 cid:100"
                ,"hcl:#18171d ecl:amb hgt:170 pid:186cm iyr:2018 byr:1926"
            };
            int expectedOutput = 0;


            var data = new StringData(inputData);
            var solver = new Day4(data);

            //Shouldn't need to change these lines
            var actualOutut = solver.Puzzle2Solution();
            Assert.AreEqual(expectedOutput, actualOutut);
        }

        [TestMethod]
        public void TestPartB_InvalidPassport_2()
        {
            string[] inputData = new string[] {
                 "iyr:2019"
                ,"hcl:#602927 eyr:1967 hgt:170cm"
                ,"ecl:grn pid:012533040 byr:1946"
            };
            int expectedOutput = 0;


            var data = new StringData(inputData);
            var solver = new Day4(data);

            //Shouldn't need to change these lines
            var actualOutut = solver.Puzzle2Solution();
            Assert.AreEqual(expectedOutput, actualOutut);
        }

        [TestMethod]
        public void TestPartB_InvalidPassport_3()
        {
            string[] inputData = new string[] {
                 "hcl:dab227 iyr:2012"
                ,"ecl:brn hgt:182cm pid:021572410 eyr:2020 byr:1992 cid:277"
            };
            int expectedOutput = 0;


            var data = new StringData(inputData);
            var solver = new Day4(data);

            //Shouldn't need to change these lines
            var actualOutut = solver.Puzzle2Solution();
            Assert.AreEqual(expectedOutput, actualOutut);
        }
        [TestMethod]
        public void TestPartB_InvalidPassport_4()
        {
            string[] inputData = new string[] {
                 "hgt:59cm ecl:zzz"
                ,"eyr:2038 hcl:74454a iyr:2023"
                ,"pid:3556412378 byr:2007"
            };
            int expectedOutput = 0;


            var data = new StringData(inputData);
            var solver = new Day4(data);

            //Shouldn't need to change these lines
            var actualOutut = solver.Puzzle2Solution();
            Assert.AreEqual(expectedOutput, actualOutut);
        }

        [TestMethod]
        public void TestPartB_ValidPassport_1()
        {
            string[] inputData = new string[] {
            "pid:087499704 hgt:74in ecl:grn iyr:2012 eyr:2030 byr:1980",
            "hcl:#623a2f"
            };
            int expectedOutput = 1;


            var data = new StringData(inputData);
            var solver = new Day4(data);

            //Shouldn't need to change these lines
            var actualOutut = solver.Puzzle2Solution();
            Assert.AreEqual(expectedOutput, actualOutut);
        }


        [TestMethod]
        public void TestPartB_ValidPassport_2()
        {
            string[] inputData = new string[] {
            "eyr:2029 ecl:blu cid:129 byr:1989",
            "iyr:2014 pid:896056539 hcl:#a97842 hgt:165cm",
            ""
            };
            int expectedOutput = 1;


            var data = new StringData(inputData);
            var solver = new Day4(data);

            //Shouldn't need to change these lines
            var actualOutut = solver.Puzzle2Solution();
            Assert.AreEqual(expectedOutput, actualOutut);
        }

        [TestMethod]
        public void TestPartB_ValidPassport_3()
        {
            string[] inputData = new string[] {
            "hcl:#888785",
            "hgt:164cm byr:2001 iyr:2015 cid:88",
            "pid:545766238 ecl:hzl",
            "eyr:2022"
            };
            int expectedOutput = 1;


            var data = new StringData(inputData);
            var solver = new Day4(data);

            //Shouldn't need to change these lines
            var actualOutut = solver.Puzzle2Solution();
            Assert.AreEqual(expectedOutput, actualOutut);
        }

        [TestMethod]
        public void TestPartB_ValidPassport_4()
        {
            string[] inputData = new string[] {
            "iyr:2010 hgt:158cm hcl:#b6652a ecl:blu byr:1944 eyr:2021 pid:093154719"
            };
            int expectedOutput = 1;


            var data = new StringData(inputData);
            var solver = new Day4(data);

            //Shouldn't need to change these lines
            var actualOutut = solver.Puzzle2Solution();
            Assert.AreEqual(expectedOutput, actualOutut);
        }

    }
}
