using System;

public static class Complement
{
    public static string OfDna(string nucleotide)
    {
        var t = 
            nucleotide
            .ToLower()
            .Replace("g", "C")
            .Replace("c", "G")
            .Replace("t", "A")
            .Replace("a", "U");
            
        return t;
    }
}