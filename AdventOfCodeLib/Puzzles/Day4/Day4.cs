using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AdventOfCode.Lib.Helpers;

namespace AdventOfCode.Lib.Puzzles.Day4
{
    public class Day4 : DaySolver<string, int>
    {
        public Day4(Data<string> data) : base(data)
        {
        }

        public override int Puzzle1Solution()
        {
            int skip = 0;
            var unstructuredPassportStrings = Data.Get();
            int len = unstructuredPassportStrings.Count();

            int countValid = 0;

            while (skip < len) { 
                var passportFragments = unstructuredPassportStrings
                    .Skip(skip)
                    .TakeWhile(s => s.Length > 0);
                skip += (passportFragments.Count() + 1);

                var joined = passportFragments.Aggregate((accumulator, nextLine) => accumulator + " " + nextLine);
                countValid += new LaxPassport(joined).IsValid() ? 1 : 0 ;

            }
            return countValid;
        }


        public override int Puzzle2Solution()
        {
            int skip = 0;
            var unstructuredPassportStrings = Data.Get();
            int len = unstructuredPassportStrings.Count();

            List<Passport> passports = new List<Passport>(); 
            while (skip < len)
            {
                var passportFragments = unstructuredPassportStrings
                    .Skip(skip)
                    .TakeWhile(s => s.Length > 0);
                skip += (passportFragments.Count() + 1);

                var joined = passportFragments.Aggregate((accumulator, nextLine) => accumulator + " " + nextLine);
                passports.Add(new StrictPassport(joined));

            }

            var valid = passports.Where(p => p.IsValid());

            var debug = valid.Count() > 0? valid
                    .Select(p => p.ToString())
                    .Aggregate((agg, p) => string.Format("{0}\n{1}", agg, p))
                    :"";
            Console.WriteLine(debug);
            return passports.Count(p => p.IsValid());
        }
    }
}
