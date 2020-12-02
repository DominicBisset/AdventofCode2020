using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdventOfCode.Lib.Day2
{
    public class Day2
    {
        public int CountPasswordsCorrect2A(ICollection<string> policyAndPasswordStrings)
        {
            var parsed = policyAndPasswordStrings.Select(pps => new PolicyAndPasswordString2A(pps));
            return parsed.Count(pps => pps.IsValid());
        }

        public int CountPasswordsCorrect2B(ICollection<string> policyAndPasswordStrings)
        {
            var parsed = policyAndPasswordStrings.Select(pps => new PolicyAndPasswordString2B(pps));
            return parsed.Count(pps => pps.IsValid());
        }
    }
}
