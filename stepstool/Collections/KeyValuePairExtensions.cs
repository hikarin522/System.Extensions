using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
#if !AFTER_NETCOREAPP2_0
    public static class KeyValuePair
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static KeyValuePair<TKey, TValue> Create<TKey, TValue>(TKey key, TValue value)
            => new KeyValuePair<TKey, TValue>(key, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct<TKey, TValue>(this KeyValuePair<TKey, TValue> tuple, out TKey key, out TValue value)
        {
            key = tuple.Key;
            value = tuple.Value;
        }
    }
#endif
}

namespace System.Linq
{
    using System.Collections.Generic;

    public static class KeyValuePairExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<KeyValuePair<TKey, TValue>> SelectKeyValuePair<TKey, TValue>(this IEnumerable<TValue> source, Func<TValue, TKey> keySelector)
            => source.Select(e => KeyValuePair.Create(keySelector(e), e));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<KeyValuePair<TKey, TValue>> SelectKeyValuePair<TKey, TValue, TSource>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector)
            => source.Select(e => KeyValuePair.Create(keySelector(e), valueSelector(e)));
    }
}
