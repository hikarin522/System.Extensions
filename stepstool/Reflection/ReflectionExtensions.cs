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

#if NET || AFTER_NETSTANDARD2_0
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MethodInfo GetMethod(this Type type, string name, BindingFlags bindingAttr, params Type[] types)
            => type.GetMethod(name, bindingAttr, null, types ?? Type.EmptyTypes, null);
#endif
    }
}
