using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class ParallelLetterFrequency
{
    private const string Pattern = @"[a-zA-ZäöüÄÖÜß]";

    public static Dictionary<char, int> Calculate(IEnumerable<string> texts) 
        => texts.SelectMany(s => s.ToLower())
            .Where(c => Regex.IsMatch(c.ToString(), Pattern))
            .GroupBy(c => c)
            .ToDictionary(k => k.Key, v => v.Count());
}
