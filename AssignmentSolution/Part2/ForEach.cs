using System;
using System.Collections.Generic;

public static class ForEachExtension
{
    public static void ForEach<T>(this CustomList<T> list, Action<T> action)
    {
        foreach (var item in list.GetItems())
        {
            action(item);
        }
    }
}
