using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCode.Lib.Puzzles.Day4
{
    public class RegExPassportField : PassportField
    {
        public RegExPassportField(bool required, string shortCode, string fullLabel, string regEx) : base(required, shortCode, fullLabel)
        {
            RegEx = new Regex(regEx);
        }

        public Regex RegEx { get; }

        public override bool IsValid()
        {
            return !Required || (Value != null && RegEx.IsMatch(Value));
        }
    }
}
