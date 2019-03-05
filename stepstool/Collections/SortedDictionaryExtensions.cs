using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq
{
    public static class SortedDictionaryExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>(this IDictionary<TKey, TValue> source)
            => new SortedDictionary<TKey, TValue>(source);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>(this IDictionary<TKey, TValue> source, IComparer<TKey> comparer)
            => new SortedDictionary<TKey, TValue>(source, comparer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>(this IDictionary<TKey, TValue> source, Comparison<TKey> comparison)
            => source.ToSortedDictionary(Comparer<TKey>.Create(comparison));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source)
            => new SortedDictionary<TKey, TValue>() { source };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source, IComparer<TKey> comparer)
            => new SortedDictionary<TKey, TValue>(comparer) { source };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source, Comparison<TKey> comparison)
            => source.ToSortedDictionary(Comparer<TKey>.Create(comparison));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TValue, TKey>(this IEnumerable<TValue> source, Func<TValue, TKey> keySelector)
            => source.SelectKeyValuePair(keySelector).ToSortedDictionary();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TValue, TKey>(this IEnumerable<TValue> source, Func<TValue, TKey> keySelector, IComparer<TKey> comparer)
            => source.SelectKeyValuePair(keySelector).ToSortedDictionary(comparer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TValue, TKey>(this IEnumerable<TValue> source, Func<TValue, TKey> keySelector, Comparison<TKey> comparison)
            => source.SelectKeyValuePair(keySelector).ToSortedDictionary(comparison);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector)
            => source.SelectKeyValuePair(keySelector, valueSelector).ToSortedDictionary();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector, IComparer<TKey> comparer)
            => source.SelectKeyValuePair(keySelector, valueSelector).ToSortedDictionary(comparer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector, Comparison<TKey> comparison)
            => source.SelectKeyValuePair(keySelector, valueSelector).ToSortedDictionary(comparison);
    }
}
