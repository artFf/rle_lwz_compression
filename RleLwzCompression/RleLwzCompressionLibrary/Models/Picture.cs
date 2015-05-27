namespace RleLwzCompressionLibrary.Models
{
    public class Picture
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public long Size { get; set; }
        public byte[] EncodedContents { get; set; }
        public byte[] DecodedContents { get; set; }
        public int[] EncodedIntContents { get; set; }
        public int[] DecodedIntContents { get; set; }
    }
}
