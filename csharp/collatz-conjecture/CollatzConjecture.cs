using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number <= 0) throw new ArgumentOutOfRangeException();
        int steps = 0;
        return LotharCollatz(number, ref steps);
    }

    private static int LotharCollatz(int number, ref int steps)
    {
        if (number == 1) return steps;

        if (number % 2 == 0) number /= 2;

        else if (number % 2 != 0) number = (number * 3) + 1;

        steps++;
        LotharCollatz(number, ref steps);

        return steps;
    }
}