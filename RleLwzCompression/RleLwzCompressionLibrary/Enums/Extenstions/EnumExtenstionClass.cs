using System;
using System.Reflection;
using RleLwzCompressionLibrary.Enums.Attributes;

namespace RleLwzCompressionLibrary.Enums.Extenstions
{
    public static class EnumExtenstionClass
    {
        public static string GetStringValue(this Enum value)
        {
            Type type = value.GetType();
            FieldInfo fieldInfo = type.GetField(value.ToString());
            // Get the stringvalue attributes
            EnumDisplayAttribute[] attribs = fieldInfo.GetCustomAttributes(
                 typeof(EnumDisplayAttribute), false) as EnumDisplayAttribute[];
            // Return the first if there was a match.
            return attribs != null && attribs.Length > 0 ? attribs[0].EnumDisplay : null;
        }
    }
}
