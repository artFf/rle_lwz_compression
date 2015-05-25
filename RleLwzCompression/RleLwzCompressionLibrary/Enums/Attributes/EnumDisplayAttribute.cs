using System;

namespace RleLwzCompressionLibrary.Enums.Attributes
{
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
