using System.Collections.Generic;

namespace RleLwzCompressionLibrary.Models
{
    /// <summary>
    /// Model class. Picture for compression 
    /// </summary>
    public class Picture
    {
        /// <summary>
        /// Picture name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Path to picture
        /// </summary>
        public string Path { get; set; }
        
        /// <summary>
        /// Picture size
        /// </summary>
        public long Size { get; set; }
        
        /// <summary>
        /// Encoded picture
        /// </summary>
        public List<string> EncodedContents { get; set; }
        
        /// <summary>
        /// Decoded picture
        /// </summary>
        public List<byte> DecodedContents { get; set; }
    }
}
