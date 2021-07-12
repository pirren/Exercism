﻿using System;
using System.Linq;

public static class ResistorColor
{
    public enum ColorCodes
    {
        black = 0,
        brown = 1,
        red = 2,
        orange = 3,
        yellow = 4,
        green = 5,
        blue = 6,
        violet = 7,
        grey = 8,
        white = 9
    }

    public static int ColorCode(string color)
        => (int)(ColorCodes)Enum.Parse(typeof(ColorCodes), color);

    public static string[] Colors() => Enum.GetNames(typeof(ColorCodes));
}
