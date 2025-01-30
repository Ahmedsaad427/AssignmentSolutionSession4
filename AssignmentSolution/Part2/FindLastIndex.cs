using System;
using System.Collections.Generic;

public static class FindLastIndexExtension
{
    public static int FindLastIndex<T>(this CustomList<T> list, Predicate<T> match)
    {
        for (int i = list.Count - 1; i >= 0; i--)
        {
            if (match(list[i])) return i;
        }
        return -1;
    }
}
