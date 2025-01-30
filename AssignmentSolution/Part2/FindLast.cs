using System;
using System.Collections.Generic;

public static class FindLastExtension
{
    public static T FindLast<T>(this CustomList<T> list, Predicate<T> match)
    {
        for (int i = list.Count - 1; i >= 0; i--)
        {
            if (match(list[i])) return list[i];
        }
        return default;
    }
}
