using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RleLwzCompressionLibrary.Algorithms.Interfaces;
using RleLwzCompressionLibrary.Models;

namespace RleLwzCompressionLibrary.Algorithms.Contexts
{
    public class Context
    {
        private IAlgorithmsCompression AlgorithmsCompression { get; set; }

        public Context(IAlgorithmsCompression algorithmsCompression)
        {
            AlgorithmsCompression = algorithmsCompression;
        }

        public void SetAlgorithm(IAlgorithmsCompression algorithmsCompression)
        {
            AlgorithmsCompression = algorithmsCompression;
        }

        public Picture ExuceteEncode(Picture picture)
        {
            return AlgorithmsCompression.Encode(picture);
        }

        public Picture ExuceteDecode(Picture picture)
        {
            return AlgorithmsCompression.Decode(picture);
        }
    }
}
