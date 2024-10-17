using System;
using System.Collections.Generic;
using System.Linq;

namespace Mania.Library;

public static class Linq
{
    public static (IEnumerable<T> matched, IEnumerable<T> notMatched) Partition<T>(
        this IEnumerable<T> source,
        Func<T, bool> predicate
    )
    {
        var groupBySource = source.GroupBy(predicate);

        var matched = groupBySource.FirstOrDefault(m => m.Key == true);
        var notMatched = groupBySource.FirstOrDefault(m => m.Key == false);

        return (matched, notMatched);
    }
}
