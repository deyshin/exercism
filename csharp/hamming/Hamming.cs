using System;
using System.Linq;

public static class Hamming
{
    public static int Compute(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length)
        { throw new Exception($"Length of the First Strand ({firstStrand.Length}) does not match the Length of the Second Strand ({secondStrand.Length})"); }
        
        //get all posible string positions
        var positions = Enumerable.Range(0, firstStrand.Length);  

        //get the positions where the char's are not equal
        var hammingPositions = positions.Where(p => firstStrand[p] != secondStrand[p]); 

        //return counts of the hamming positions.
        return hammingPositions.Count();
    }
}