﻿using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        return (ulong)Math.Pow(2, n - 1);
    }

    public static ulong Total()
    {
        var t = (ulong)0;
        for(int i = 1; i <= 64; i++)
        { t += Square(i); }

        return t;
    }
}