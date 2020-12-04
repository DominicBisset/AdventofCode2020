using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Lib.Puzzles.Day4
{
    public class NumericRangePassportField: PassportField
    {
        public NumericRangePassportField(bool required, string shortCode, string fullLabel, long min, long max) : base(required, shortCode, fullLabel)
        {
            Min = min;
            Max = max;
        }

        public long Min { get; }
        public long Max { get; }
        public long NumericValue{ get => long.Parse(Value); }

        public override bool IsValid()
        {
            return !Required || (Value != null && (NumericValue >= Min && NumericValue <= Max));
        }
    }
}
