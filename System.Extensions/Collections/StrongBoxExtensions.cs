using System.Runtime.CompilerServices;

namespace System
{
    public static class StrongBoxExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StrongBox<T> ToStrongBox<T>(this T target)
            => new StrongBox<T>(target);
    }
}
