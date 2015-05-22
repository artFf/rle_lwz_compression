using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using RleLwzCompressionLibrary.Models;

namespace RleLwzCompressionLibrary.Algorithms.Interfaces
{
    public interface IAlgorithmsCompression
    {
        Picture Encode(Picture picture);
        Picture Decode(Picture picture);
    }
}
