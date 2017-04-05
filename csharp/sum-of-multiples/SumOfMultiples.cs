using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int To(IEnumerable<int> multiples, int max)
    {
        var nums = Enumerable.Range(1, max - 1);    //max - 1 removes 'max' itself
        var mults = nums.Where( n => multiples.Any(m => n % m == 0));

        return mults.Sum(); 
    }
}