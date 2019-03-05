using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq
{
    public static class SortedSetExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedSet<T> ToSortedSet<T>(this IEnumerable<T> source)
            => new SortedSet<T>(source);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedSet<T> ToSortedSet<T>(this IEnumerable<T> source, IComparer<T> comparer)
            => new SortedSet<T>(source, comparer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedSet<T> ToSortedSet<T>(this IEnumerable<T> source, Comparison<T> comparison)
            => new SortedSet<T>(source, Comparer<T>.Create(comparison));
    }
}
