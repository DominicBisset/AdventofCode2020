using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Lib.Puzzles.Day4
{
    public abstract class Passport
    {
        internal abstract PassportField[] GetPassportDefinition();
        PassportField[] PassportFields;

        protected Dictionary<string, PassportField> PassportFieldsDictionary;

        public Passport(string passportString)
        {
            PassportFields = GetPassportDefinition();
            PassportFieldsDictionary = PassportFields.ToDictionary(pf => pf.ShortCode, pf => pf);

            var providedFields = passportString.Split(' ')
                            .Select(s => asKeyValuePair(s) );
            foreach(var field in providedFields)
            {
                PassportFieldsDictionary[field.Key].Value = field.Value;
            }
        }

        private KeyValuePair<string, string> asKeyValuePair(string s)
        {
            var split = s.Split(':');
            return new KeyValuePair<string, string>(split[0], split[1]);

        }

        public PassportField GetField(string shortCode)
        {
            return PassportFieldsDictionary[shortCode];
        }

        public bool IsValid()
        {
            return PassportFieldsDictionary.All(pf => pf.Value.IsValid());
        }

        public override string ToString()
        {
            //String.Format("{0}:{1}\n", d.Value.FullLabel, d.Value.
            var output = string.Format("{0} Passport:\n", IsValid() ? "Valid" : "Invalid"); 
            output += PassportFieldsDictionary
                .Select(d => d.Value.ToString())
                .Aggregate("",(agg, s)=> string.Format("{0}\t{1}\n",agg, s));
            return output;

        }
    }
}
