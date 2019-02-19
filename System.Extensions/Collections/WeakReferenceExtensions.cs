
namespace System
{
    public static class WeakReferenceExtensions
    {
        public static WeakReference<T> GetWeakReference<T>(this T target)
            where T : class
            => new WeakReference<T>(target);

        public static WeakReference<T> GetWeakReference<T>(this T target, bool trackResurrection)
            where T : class
            => new WeakReference<T>(target, trackResurrection);
    }
}
