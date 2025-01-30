using System;
using System.Collections.Generic;

public static class TrueForAllExtension
{
    public static bool TrueForAll<T>(this CustomList<T> list, Predicate<T> match)
    {
        foreach (var item in list.GetItems())
        {
            if (!match(item)) return false;
        }
        return true;
    }
}
