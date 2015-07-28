using RleLwzCompressionLibrary.Algorithms.Interfaces;

namespace RleLwzCompressionLibrary.SimpleFactory
{
    public static class AlgorithmsFactory
    {
        /// <summary>
        /// Create instance for algorithm
        /// </summary>
        /// <typeparam name="T">The class implements the algorithm</typeparam>
        /// <returns></returns>
        public static T CreateInstance<T>() where T : IAlgorithmsCompression, new()
        {
            return new T();
        }
    }
}
