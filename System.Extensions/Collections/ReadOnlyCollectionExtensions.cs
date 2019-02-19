using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace System.Linq
{
    public static class ReadOnlyCollectionExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlyCollection<T> ToReadOnlyCollection<T>(this IList<T> source)
            => new ReadOnlyCollection<T>(source);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlyCollection<T> ToReadOnlyCollection<T>(this IEnumerable<T> source)
#if AFTER_NETSTANDARD2_0 || AFTER_NET45
            => new ReadOnlyCollectionBuilder<T>(source).ToReadOnlyCollection();
#else
            => source.ToList().ToReadOnlyCollection();
#endif
    }
}
