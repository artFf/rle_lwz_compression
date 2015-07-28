using System;
using System.Reflection;
using RleLwzCompressionLibrary.Enums.Attributes;

namespace RleLwzCompressionLibrary.Enums.Extenstions
{
    /// <summary>
    /// Class for enumm extenstion
    /// </summary>
    public static class EnumExtenstionClass
    {
        /// <summary>
        /// Extension method for getting EnumDisplayAttribute
        /// </summary>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static string GetStringValue(this Enum value)
        {
            Type type = value.GetType();
            FieldInfo fieldInfo = type.GetField(value.ToString());            
            EnumDisplayAttribute[] attribs = fieldInfo.GetCustomAttributes(typeof(EnumDisplayAttribute), false) as EnumDisplayAttribute[];
            return attribs != null && attribs.Length > 0 ? attribs[0].EnumDisplay : null;
        }
    }
}
