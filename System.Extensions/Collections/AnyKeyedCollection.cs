using System.Collections.ObjectModel;

namespace System.Collections.Generic
{
    public class AnyKeyedCollection<TKey, TItem>: KeyedCollection<TKey, TItem>
    {
        private Func<TItem, TKey> keySelector { get; }

        public AnyKeyedCollection(Func<TItem, TKey> keySelector)
            : base()
        {
            this.keySelector = keySelector;
        }

        public AnyKeyedCollection(Func<TItem, TKey> keySelector, IEqualityComparer<TKey> comparer)
            : base(comparer)
        {
            this.keySelector = keySelector;
        }

        public AnyKeyedCollection(Func<TItem, TKey> keySelector, IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold)
            : base(comparer, dictionaryCreationThreshold)
        {
            this.keySelector = keySelector;
        }

        protected override sealed TKey GetKeyForItem(TItem item)
            => this.keySelector(item);
    }
}

namespace System.Linq
{
    using System.Collections.Generic;

    public static class KeyedCollectionExtensions
    {
        public static KeyedCollection<TKey, TItem> ToKeyedCollection<TKey, TItem>(this IEnumerable<TItem> source, Func<TItem, TKey> keySelector)
            => new AnyKeyedCollection<TKey, TItem>(keySelector) { source };

        public static KeyedCollection<TKey, TItem> ToKeyedCollection<TKey, TItem>(this IEnumerable<TItem> source, Func<TItem, TKey> keySelector, IEqualityComparer<TKey> comparer)
            => new AnyKeyedCollection<TKey, TItem>(keySelector, comparer) { source };

        public static KeyedCollection<TKey, TItem> ToKeyedCollection<TKey, TItem>(this IEnumerable<TItem> source, Func<TItem, TKey> keySelector, IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold)
            => new AnyKeyedCollection<TKey, TItem>(keySelector, comparer, dictionaryCreationThreshold) { source };
    }
}
