using System.Collections.Generic;

namespace RleLwzCompressionLibrary.Models
{
    public class Picture
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public long Size { get; set; }
        public List<string> EncodedContents { get; set; }
        public List<byte> DecodedContents { get; set; }
    }
}
