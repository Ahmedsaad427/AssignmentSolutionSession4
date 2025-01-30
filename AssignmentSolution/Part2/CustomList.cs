using System;
using System.Collections.Generic;

public class CustomList<T>
{
    private List<T> items = new List<T>();

    public void Add(T item) => items.Add(item);
    public int Count => items.Count;
    public T this[int index] => items[index];

    public List<T> GetItems() => items;
}
