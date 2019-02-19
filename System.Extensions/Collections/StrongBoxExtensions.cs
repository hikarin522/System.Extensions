using System.Runtime.CompilerServices;

namespace System
{
    public static class StrongBoxExtensions
    {
        public static StrongBox<T> ToStrongBox<T>(this T target)
            => new StrongBox<T>(target);
    }
}
