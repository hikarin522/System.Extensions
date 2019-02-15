using System.Collections.Generic;

namespace System.Linq
{
    public static class LinkedListExtensions
    {
        public static LinkedList<T> ToLinkedList<T>(this IEnumerable<T> source)
            => new LinkedList<T>(source);
    }
}
