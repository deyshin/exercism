using System;
using System.Linq;

public static class Raindrops
{
    public static string Convert(int number)
    {
        var factorsOfNumber = 
            Enumerable
            .Range(1, number)
            .Where(f => number % f == 0);
        
        //Analize factorsOfNumber & construct string
        var raindrops = string.Empty;

        raindrops += factorsOfNumber.Contains(3) ? "Pling" : string.Empty;
        raindrops += factorsOfNumber.Contains(5) ? "Plang" : string.Empty;
        raindrops += factorsOfNumber.Contains(7) ? "Plong" : string.Empty;
        if (raindrops == string.Empty) { raindrops = number.ToString(); }
        
        return raindrops;
    }
}