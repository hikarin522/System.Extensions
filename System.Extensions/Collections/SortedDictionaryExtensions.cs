using System.Collections.Generic;

namespace System.Linq
{
    public static class SortedDictionaryExtensions
    {
        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>(this IDictionary<TKey, TValue> source)
            => new SortedDictionary<TKey, TValue>(source);

        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>(this IDictionary<TKey, TValue> source, IComparer<TKey> comparer)
            => new SortedDictionary<TKey, TValue>(source, comparer);

        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>(this IDictionary<TKey, TValue> source, Comparison<TKey> comparison)
            => source.ToSortedDictionary(Comparer<TKey>.Create(comparison));

        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source)
            => new SortedDictionary<TKey, TValue>() { source };

        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source, IComparer<TKey> comparer)
            => new SortedDictionary<TKey, TValue>(comparer) { source };

        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source, Comparison<TKey> comparison)
            => source.ToSortedDictionary(Comparer<TKey>.Create(comparison));

        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TValue, TKey>(this IEnumerable<TValue> source, Func<TValue, TKey> keySelector)
            => source.SelectKeyValuePair(keySelector).ToSortedDictionary();

        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TValue, TKey>(this IEnumerable<TValue> source, Func<TValue, TKey> keySelector, IComparer<TKey> comparer)
            => source.SelectKeyValuePair(keySelector).ToSortedDictionary(comparer);

        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TValue, TKey>(this IEnumerable<TValue> source, Func<TValue, TKey> keySelector, Comparison<TKey> comparison)
            => source.SelectKeyValuePair(keySelector).ToSortedDictionary(comparison);

        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector)
            => source.SelectKeyValuePair(keySelector, valueSelector).ToSortedDictionary();

        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector, IComparer<TKey> comparer)
            => source.SelectKeyValuePair(keySelector, valueSelector).ToSortedDictionary(comparer);

        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector, Comparison<TKey> comparison)
            => source.SelectKeyValuePair(keySelector, valueSelector).ToSortedDictionary(comparison);
    }
}
