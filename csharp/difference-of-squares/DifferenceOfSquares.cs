using System;

public static class Squares
{
    public static int SquareOfSums(int max)
    {
        var sum = 0;

        for (int i = 1; i <= max; i++)
        { sum += i; }

        return (int)Math.Pow(sum, 2);
    }

    public static int SumOfSquares(int max)
    {
        var sum = 0;

        for (int i = 1; i <= max; i++)
        { sum += (int)Math.Pow(i, 2); }

        return sum;
    }

    public static int DifferenceOfSquares(int max)
    {
        return Math.Abs(SumOfSquares(max) - SquareOfSums(max));
    }
}