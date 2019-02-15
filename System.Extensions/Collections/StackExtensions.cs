using System.Collections.Generic;

namespace System.Linq
{
    public static class StackExtensions
    {
        public static Stack<T> ToStack<T>(this IEnumerable<T> source)
            => new Stack<T>(source);
    }
}
