using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Linq
{
    public static class ReadOnlyCollectionExtensions
    {
        public static ReadOnlyCollection<T> ToReadOnlyCollection<T>(this IList<T> source)
            => new ReadOnlyCollection<T>(source);

        public static ReadOnlyCollection<T> ToReadOnlyCollection<T>(this IEnumerable<T> source)
            => source.ToList().ToReadOnlyCollection();
    }
}
