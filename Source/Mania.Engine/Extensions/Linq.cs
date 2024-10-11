#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mania.Engine.Extensions;

public static class Linq
{
    public static (IEnumerable<T>? matched, IEnumerable<T>? notMatched) Partition<T>(
        this IEnumerable<T> source,
        Func<T, bool> predicate
    )
    {
        var gropBySource = source.GroupBy(predicate);

        var matched = gropBySource.FirstOrDefault(m => m.Key == true);
        var notMatched = gropBySource.FirstOrDefault(m => m.Key == false);

        return (matched, notMatched);
    }
}
