#if AFTER_NETSTANDARD1_1
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace System.Linq
{
    public static class ConcurrentDictionaryExtensions
    {
        public static ConcurrentDictionary<TKey, TValue> ToConcurrentDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source)
            => new ConcurrentDictionary<TKey, TValue>(source);

        public static ConcurrentDictionary<TKey, TValue> ToConcurrentDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source, IEqualityComparer<TKey> comparer)
            => new ConcurrentDictionary<TKey, TValue>(source, comparer);

        public static ConcurrentDictionary<TKey, TValue> ToConcurrentDictionary<TValue, TKey>(this IEnumerable<TValue> source, Func<TValue, TKey> keySelector)
            => source.SelectKeyValuePair(keySelector).ToConcurrentDictionary();

        public static ConcurrentDictionary<TKey, TValue> ToConcurrentDictionary<TValue, TKey>(this IEnumerable<TValue> source, Func<TValue, TKey> keySelector, IEqualityComparer<TKey> comparer)
            => source.SelectKeyValuePair(keySelector).ToConcurrentDictionary(comparer);

        public static ConcurrentDictionary<TKey, TValue> ToConcurrentDictionary<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector)
            => source.SelectKeyValuePair(keySelector, valueSelector).ToConcurrentDictionary();

        public static ConcurrentDictionary<TKey, TValue> ToConcurrentDictionary<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector, IEqualityComparer<TKey> comparer)
            => source.SelectKeyValuePair(keySelector, valueSelector).ToConcurrentDictionary(comparer);
    }
}
#endif
