using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public static partial class ListExtensions
{
    public static int AddAndReturnIndex<T>(this List<T> list, T item)
    {
        list.Add(item);
        return list.Count - 1;
    }

    public static T AddAndReturnItem<T>(this List<T> list, T item)
    {
        list.AddAndReturnIndex(item);
        return list[list.AddAndReturnIndex(item)];
    }

    public static T RemoveAtAndReturnItem<T>(this List<T> list, int index)
    {
        var item = list[index];
        list.RemoveAt(index);
        return item;
    }
}

