using RleLwzCompressionLibrary.Algorithms.Interfaces;
using RleLwzCompressionLibrary.Exceptions;
using RleLwzCompressionLibrary.Models;

namespace RleLwzCompressionLibrary.Algorithms.Contexts
{
    /// <summary>
    /// Context is using a strategy for solving their problems. 
    /// </summary>
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
            try
            {
                return AlgorithmsCompression.Encode(picture);
            }
            catch (AlgorithmsException e)
            {
                throw;
            }
        }

        public Picture ExuceteDecode(Picture picture)
        {
            try
            {
                return AlgorithmsCompression.Decode(picture);
            }
            catch (AlgorithmsException e)
            {
                throw;
            }
        }
    }
}
