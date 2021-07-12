using System.Collections.Generic;
using System.Linq;

public static class PythagoreanTriplet
{
    // linq solution from artemkorsakov
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
        => Enumerable.Range(1, sum / 3 - 1)
                .SelectMany(a => Enumerable.Range(a + 1, ((sum - 1) / 2) - (a + 1)).Select(b => (a, b, c: sum - a - b)))
                .Where(x => x.a * x.a + x.b * x.b == x.c * x.c);
}