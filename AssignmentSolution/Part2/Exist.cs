using System;
using System.Collections.Generic;

public static class ExistExtension
{
    public static bool Exists<T>(this CustomList<T> list, Predicate<T> match)
    {
        foreach (var item in list.GetItems())
        {
            if (match(item)) return true;
        }
        return false;
    }
}
