using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Lib.Puzzles.Day4
{
    public class LaxPassport : Passport
    {
        internal override PassportField[] GetPassportDefinition()
        {
            return new PassportField[] {
                new PassportField(true, "byr","Birth Year"),
                new PassportField(true, "iyr" ,"Issue Year"),
                new PassportField(true, "eyr" ,"Expiration Year"),
                new PassportField(true, "hgt" ,"Height"),
                new PassportField(true, "hcl" ,"Hair Color"),
                new PassportField(true, "ecl" ,"Eye Color"),
                new PassportField(true, "pid" ,"Passport ID"),
                new PassportField(false, "cid" ,"Country ID")
            };
        }

        public LaxPassport(string passportString) : base(passportString)
        {
        }
    }
}
