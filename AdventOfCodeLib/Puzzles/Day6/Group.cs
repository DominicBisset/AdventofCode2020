using System.Collections.Generic;
using System.Linq;
public class Group
{
    public List<string> GroupDefinition;
    public Group(IEnumerable<string> groupDefintion)
    {
        GroupDefinition = groupDefintion.ToList();
    }

    public HashSet<char> DistinctQuestions()
    {
        return GroupDefinition.Select(s => s.ToHashSet())
                .Aggregate((agg, set) => { agg.UnionWith(set); return agg; });
    }

    public HashSet<char> CommonQuestions()
    {
        return GroupDefinition.Select(s => s.ToHashSet())
                .Aggregate((agg, set) => { agg.IntersectWith(set); return agg; });
    }
}