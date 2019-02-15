
namespace System.Reflection
{
    public static class ReflectionExtensions
    {
        public static T CreateDelegate<T>(this MethodInfo method)
            where T : Delegate
            => (T)method.CreateDelegate(typeof(T));

        public static T CreateDelegate<T>(this MethodInfo method, object target)
            where T : Delegate
            => (T)method.CreateDelegate(typeof(T), target);
    }
}
