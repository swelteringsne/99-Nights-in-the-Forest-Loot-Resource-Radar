// Build: cc61e66b24b4cc71c3fbd249bdf6dd22
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
