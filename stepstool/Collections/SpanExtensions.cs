#if AFTER_NETSTANDARD1_1
using System.Runtime.CompilerServices;

namespace System
{
    public static class Span
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Span<T> Empty<T>()
            => Span<T>.Empty;
    }
}
#endif
