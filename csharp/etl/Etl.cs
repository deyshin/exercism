using System;
using System.Collections.Generic;

public static class ETL
{
    public static IDictionary<string, int> Transform(IDictionary<int, IList<string>> old)
    {
        var newDictionary = new Dictionary<string, int>();

        foreach (var score in old)
        {
            foreach(var letter in score.Value)
            { newDictionary.Add(letter.ToLower(), score.Key); }
        }

        return newDictionary;
    }
}