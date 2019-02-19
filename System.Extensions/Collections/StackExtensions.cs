using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq
{
    public static class StackExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Stack<T> ToStack<T>(this IEnumerable<T> source)
            => new Stack<T>(source);
    }
}
