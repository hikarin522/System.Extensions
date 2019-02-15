using System.Collections.Generic;

namespace System.Linq
{
    public static class HashSetExtensions
    {
#if !AFTER_NETCOREAPP2_0 && !AFTER_NET472
        public static HashSet<T> ToHashSet<T>(this IEnumerable<T> source)
            => new HashSet<T>(source);

        public static HashSet<T> ToHashSet<T>(this IEnumerable<T> source, IEqualityComparer<T> comparer)
            => new HashSet<T>(source, comparer);
#endif
    }
}
