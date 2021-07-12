using System.Linq;
using System.Text.RegularExpressions;

public static class MatchingBrackets
{
    public static bool IsPaired(string input)
    {
        var pattern = @"\(\)|\{\}|\[\]";
        var antiPattern = @"\(*\)*\[*\]*\{*\}*";

        input = Regex.Matches(input, antiPattern).Cast<Match>().Aggregate(string.Empty, (s, m) => s + m.Value, s => s);
        if (input.Length % 2 != 0) return false;

        while (Regex.IsMatch(input, pattern)) input = Regex.Replace(input, pattern, string.Empty);

        return input.Length == 0;
    }
}
