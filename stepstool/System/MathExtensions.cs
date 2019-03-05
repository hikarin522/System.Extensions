using System.Runtime.CompilerServices;

namespace System
{
    public static class MathExtensions
    {
        #region Abs
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Abs(this sbyte value)
            => Math.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Abs(this short value)
            => Math.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Abs(this int value)
            => Math.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Abs(this long value)
            => Math.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Abs(this float value)
#if AFTER_NETCOREAPP2_0
            => MathF.Abs(value);
#else
            => Math.Abs(value);
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Abs(this double value)
            => Math.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal Abs(this decimal value)
            => Math.Abs(value);
        #endregion

        #region Clamp
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Clamp(this sbyte value, sbyte min, sbyte max)
#if AFTER_NETCOREAPP2_0
            => Math.Clamp(value, min, max);
#else
            => Math.Max(min, Math.Min(max, value));
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Clamp(this byte value, byte min, byte max)
#if AFTER_NETCOREAPP2_0
            => Math.Clamp(value, min, max);
#else
            => Math.Max(min, Math.Min(max, value));
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Clamp(this short value, short min, short max)
#if AFTER_NETCOREAPP2_0
            => Math.Clamp(value, min, max);
#else
            => Math.Max(min, Math.Min(max, value));
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort Clamp(this ushort value, ushort min, ushort max)
#if AFTER_NETCOREAPP2_0
            => Math.Clamp(value, min, max);
#else
            => Math.Max(min, Math.Min(max, value));
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Clamp(this int value, int min, int max)
#if AFTER_NETCOREAPP2_0
            => Math.Clamp(value, min, max);
#else
            => Math.Max(min, Math.Min(max, value));
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Clamp(this uint value, uint min, uint max)
#if AFTER_NETCOREAPP2_0
            => Math.Clamp(value, min, max);
#else
            => Math.Max(min, Math.Min(max, value));
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Clamp(this long value, long min, long max)
#if AFTER_NETCOREAPP2_0
            => Math.Clamp(value, min, max);
#else
            => Math.Max(min, Math.Min(max, value));
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Clamp(this ulong value, ulong min, ulong max)
#if AFTER_NETCOREAPP2_0
            => Math.Clamp(value, min, max);
#else
            => Math.Max(min, Math.Min(max, value));
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Clamp(this float value, float min, float max)
#if AFTER_NETCOREAPP2_0
            => Math.Clamp(value, min, max);
#else
            => Math.Max(min, Math.Min(max, value));
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Clamp(this double value, double min, double max)
#if AFTER_NETCOREAPP2_0
            => Math.Clamp(value, min, max);
#else
            => Math.Max(min, Math.Min(max, value));
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal Clamp(this decimal value, decimal min, decimal max)
#if AFTER_NETCOREAPP2_0
            => Math.Clamp(value, min, max);
#else
            => Math.Max(min, Math.Min(max, value));
#endif
        #endregion

        #region Ceiling
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Ceiling(this float value)
#if AFTER_NETCOREAPP2_0
            => MathF.Ceiling(value);
#else
            => (float)Math.Ceiling(value);
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Ceiling(this double value)
            => Math.Ceiling(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal Ceiling(this decimal value)
            => Math.Ceiling(value);
        #endregion

        #region Floor
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Floor(this float value)
#if AFTER_NETCOREAPP2_0
            => MathF.Floor(value);
#else
            => (float)Math.Floor(value);
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Floor(this double value)
            => Math.Floor(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal Floor(this decimal value)
            => Math.Floor(value);
        #endregion

        #region Truncate
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Truncate(this float value)
#if AFTER_NETCOREAPP2_0
            => MathF.Truncate(value);
#else
            => (float)Math.Truncate(value);
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Truncate(this double value)
            => Math.Floor(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal Truncate(this decimal value)
            => Math.Floor(value);
        #endregion

        #region Round
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(this float value)
#if AFTER_NETCOREAPP2_0
            => MathF.Round(value);
#else
            => (float)Math.Round(value);
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(this float value, int digits)
#if AFTER_NETCOREAPP2_0
            => MathF.Round(value, digits);
#else
            => (float)Math.Round(value, digits);
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(this float value, MidpointRounding mode)
#if AFTER_NETCOREAPP2_0
            => MathF.Round(value, mode);
#else
            => (float)Math.Round(value, mode);
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(this float value, int digits, MidpointRounding mode)
#if AFTER_NETCOREAPP2_0
            => MathF.Round(value, digits, mode);
#else
            => (float)Math.Round(value, digits, mode);
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Round(this double value)
            => Math.Round(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Round(this double value, int digits)
            => Math.Round(value, digits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Round(this double value, MidpointRounding mode)
            => Math.Round(value, mode);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Round(this double value, int digits, MidpointRounding mode)
            => Math.Round(value, digits, mode);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal Round(this decimal value)
            => Math.Round(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal Round(this decimal value, int decimals)
            => Math.Round(value, decimals);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal Round(this decimal value, MidpointRounding mode)
            => Math.Round(value, mode);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal Round(this decimal value, int decimals, MidpointRounding mode)
            => Math.Round(value, decimals, mode);
        #endregion

        #region IsNaN
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNaN(this float value)
            => float.IsNaN(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNaN(this double value)
            => double.IsNaN(value);
        #endregion

        #region IsInfinity
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinity(this float value)
            => float.IsInfinity(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinity(this double value)
            => double.IsInfinity(value);
        #endregion

        #region IsNegativeInfinity
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegativeInfinity(this float value)
            => float.IsNegativeInfinity(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegativeInfinity(this double value)
            => double.IsNegativeInfinity(value);
        #endregion

        #region IsPositiveInfinity
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsPositiveInfinity(this float value)
            => float.IsPositiveInfinity(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsPositiveInfinity(this double value)
            => double.IsPositiveInfinity(value);
        #endregion

        #region IsFinite
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFinite(this float value)
#if AFTER_NETCOREAPP2_1
            => float.IsFinite(value);
#else
            => !value.IsNaN() && !value.IsInfinity();
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFinite(this double value)
#if AFTER_NETCOREAPP2_1
            => double.IsFinite(value);
#else
            => !value.IsNaN() && !value.IsInfinity();
#endif
        #endregion
    }
}
