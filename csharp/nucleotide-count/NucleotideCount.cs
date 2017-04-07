using System;
using System.Collections.Generic;

public class DNA
{
    private char[] sequence { get; set; }
    private List<char> ValidNucleotide;

    public DNA(string seq)
    {
        sequence = seq.ToCharArray();
        ValidNucleotide = new List<char> { 'A', 'T', 'C', 'G' };
    }

    public IDictionary<char, int> NucleotideCounts
    {
        get
        {
            var nc = new Dictionary<char, int>
            {
                {'A', Count('A')},
                {'T', Count('T')},
                {'C', Count('C')},
                {'G', Count('G')},
            };

            return nc;
        }
    }

    public int Count(char nucleotide)
    {
        if (ValidNucleotide.Contains(nucleotide) == false)
        { throw new InvalidNucleotideException(); }

        var count = 0;
        foreach (var n in sequence)
        { if (n == nucleotide) { count++; } }

        return count;
    }
}

public class InvalidNucleotideException : Exception { }
