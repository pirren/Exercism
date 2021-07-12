using System.Linq;

public class Anagram
{
    private readonly string candidate;

    public Anagram(string baseWord) => candidate = baseWord.ToLower();

    public string[] FindAnagrams(string[] potentialMatches) 
        => potentialMatches
            .ToDictionary(k => k, v => v.Select(s => char.ToLower(s)).ToArray())
            .Where(s => s.Value.All(
            v =>
                candidate.Contains(char.ToLower(v)))
                && new string(s.Value.ToArray()) != candidate
                && s.Value.Length == candidate.Length
            )
            .Where(s => s.Value.All(ch 
                => s.Value.Count(x => x == ch) == candidate.Count(cch => cch == ch))
            )
            .Select(s => s.Key)
            .ToArray();
}
