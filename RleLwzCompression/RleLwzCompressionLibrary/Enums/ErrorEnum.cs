using RleLwzCompressionLibrary.Enums.Attributes;

namespace RleLwzCompressionLibrary.Enums
{
    /// <summary>
    /// error types
    /// </summary>
    public enum ErrorEnum
    {
        [EnumDisplay("Please load picture to encode.")]
        Encode,
        [EnumDisplay("Please encode picture befor decode.")]
        Decode,
        [EnumDisplay("Nothin to clear")]
        Clear,
        [EnumDisplay("Please clear resources before new load")]
        Load
    }
}
