using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq
{
    public static class LinkedListExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LinkedList<T> ToLinkedList<T>(this IEnumerable<T> source)
            => new LinkedList<T>(source);
    }
}
