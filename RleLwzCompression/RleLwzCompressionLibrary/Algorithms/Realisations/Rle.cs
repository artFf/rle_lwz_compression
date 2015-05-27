using System.IO;
using RleLwzCompressionLibrary.Algorithms.Interfaces;
using RleLwzCompressionLibrary.Models;

namespace RleLwzCompressionLibrary.Algorithms.Realisations
{
    public class Rle : IAlgorithmsCompression
    {
        public Picture Encode(Picture picture)
        {
            var pictureInbytes = File.ReadAllBytes(picture.Path);
            Picture encodedPicture = new Picture
            {
                EncodedContents = new byte[pictureInbytes.Length*2],
                Name = picture.Name,
                Path = picture.Path
            };

            int ii = 0;
            for (int i = 0; i < pictureInbytes.Length; i++)
            {
                byte currentBytesCount = 1;
                while (currentBytesCount < byte.MaxValue && i + 1 < pictureInbytes.Length && pictureInbytes[i] == pictureInbytes[i + 1])
                {
                    currentBytesCount++;
                    i++;
                }
                encodedPicture.EncodedContents[ii] = currentBytesCount;
                ii++;
                encodedPicture.EncodedContents[ii] = pictureInbytes[i];
                ii++;
            }
            
            encodedPicture.Size = encodedPicture.EncodedContents.Length;
            return encodedPicture;
        }

        public Picture Decode(Picture picture, int size)
        {
            //todo
            var decodedPicture = picture;
            decodedPicture.DecodedContents = new byte[size];
            int step = 0;
            for (int i = 1; i < picture.EncodedContents.Length; i += 2)
            {
                byte currentBytesCount = picture.EncodedContents[i - 1];
                while (currentBytesCount > 0)
                {
                    decodedPicture.DecodedContents[step] = picture.EncodedContents[i];
                    currentBytesCount--;
                    step++;
                }
            }
            return decodedPicture;
        }
    }
}
