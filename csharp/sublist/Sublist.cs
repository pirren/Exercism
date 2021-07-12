using System;
using System.Collections.Generic;
using System.Linq;

public enum SublistType
{
    Equal,
    Unequal,
    Superlist,
    Sublist
}

public static class Sublist
{
    public static SublistType Classify<T>(List<T> list1, List<T> list2)
        where T : IComparable 
        => list1.SequenceEqual(list2)
            ? SublistType.Equal
            : list2.ContainsSubSequence(list1)
            ? SublistType.Sublist
            : list1.ContainsSubSequence(list2) ? SublistType.Superlist : SublistType.Unequal;

    private static bool ContainsSubSequence<T>(this List<T> sequence, List<T> subsequence) where T : IComparable 
        => subsequence.Count < sequence.Count
            && Enumerable.Range(0, sequence.Count - subsequence.Count + 1)
            .Any(n => sequence.Skip(n).Take(subsequence.Count).SequenceEqual(subsequence));
}
