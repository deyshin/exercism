using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        var az = 
            Enumerable
            .Range('a','z' - 'a')   //ASCII int values
            .Select(a => (char)a)   //convert to char
            .ToList();   
        
        var t =
			Regex.Replace(input, @"\s", string.Empty)   //remove whitespace
            .ToLower()              //unify char case
			.Distinct()             //remove duplicate
			.OrderBy(r => r)        //ascending alphabetical order
            .ToList();
        
        return az.Except(t).Count() == 0;
    }
}
