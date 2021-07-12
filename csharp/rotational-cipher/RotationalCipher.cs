using System.Text;

public static class RotationalCipher
{

    public static string Rotate(string text, int shiftKey)
    {
        var output = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            output.Append(ReplacementChar(text[i], shiftKey));
        }
        return output.ToString();
    }

    private static char ReplacementChar(char toReplace, int shiftKey)
    {
        char toReplaceLow = char.ToLower(toReplace);

        string latin = "abcdefghijklmnopqrstuvwxyz";
        if (latin.Contains(toReplaceLow) == false)
        {
            return toReplace;
        }

        int newIndex = latin.IndexOf(toReplaceLow) + shiftKey;
        if (newIndex >= latin.Length)
        {
            newIndex -= latin.Length;
        }
        var charOut = latin[newIndex];
        return char.IsUpper(toReplace) ? char.ToUpper(charOut) : charOut;
    }
}