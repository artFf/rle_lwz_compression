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
            EnumDisplayAttribute[] attribs = fieldInfo.GetCustomAttributes(typeof(EnumDisplayAttribute), false) as EnumDisplayAttribute[];
            return attribs != null && attribs.Length > 0 ? attribs[0].EnumDisplay : null;
        }
    }
}
