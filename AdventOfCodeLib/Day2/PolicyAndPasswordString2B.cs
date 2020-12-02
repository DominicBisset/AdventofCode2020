using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdventOfCode.Lib.Day2
{
    public class PolicyAndPasswordString2B
    {
        public int Position1 { get; }
        public int Position2 { get; }
        public char Letter { get; }
        public string Password { get; }

        /// <summary>
        /// Parses strings of the form "1-3 a: abcde"
        /// </summary>
        /// <param name="policyAndPassword"></param>
        public PolicyAndPasswordString2B(string policyAndPassword)
        {
            //{"1-3","a:","abcde"}
            var split1 = policyAndPassword.Split(' ');

            //'a'
            Letter = split1[1][0];

            //{"1","3"}
            var split2 = split1[0].Split('-');
            //1
            Position1 = int.Parse(split2[0]) - 1;
            //3
            Position2 = int.Parse(split2[1]) - 1;

            //"abcde"
            Password = split1[2];

        }

        public bool IsValid()
        {
            return Password[Position1] == Letter ^ Password[Position2] == Letter;
        }

    }
}
