using System;
using System.Collections.Generic;
using System.Linq;

public static class AccumulateExtensions
{
    
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        // original answer that does NOT lazy loads
        // var accumulated = new List<U>();
        // foreach (var e in collection)
        // { accumulated.Add(func(e)); }

        return collection.Select(i => func(i));
    }
}