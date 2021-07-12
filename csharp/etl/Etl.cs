using System;
using System.Collections.Generic;
using System.Linq;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
        => old.SelectMany(s => s.Value).Select(s => s.ToLower())
                .ToDictionary(k => k, v => old.FirstOrDefault(s => s.Value.Contains(v.ToUpper())).Key);
}