using System.Collections.Generic;

namespace System.Linq
{
    public static class SortedSetExtensions
    {
        public static SortedSet<T> ToSortedSet<T>(this IEnumerable<T> source)
            => new SortedSet<T>(source);

        public static SortedSet<T> ToSortedSet<T>(this IEnumerable<T> source, IComparer<T> comparer)
            => new SortedSet<T>(source, comparer);

        public static SortedSet<T> ToSortedSet<T>(this IEnumerable<T> source, Comparison<T> comparison)
            => new SortedSet<T>(source, Comparer<T>.Create(comparison));
    }
}
