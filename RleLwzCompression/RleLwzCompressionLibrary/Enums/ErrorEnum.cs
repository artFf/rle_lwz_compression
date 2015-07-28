using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RleLwzCompressionLibrary.Enums.Attributes;

namespace RleLwzCompressionLibrary.Enums
{
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
