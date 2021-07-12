using System;
using System.Collections.Generic;
using System.Linq;

public static class WordCount
{
    public static IDictionary<string, int> CountWords(string phrase)
        => phrase.Split(new[] { ' ', ',', '\n' }, StringSplitOptions.RemoveEmptyEntries)
            .TrimWords()
            .GroupBy(grp => grp)
            .ToDictionary(k => k.Key, v => v.Count());

    public static string[] TrimWords(this string[] words)
    {
        List<string> returnList = new List<string>();
        foreach (string word in words)
        {
            string w = new string(word.Where(c => char.IsLetterOrDigit(c) || c == '\'').ToArray()).ToLower();

            if (w.StartsWith('\'') && w.EndsWith('\'')) 
                w = w[1..^1];

            returnList.Add(w);
        }
        return returnList.ToArray();
    }
}
