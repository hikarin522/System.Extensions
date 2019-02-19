using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
    public class AnyKeyedCollection<TKey, TItem>: KeyedCollection<TKey, TItem>
    {
        private Func<TItem, TKey> keySelector { get; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AnyKeyedCollection(Func<TItem, TKey> keySelector)
            : base()
        {
            this.keySelector = keySelector;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AnyKeyedCollection(Func<TItem, TKey> keySelector, IEqualityComparer<TKey> comparer)
            : base(comparer)
        {
            this.keySelector = keySelector;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AnyKeyedCollection(Func<TItem, TKey> keySelector, IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold)
            : base(comparer, dictionaryCreationThreshold)
        {
            this.keySelector = keySelector;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected override sealed TKey GetKeyForItem(TItem item)
            => this.keySelector(item);
    }
}

namespace System.Linq
{
    using System.Collections.Generic;

    public static class KeyedCollectionExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static KeyedCollection<TKey, TItem> ToKeyedCollection<TKey, TItem>(this IEnumerable<TItem> source, Func<TItem, TKey> keySelector)
            => new AnyKeyedCollection<TKey, TItem>(keySelector) { source };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static KeyedCollection<TKey, TItem> ToKeyedCollection<TKey, TItem>(this IEnumerable<TItem> source, Func<TItem, TKey> keySelector, IEqualityComparer<TKey> comparer)
            => new AnyKeyedCollection<TKey, TItem>(keySelector, comparer) { source };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static KeyedCollection<TKey, TItem> ToKeyedCollection<TKey, TItem>(this IEnumerable<TItem> source, Func<TItem, TKey> keySelector, IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold)
            => new AnyKeyedCollection<TKey, TItem>(keySelector, comparer, dictionaryCreationThreshold) { source };
    }
}
