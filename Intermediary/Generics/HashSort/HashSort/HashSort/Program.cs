using System.Collections.Generic;
using System;
class Program
{
    static void Main(string[] args)
    {
        SortedSet<int> a = new SortedSet<int>() { 0, 2, 5, 7, 9 };
        SortedSet<int> b = new SortedSet<int>() { 3, 6, 8, 10 };

        SortedSet<int> c = new SortedSet<int>(a);
        c.UnionWith(b);
        printCollection(c);

        SortedSet<int> d = new SortedSet<int>(a);
        d.IntersectWith(b);
        printCollection(d);

        SortedSet<int> e = new SortedSet<int>(a);
        e.ExceptWith(b);
        printCollection(e);
    }

    static void printCollection<T>(IEnumerable<T> collection)
    {
        foreach (T obj in collection)
        {
            Console.Write(obj + " ");
        }
        Console.WriteLine();
    }
}