using System.Collections.Generic;
using System.Linq;

public static class Diamond
{
    public static string Make(char target)
    {
        List<string> diamond = new List<string>();
        for(int i = 0; i <= target - 'A'; i++)
        {
            string row = "";
            for (int j = 0; j <= target - 'A'; j++)
            {
                row += j == (target - 'A') - i ? (char)(i + 'A') : ' ';
            }

            var reverse = new string(row.Take(row.Length - 1).Reverse().ToArray());

            diamond.Add(string.Concat(row, reverse));
        }

        for (int i = diamond.Count - 2; i >= 0; i--)
        {
            diamond.Add(diamond[i]);
        }

        return string.Join('\n', diamond);
    }
}
