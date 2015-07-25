using System.Collections.Generic;

namespace RleLwzCompressionLibrary.Models
{
    public class Picture
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public long Size { get; set; }
        public List<byte> EncodedContents { get; set; }
        public byte[] DecodedContents { get; set; }
        public List<int> EncodedIntContents { get; set; }
        public int[] DecodedIntContents { get; set; }
    }
}
