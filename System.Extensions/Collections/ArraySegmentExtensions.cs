using System.Runtime.CompilerServices;

namespace System
{
    public static class ArraySegment
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ArraySegment<T> Create<T>(T[] array)
            => new ArraySegment<T>(array);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ArraySegment<T> Create<T>(this T[] array, int start, int length)
            => new ArraySegment<T>(array, start, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ArraySegment<T> Empty<T>()
#if AFTER_NETCOREAPP2_0
            => ArraySegment<T>.Empty;
#else
            => new ArraySegment<T>(new T[0]);
#endif
    }
}

namespace System.Linq
{
    public static class ArraySegmentExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ArraySegment<T> AsArraySegment<T>(this T[] array)
#if AFTER_NETCOREAPP2_0
            => array;
#else
            => ArraySegment.Create(array);
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ArraySegment<T> ToArraySegment<T>(this T[] array, int offset, int count)
            => ArraySegment.Create(array, offset, count);
    }
}
