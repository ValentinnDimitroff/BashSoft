namespace BashSoft.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface ISimpleOrderedBag<T> : IEnumerable<T> where T : IComparable<T>
    {
        int Capacity { get; }

        int Size { get; }

        void Add(T element);

        void AddAll(ICollection<T> collection);

        bool Remove(T element);

        string JoinWith(string joiner);
    }
}

