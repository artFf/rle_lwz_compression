using System;
using RleLwzCompressionLibrary.Models;

namespace RleLwzCompressionLibrary.Algorithms.Interfaces
{
    public interface IAlgorithmsCompression
    {
        Picture Encode(Picture picture);
        Picture Decode(Picture picture, int size);
    }
}
