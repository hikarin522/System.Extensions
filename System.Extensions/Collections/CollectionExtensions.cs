using System.Linq;

namespace System.Collections.Generic
{
    public static class CollectionExtensions
    {
        public static void Add<T>(this ICollection<T> source, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                source.Add(item);
            }
        }

        public static void Add<TKey, TValue>(this IDictionary<TKey, TValue> source, IEnumerable<TValue> items, Func<TValue, TKey> keySelector)
            => source.Add(items.SelectKeyValuePair(keySelector));

        public static void Add<TSource, TKey, TValue>(this IDictionary<TKey, TValue> source, IEnumerable<TSource> items, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector)
            => source.Add(items.SelectKeyValuePair(keySelector, valueSelector));

        public static TValue? TryGetValue<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key)
            where TValue : struct
            => dictionary.TryGetValue(key, out var value) ? value : (TValue?)null;

#if !AFTER_NETCOREAPP2_0
        public static TValue GetValueOrDefault<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key)
            => dictionary.TryGetValue(key, out var value) ? value : default;

        public static TValue GetValueOrDefault<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue)
            => dictionary.TryGetValue(key, out var value) ? value : defaultValue;

        public static bool Remove<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, out TValue value)
            => dictionary.TryGetValue(key, out value) && dictionary.Remove(key);

        public static bool TryAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            if (dictionary.ContainsKey(key))
            {
                return false;
            }

            dictionary.Add(key, value);
            return true;
        }
#endif
    }
}
