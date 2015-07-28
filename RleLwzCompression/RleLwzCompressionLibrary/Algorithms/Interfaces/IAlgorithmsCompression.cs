using RleLwzCompressionLibrary.Models;

namespace RleLwzCompressionLibrary.Algorithms.Interfaces
{
    /// <summary>
    /// Class implements a specific strategy should inherit this interface
    /// Context class uses this interface to call a specific strategy
    /// </summary>
    public interface IAlgorithmsCompression
    {
        /// <summary>
        /// Encodes the picture.
        /// </summary>
        /// <param name="picture">Picture</param>
        /// <returns></returns>
        Picture Encode(Picture picture);

        /// <summary>
        /// Decodes the picture.
        /// </summary>
        /// <param name="picture">Picture</param>
        /// <returns></returns>
        Picture Decode(Picture picture);
    }
}
