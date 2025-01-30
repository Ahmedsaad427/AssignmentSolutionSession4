using System;
using System.Collections.Generic;

public static class FindIndexExtension
{
    public static int FindIndex<T>(this CustomList<T> list, Predicate<T> match)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (match(list[i])) return i;
        }
        return -1;
    }
}
