using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RleLwzCompressionLibrary.Algorithms.Interfaces;
using RleLwzCompressionLibrary.Models;

namespace RleLwzCompressionLibrary.Algorithms.Realisations
{
    public class Lwz : IAlgorithmsCompression
    {
        public Picture Encode(Picture picture)
        {
            var pictureInbytes = File.ReadAllBytes(picture.Path);
            Picture encodedPicture = new Picture
            {
                EncodedContents = new byte[pictureInbytes.Length],
                Name = picture.Name,
                Path = picture.Path
            };
            string byteArrayInString = pictureInbytes.ToString();
            int dictionarySize = 256;
            var dictionary = new Dictionary<string, int>();
            int[] resultCode = new int[pictureInbytes.Length];
            string codePosition = "";
            for (int i = 0; i < dictionarySize; i++)
            {
                dictionary.Add(((char)i).ToString(), i);
            }
            int lastStep = 0;
            for (int i = 0; i < byteArrayInString.Length; i++)
            {
                char simvol = (char)byteArrayInString[i];
                string wc = codePosition + simvol;
                if (dictionary.ContainsKey(wc))
                {
                    codePosition = wc;
                }
                else
                {
                    resultCode[i] = (dictionary[codePosition]);
                    dictionary.Add(wc, dictionarySize++);
                    codePosition = "" + simvol;
                }
                lastStep = i + 1;
            }
            if (codePosition != "")
            {
                resultCode[lastStep] = dictionary[codePosition];
            }
            //return resultCode.ToArray();
            return encodedPicture;
        }

        public Picture Decode(Picture picture, int size)
        {
            throw new NotImplementedException();
        }
    }
}
