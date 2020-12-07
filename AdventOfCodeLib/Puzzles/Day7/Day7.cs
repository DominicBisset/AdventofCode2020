using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AdventOfCode.Lib.Helpers;

namespace AdventOfCode.Lib.Puzzles.Day7
{
    public class Day7 : DaySolver<string, int>
    {
        public Day7(Data<string> data) : base(data)
        {
        }

        public override int Puzzle1Solution()
        {
            List<Bag> bagRules = ParseBagRules();

            Bag shinyGoldBag = bagRules.First(b => b.BagLabel == "shiny gold");

            return shinyGoldBag.GetAncestors().Count();
        }

        public override int Puzzle2Solution()
        {
            List<Bag> bagRules = ParseBagRules();

            Bag shinyGoldBag = bagRules.First(b => b.BagLabel == "shiny gold");

            return shinyGoldBag.GetAllDescendantBags().Values.Aggregate(0, (agg, bag) => agg + bag.Item2);
        }

        private List<Bag> ParseBagRules()
        {
            var bagRules = Data.Get()
                            .Select(s => new Bag(s))
                            .ToList();

            bagRules = bagRules
                .Select(bag => { bag.LinkBags(bagRules); return bag; })
                .ToList();
            return bagRules;
        }
    }
}
