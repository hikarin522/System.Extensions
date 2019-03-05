#if AFTER_NETSTANDARD2_0 || AFTER_NET45
using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace System
{
    public static class BitVector32Extensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BitVector32 ToBitVector32(this int data)
            => new BitVector32(data);
    }
}
#endif
