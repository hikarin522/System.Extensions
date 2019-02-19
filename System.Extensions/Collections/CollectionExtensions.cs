using System.Linq;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
    public static class CollectionExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Add<T>(this ICollection<T> source, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                source.Add(item);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Add<TKey, TValue>(this IDictionary<TKey, TValue> source, IEnumerable<TValue> items, Func<TValue, TKey> keySelector)
            => source.Add(items.SelectKeyValuePair(keySelector));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Add<TSource, TKey, TValue>(this IDictionary<TKey, TValue> source, IEnumerable<TSource> items, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector)
            => source.Add(items.SelectKeyValuePair(keySelector, valueSelector));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TValue? TryGetValue<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key)
            where TValue : struct
            => dictionary.TryGetValue(key, out var value) ? value : (TValue?)null;

#if !AFTER_NETCOREAPP2_0
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TValue GetValueOrDefault<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key)
            => dictionary.TryGetValue(key, out var value) ? value : default;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TValue GetValueOrDefault<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue)
            => dictionary.TryGetValue(key, out var value) ? value : defaultValue;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Remove<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, out TValue value)
            => dictionary.TryGetValue(key, out value) && dictionary.Remove(key);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
