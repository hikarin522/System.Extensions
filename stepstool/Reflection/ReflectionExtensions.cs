using System.Runtime.CompilerServices;

namespace System.Reflection
{
    public static class ReflectionExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T CreateDelegate<T>(this MethodInfo method)
            where T : Delegate
            => (T)method.CreateDelegate(typeof(T));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T CreateDelegate<T>(this MethodInfo method, object target)
            where T : Delegate
            => (T)method.CreateDelegate(typeof(T), target);
    }
}
