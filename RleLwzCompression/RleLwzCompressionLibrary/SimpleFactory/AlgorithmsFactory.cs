using RleLwzCompressionLibrary.Algorithms.Interfaces;

namespace RleLwzCompressionLibrary.SimpleFactory
{
    public static class AlgorithmsFactory
    {
        public static T CreateInstance<T>() where T : IAlgorithmsCompression, new()
        {
            return new T();
        }
    }
}
