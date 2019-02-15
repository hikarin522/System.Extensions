using System.Collections.Generic;

namespace System.Linq
{
    public static class QueueExtensions
    {
        public static Queue<T> ToQueue<T>(this IEnumerable<T> source)
            => new Queue<T>(source);
    }
}
