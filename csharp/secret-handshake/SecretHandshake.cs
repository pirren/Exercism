using System;
using System.Collections.Generic;
using System.Linq;

public static class SecretHandshake
{
    private static readonly Dictionary<int, string> Dict = new Dictionary<int, string>
    {
        { 0b_0000001, "wink" }, 
        { 0b_0000010, "double blink" }, 
        { 0b_0000100, "close your eyes" }, 
        { 0b_0001000, "jump" },
        { 0b_0010000, "reverse" }
    };

    public static string[] Commands(int commandValue)
    {
        var commands = Dict.SkipLast(1).Where(s => (s.Key & commandValue) > 0).Select(s => s.Value);

        return (Dict.Last().Key & commandValue) > 0 ? commands.Reverse().ToArray() : commands.ToArray();
    }
}
