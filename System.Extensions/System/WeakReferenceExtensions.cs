using System.Runtime.CompilerServices;

namespace System
{
    public static class WeakReferenceExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WeakReference<T> GetWeakReference<T>(this T target)
            where T : class
            => new WeakReference<T>(target);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WeakReference<T> GetWeakReference<T>(this T target, bool trackResurrection)
            where T : class
            => new WeakReference<T>(target, trackResurrection);
    }
}
