#if AFTER_NETSTANDARD1_1
using System.Runtime.CompilerServices;

namespace System
{
    public static class Span
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Span<T> Create<T>(T[] array)
            => new Span<T>(array);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Span<T> Create<T>(this T[] array, int start, int length)
            => new Span<T>(array, start, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Span<T> Empty<T>()
            => Span<T>.Empty;
    }
}

namespace System.Linq
{
    public static class SpanExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Span<T> AsSpan<T>(this T[] array)
            => array;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Span<T> AsSpan<T>(this ArraySegment<T> segment)
            => segment;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Span<T> ToSpan<T>(this T[] array, int start, int length)
            => Span.Create(array, start, length);
    }
}
#endif
