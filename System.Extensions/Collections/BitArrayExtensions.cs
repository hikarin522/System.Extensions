using System.Collections;
using System.Collections.Generic;

namespace System.Linq
{
    public static class BitArrayExtensions
    {
        public static BitArray ToBitArray(this bool[] source)
            => new BitArray(source);

        public static BitArray ToBitArray(this byte[] source)
            => new BitArray(source);

        public static BitArray ToBitArray(this int[] source)
            => new BitArray(source);

        public static BitArray ToBitArray(this IEnumerable<bool> source)
            => source.ToArray().ToBitArray();

        public static BitArray ToBitArray(this IEnumerable<byte> source)
            => source.ToArray().ToBitArray();

        public static BitArray ToBitArray(this IEnumerable<int> source)
            => source.ToArray().ToBitArray();
    }
}
