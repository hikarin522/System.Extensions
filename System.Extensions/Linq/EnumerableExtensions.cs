using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq
{
    public static class EnumerableExtensions
    {
#if !AFTER_NETSTANDARD1_6 || (NET && !AFTER_NET471)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> Append<T>(this IEnumerable<T> source, T element)
            => source.Concat(new[] { element });

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> Prepend<T>(this IEnumerable<T> source, T element)
            => source.StartWith(element);
#endif

        #region Aggregate
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TAccumulate Aggregate<TItem, TAccumulate>(this IEnumerable<TItem> source, TAccumulate seed, Action<TAccumulate, TItem> func)
            where TAccumulate : class
            => source.Aggregate(seed, (r, e) => { func(r, e); return r; });

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult Aggregate<TItem, TAccumulate, TResult>(this IEnumerable<TItem> source, TAccumulate seed, Action<TAccumulate, TItem> func, Func<TAccumulate, TResult> resultSelector)
            where TAccumulate : class
            => source.Aggregate(seed, (r, e) => { func(r, e); return r; }, resultSelector);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TItem Aggregate<TItem>(this IEnumerable<TItem> source, Func<TItem, Func<TItem, TItem>> funcSelector)
            => source.Aggregate((r, e) => funcSelector(r)(e));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TAccumulate Aggregate<TItem, TAccumulate>(this IEnumerable<TItem> source, TAccumulate seed, Func<TAccumulate, Func<TItem, TAccumulate>> funcSelector)
            => source.Aggregate(seed, (r, e) => funcSelector(r)(e));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TAccumulate Aggregate<TItem, TAccumulate>(this IEnumerable<TItem> source, TAccumulate seed, Func<TAccumulate, Action<TItem>> funcSelector)
            where TAccumulate : class
            => source.Aggregate(seed, (r, e) => funcSelector(r)(e));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult Aggregate<TItem, TAccumulate, TResult>(this IEnumerable<TItem> source, TAccumulate seed, Func<TAccumulate, Func<TItem, TAccumulate>> funcSelector, Func<TAccumulate, TResult> resultSelector)
            => source.Aggregate(seed, (r, e) => funcSelector(r)(e), resultSelector);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult Aggregate<TItem, TAccumulate, TResult>(this IEnumerable<TItem> source, TAccumulate seed, Func<TAccumulate, Action<TItem>> funcSelector, Func<TAccumulate, TResult> resultSelector)
            where TAccumulate : class
            => source.Aggregate(seed, (r, e) => funcSelector(r)(e), resultSelector);
        #endregion

        #region SelectMany
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SelectMany<T>(this IEnumerable<IEnumerable<T>> source)
            => source.SelectMany(e => e);
        #endregion
    }
}
