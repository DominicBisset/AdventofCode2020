using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Lib.Puzzles.Day4
{
    public class PassportField
    {
        public PassportField(bool required, string shortCode, string fullLabel)
        {
            Required = required;
            ShortCode = shortCode;
            FullLabel = fullLabel;
        }

        public bool Required { get;  }
        public string ShortCode { get; }
        public string FullLabel { get; }
        public string Value { get; set; }

        public virtual bool IsValid()
        {
            return !Required || Value != null;
        }

        public override string ToString()
        {
            return string.Format("{0}:\t{1}\t\t{2}", FullLabel, Value, IsValid());
        }
    }

}
