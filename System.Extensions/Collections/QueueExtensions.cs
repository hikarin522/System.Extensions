using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq
{
    public static class QueueExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Queue<T> ToQueue<T>(this IEnumerable<T> source)
            => new Queue<T>(source);
    }
}
