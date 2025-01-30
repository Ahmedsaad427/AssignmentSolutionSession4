using System;
using System.Collections.Generic;

public static class FindExtension
{
    public static T Find<T>(this CustomList<T> list, Predicate<T> match)
    {
        foreach (var item in list.GetItems())
        {
            if (match(item)) return item;
        }
        return default;
    }
}
