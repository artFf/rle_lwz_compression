using System;

namespace RleLwzCompressionLibrary.Enums.Attributes
{
    public class EnumDisplayAttribute : Attribute
    {
        public EnumDisplayAttribute(string stringToDisplay)
        {
            EnumDisplay = stringToDisplay;
        }

        public string EnumDisplay { get; set; }
    }
}
