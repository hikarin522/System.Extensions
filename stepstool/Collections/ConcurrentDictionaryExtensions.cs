#if AFTER_NETSTANDARD1_1
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq
{
    public static class ConcurrentDictionaryExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ConcurrentDictionary<TKey, TValue> ToConcurrentDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source)
            => new ConcurrentDictionary<TKey, TValue>(source);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ConcurrentDictionary<TKey, TValue> ToConcurrentDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source, IEqualityComparer<TKey> comparer)
            => new ConcurrentDictionary<TKey, TValue>(source, comparer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ConcurrentDictionary<TKey, TValue> ToConcurrentDictionary<TValue, TKey>(this IEnumerable<TValue> source, Func<TValue, TKey> keySelector)
            => source.SelectKeyValuePair(keySelector).ToConcurrentDictionary();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ConcurrentDictionary<TKey, TValue> ToConcurrentDictionary<TValue, TKey>(this IEnumerable<TValue> source, Func<TValue, TKey> keySelector, IEqualityComparer<TKey> comparer)
            => source.SelectKeyValuePair(keySelector).ToConcurrentDictionary(comparer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ConcurrentDictionary<TKey, TValue> ToConcurrentDictionary<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector)
            => source.SelectKeyValuePair(keySelector, valueSelector).ToConcurrentDictionary();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ConcurrentDictionary<TKey, TValue> ToConcurrentDictionary<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector, IEqualityComparer<TKey> comparer)
            => source.SelectKeyValuePair(keySelector, valueSelector).ToConcurrentDictionary(comparer);
    }
}
#endif
