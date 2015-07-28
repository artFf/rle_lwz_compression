using System;

namespace RleLwzCompressionLibrary.Enums.Attributes
{
    /// <summary>
    /// Class for enum display attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field, AllowMultiple = false)]
    public class EnumDisplayAttribute : Attribute
    {
        public EnumDisplayAttribute(string stringToDisplay)
        {
            EnumDisplay = stringToDisplay;
        }

        public string EnumDisplay { get; private set; }
    }
}
