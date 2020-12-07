using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCode.Lib.Puzzles.Day7
{
    public class Bag
    {
        public string BagLabel { get; }
        public Dictionary<string,Tuple<Bag,int>> PossibleChildBags { get; }
        public Dictionary<string,Bag> PossibleParentBags { get; }

        private Dictionary<string,int> childBags { get; }

        public Bag(string definition)
        {
            //light red bags contain 1 bright white bag, 2 muted yellow bags.
            //Matches "light red"
            var splitDefinition = definition.Split(' ');
            var bagLabelWords = splitDefinition.TakeWhile(w => w != "bags");
            BagLabel = string.Join(" ", bagLabelWords);

            //accomodate for "bags" and "contain[s]"
            int skip = bagLabelWords.Count() + 2;
            childBags = new Dictionary<string, int>();
            if (splitDefinition.Skip(skip).First() != "no")
            {
                while (skip < splitDefinition.Count())
                {
                    var childBagCount = splitDefinition.Skip(skip).First();
                    skip++;
                    bagLabelWords = splitDefinition.Skip(skip)
                                    .TakeWhile(w => !w.StartsWith("bag"));
                    childBags.Add(string.Join(" ", bagLabelWords), int.Parse(childBagCount));
                    skip += bagLabelWords.Count() + 1;
                }

            }
            PossibleChildBags = new Dictionary<string, Tuple<Bag, int>>();
            PossibleParentBags = new Dictionary<string, Bag>();
        }

        public void LinkBags(IEnumerable<Bag> bags)
        {
            foreach(Bag bag in bags)
            {
                if(childBags.ContainsKey(bag.BagLabel))
                {
                    bag.AddPossibleParent(this);
                    AddPossibleChild(bag);
                }
            }
        }

        public HashSet<Bag> GetAncestors()
        {
            var ancestors = new HashSet<Bag>();
            foreach (Bag b in PossibleParentBags.Values)
            {
                ancestors.Add(b);
                ancestors.UnionWith(b.GetAncestors());
            }
            return ancestors;
        }

        public Dictionary<string, Tuple<Bag, int>> GetAllDescendantBags()
        {
            var DescendantBags = new Dictionary<string, Tuple<Bag,int>>(PossibleChildBags);
            foreach((Bag bag, int count) in PossibleChildBags.Values)
            {
                var deeperDescendants = bag.GetAllDescendantBags();
                DescendantBags = MergeDescendants(DescendantBags, deeperDescendants, count);
            }
            return DescendantBags;
        }

        private Dictionary<string, Tuple<Bag, int>> MergeDescendants(Dictionary<string, Tuple<Bag, int>> descendantBags, Dictionary<string, Tuple<Bag, int>> deeperDescendants, int multiplier)
        {
            Dictionary<string, Tuple<Bag, int>> descendants = descendantBags;
            foreach ((Bag bag, int count) in deeperDescendants.Values)
            {
                descendants = MergeDescendantBag(descendants, bag, count * multiplier);
            }
            return descendants;
        }

        private Dictionary<string, Tuple<Bag, int>> MergeDescendantBag(Dictionary<string, Tuple<Bag, int>> descendantBags, Bag bag, int count)
        {
            Dictionary<string, Tuple<Bag, int>> descendants = new Dictionary<string, Tuple<Bag, int>>(descendantBags);
            int newCount = count;
            descendants.TryGetValue(bag.BagLabel, out Tuple<Bag, int> existingDescendantBagType);
            if (existingDescendantBagType != null)
            {
                newCount += existingDescendantBagType.Item2;
            }
            descendants[bag.BagLabel] = new Tuple<Bag, int>(bag, newCount);
            return descendants;
        }

        public void AddPossibleParent(Bag bag)
        {
            PossibleParentBags.Add(bag.BagLabel, bag);
        }

        private void AddPossibleChild(Bag bag)
        {
            PossibleChildBags.Add(bag.BagLabel, new Tuple<Bag,int>(bag, childBags[bag.BagLabel]));
        }
    }
}
