using System.Collections.Generic;

namespace System.Linq
{
    public static class DictionaryExtensions
    {
        public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source)
#if AFTER_NETCOREAPP2_0
            => new Dictionary<TKey, TValue>(source);
#else
            => new Dictionary<TKey, TValue> { source };
#endif

        public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source, IEqualityComparer<TKey> comparer)
#if AFTER_NETCOREAPP2_0
            => new Dictionary<TKey, TValue>(source, comparer);
#else
            => new Dictionary<TKey, TValue>(comparer) { source };
#endif
    }
}
