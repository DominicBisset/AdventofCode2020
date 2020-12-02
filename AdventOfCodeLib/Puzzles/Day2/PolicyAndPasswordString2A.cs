using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdventOfCode.Lib.Puzzles.Day2
{
    public class PolicyAndPasswordString2A
    {
        public int MinCount { get; }
        public int MaxCount { get; }
        public char Letter { get; }
        public string Password { get; }

        /// <summary>
        /// Parses strings of the form "1-3 a: abcde"
        /// </summary>
        /// <param name="policyAndPassword"></param>
        public PolicyAndPasswordString2A(string policyAndPassword)
        {
            //{"1-3","a:","abcde"}
            var split1 = policyAndPassword.Split(' ');

            //'a'
            Letter = split1[1][0];

            //{"1","3"}
            var split2 = split1[0].Split('-');
            //1
            MinCount = int.Parse(split2[0]);
            //3
            MaxCount = int.Parse(split2[1]);

            //"abcde"
            Password = split1[2];

        }

        public bool IsValid()
        {
            var letterCount = Password.Count(c => c == Letter);
            return letterCount >= MinCount && letterCount <= MaxCount;
        }

    }
}
