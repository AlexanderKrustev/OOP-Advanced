﻿namespace _08.CustomList
{
    using System.Collections.Generic;

    public interface ICustomList<T>: IEnumerable<T>
    { 
        void Add(T item);

        T Remove(int index);

        bool Contains(T element);

        void Swap(int index1, int index2);

        int CountGreaterThan(T element);

        T Max();

        T Min();

        void Sort();
    }
}
