using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq
{
    public static class BitArrayExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BitArray ToBitArray(this bool[] source)
            => new BitArray(source);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BitArray ToBitArray(this byte[] source)
            => new BitArray(source);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BitArray ToBitArray(this int[] source)
            => new BitArray(source);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BitArray ToBitArray(this IEnumerable<bool> source)
            => source.ToArray().ToBitArray();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BitArray ToBitArray(this IEnumerable<byte> source)
            => source.ToArray().ToBitArray();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BitArray ToBitArray(this IEnumerable<int> source)
            => source.ToArray().ToBitArray();
    }
}
