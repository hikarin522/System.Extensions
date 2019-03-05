#if AFTER_NETSTANDARD1_1
using System.Runtime.CompilerServices;

namespace System
{
    public static class ReadOnlyMemory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlyMemory<T> Empty<T>()
            => ReadOnlyMemory<T>.Empty;
    }

    /// <summary>
    /// <see cref="MemoryExtensions"/>
    /// </summary>
    public static class ReadOnlyMemoryExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlyMemory<T> AsReadOnlyMemory<T>(this Memory<T> memory)
            => memory;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlyMemory<T> AsReadOnlyMemory<T>(this Memory<T> memory, int start)
            => memory.Slice(start);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlyMemory<T> AsReadOnlyMemory<T>(this Memory<T> memory, int start, int length)
            => memory.Slice(start, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlyMemory<T> AsReadOnlyMemory<T>(this T[] array)
            => array;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlyMemory<T> AsReadOnlyMemory<T>(this T[] array, int start)
            => array.AsMemory(start);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlyMemory<T> AsReadOnlyMemory<T>(this T[] array, int start, int length)
            => array.AsMemory(start, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlyMemory<T> AsReadOnlyMemory<T>(this ArraySegment<T> segment)
            => segment;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlyMemory<T> AsReadOnlyMemory<T>(this ArraySegment<T> segment, int start)
            => segment.AsMemory(start);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlyMemory<T> AsReadOnlyMemory<T>(this ArraySegment<T> segment, int start, int length)
            => segment.AsMemory(start, length);
    }
}
#endif
