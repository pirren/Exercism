using System;

public class Clock : IEquatable<object>
{
    private const int MinuteRollover = 60;
    private const int HourRollover = 24;
    public int Hours { get; private set; } = 0;
    public int Minutes { get; private set; } = 0;

    public Clock(int hours, int minutes)
    {
        Minutes = minutes % MinuteRollover;
        if(Minutes < 0) {
            Minutes = MinuteRollover + Minutes;
        }

        var hourBorrows = (int)(minutes / MinuteRollover);
        if (minutes < 0 && Minutes != 0)
        {
            hourBorrows--;
        }

        Hours = (hours + hourBorrows) % HourRollover;
        if(Hours < 0) 
        {
            Hours = HourRollover + Hours;
        }
    }

    public Clock Add(int minutesToAdd) => new Clock(Hours, Minutes + minutesToAdd);

    public Clock Subtract(int minutesToSubtract) => new Clock(Hours, Minutes - minutesToSubtract);

    public override string ToString() => Hours.ToString("00") + ":" + Minutes.ToString("00");

    public override bool Equals(object obj) => string.Equals(ToString(), obj.ToString());
}
