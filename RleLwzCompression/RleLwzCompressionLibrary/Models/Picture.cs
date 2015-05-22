using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RleLwzCompressionLibrary.Models
{
    public class Picture
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public long Size { get; set; }
        public byte[] EncodedContents { get; set; }
        public byte[] DecodedContents { get; set; }
    }
}
