using System;
using System.Collections.Generic;

public static class FindAllExtension
{
    public static List<T> FindAll<T>(this CustomList<T> list, Predicate<T> match)
    {
        List<T> result = new List<T>();
        foreach (var item in list.GetItems())
        {
            if (match(item)) result.Add(item);
        }
        return result;
    }
}
