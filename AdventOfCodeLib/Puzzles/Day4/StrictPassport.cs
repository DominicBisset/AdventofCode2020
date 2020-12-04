using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Lib.Puzzles.Day4
{
    public class StrictPassport : Passport
    {
        internal override PassportField[] GetPassportDefinition()
        {
            return new PassportField[] {
                new NumericRangePassportField(true, "byr","Birth Year",1920,2002),
                new NumericRangePassportField(true, "iyr" ,"Issue Year",2010,2020),
                new NumericRangePassportField(true, "eyr" ,"Expiration Year",2020,2030),
                new RegExPassportField(true, "hgt" ,"Height", "^^1([5-8]\\d|9[0-3])cm|(59|6\\d|7[0-6])in$"),
                new RegExPassportField(true, "hcl" ,"Hair Color", "^#[\\da-f]{6}$"),
                new RegExPassportField(true, "ecl" ,"Eye Color", "^(amb|blu|brn|gry|grn|hzl|oth)$"),
                new RegExPassportField(true, "pid" ,"Passport ID","^\\d{9}$"),
                new PassportField(false, "cid" ,"Country ID")
            };
        }

        public StrictPassport(string passportString) : base(passportString)
        {
        }
    }
}
