using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq
{
    public static class DictionaryExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source)
#if AFTER_NETCOREAPP2_0
            => new Dictionary<TKey, TValue>(source);
#else
            => new Dictionary<TKey, TValue> { source };
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source, IEqualityComparer<TKey> comparer)
#if AFTER_NETCOREAPP2_0
            => new Dictionary<TKey, TValue>(source, comparer);
#else
            => new Dictionary<TKey, TValue>(comparer) { source };
#endif
    }
}
