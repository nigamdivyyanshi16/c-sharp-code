// See https://aka.ms/new-console-template for more information
using System;

public class Time
{
    private int hour;
    private int minute;
    private int second;

    public Time(int hour, int minute, int second)
    {
        SetTime(hour, minute, second);
    }

    public void SetHour(int hour)
    {
        if (hour >= 0 && hour < 24)
        {
            this.hour = hour;
        }
    }

    public int GetHour()
    {
        return hour;
    }

    public void SetMinute(int minute)
    {
        if (minute >= 0 && minute < 60)
        {
            this.minute = minute;
        }
    }

    public int GetMinute()
    {
        return minute;
    }

    public void SetSecond(int second)
    {
        if (second >= 0 && second < 60)
        {
            this.second = second;
        }
    }

    public int GetSecond()
    {
        return second;
    }

    public void SetTime(int hour, int minute, int second)
    {
        SetHour(hour);
        SetMinute(minute);
        SetSecond(second);
    }

    public Time NextSecond()
    {
        second++;
        if (second == 60)
        {
            second = 0;
            minute++;
            if (minute == 60)
            {
                minute = 0;
                hour++;
                if (hour == 24)
                {
                    hour = 0;
                }
            }
        }
        return this;
    }

    public Time PreviousSecond()
    {
        second--;
        if (second < 0)
        {
            second = 59;
            minute--;
            if (minute < 0)
            {
                minute = 59;
                hour--;
                if (hour < 0)
                {
                    hour = 23;
                }
            }
        }
        return this;
    }

    public override string ToString()
    {
        return string.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, second);
    }
}

public class TestMain
{
    public static void Main(string[] args)
    {
        // Test constructors and ToString()
        Time t1 = new Time(1, 2, 3);
        Console.WriteLine(t1);  // ToString()

        // Test Setters and Getters
        t1.SetHour(4);
        t1.SetMinute(5);
        t1.SetSecond(6);
        Console.WriteLine(t1);  // ToString()
        Console.WriteLine("Hour: " + t1.GetHour());
        Console.WriteLine("Minute: " + t1.GetMinute());
        Console.WriteLine("Second: " + t1.GetSecond());

        // Test SetTime()
        t1.SetTime(23, 59, 58);
        Console.WriteLine(t1);  // ToString()

        // Test NextSecond();
        Console.WriteLine(t1.NextSecond());
        Console.WriteLine(t1.NextSecond().NextSecond());

        // Test PreviousSecond()
        Console.WriteLine(t1.PreviousSecond());
        Console.WriteLine(t1.PreviousSecond().PreviousSecond());
    }
}

