using System;

namespace LiveAI.FastBlazor.Helpers
{
    internal static class EnumExtensions
    {
        public static string? ToAttributeValue<TEnum>(this TEnum? value) where TEnum : struct, Enum
        {
            if (value == null)
                return null;
            else
                return ToAttributeValue(value.Value);
        }

        public static string? ToAttributeValue<TEnum>(this TEnum value) where TEnum : struct, Enum
        {
            return Enum.GetName<TEnum>(value)?.ToLowerInvariant();
        }
    }
}
