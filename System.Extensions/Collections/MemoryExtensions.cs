#if AFTER_NETSTANDARD1_1
using System.Runtime.CompilerServices;

namespace System
{
    public static class Memory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Memory<T> Create<T>(T[] array)
            => new Memory<T>(array);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Memory<T> Create<T>(this T[] array, int start, int length)
            => new Memory<T>(array, start, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Memory<T> Empty<T>()
            => Memory<T>.Empty;
    }
}

namespace System.Linq
{
    public static class MemoryExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Memory<T> AsMemory<T>(this T[] array)
            => array;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Memory<T> AsMemory<T>(this ArraySegment<T> segment)
            => segment;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Memory<T> ToMemory<T>(this T[] array, int start, int length)
            => Memory.Create(array, start, length);
    }
}
#endif
