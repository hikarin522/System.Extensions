#if AFTER_NETSTANDARD1_1
using System.Runtime.CompilerServices;

namespace System
{
    public static class Memory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Memory<T> Empty<T>()
            => Memory<T>.Empty;
    }
}
#endif
