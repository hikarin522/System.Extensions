#if AFTER_NETSTANDARD1_3 || AFTER_NET45
using System.Collections.Generic;

namespace System.Runtime.CompilerServices
{
    public static class ConditionalWeakTableExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Add<TKey, TValue>(this ConditionalWeakTable<TKey, TValue> source, KeyValuePair<TKey, TValue> item)
            where TKey : class
            where TValue : class
            => source.Add(item.Key, item.Value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Add<TKey, TValue>(this ConditionalWeakTable<TKey, TValue> source, IEnumerable<KeyValuePair<TKey, TValue>> items)
            where TKey : class
            where TValue : class
        {
            foreach (var item in items)
            {
                source.Add(item);
            }
        }
    }
}

namespace System.Linq
{
    using System.Runtime.CompilerServices;

    public static class ConditionalWeakTableExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ConditionalWeakTable<TKey, TValue> ToConditionalWeakTable<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source)
            where TKey : class
            where TValue : class
#if AFTER_NETCOREAPP2_0
            => new ConditionalWeakTable<TKey, TValue> { source };
#else
        {
            var table = new ConditionalWeakTable<TKey, TValue>();
            table.Add(source);
            return table;
        }
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ConditionalWeakTable<TKey, TValue> ToConditionalWeakTable<TKey, TValue>(this IEnumerable<TValue> source, Func<TValue, TKey> keySelector)
            where TKey : class
            where TValue : class
            => source.SelectKeyValuePair(keySelector).ToConditionalWeakTable();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ConditionalWeakTable<TKey, TValue> ToConditionalWeakTable<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector)
            where TKey : class
            where TValue : class
            => source.SelectKeyValuePair(keySelector, valueSelector).ToConditionalWeakTable();
    }
}
#endif
