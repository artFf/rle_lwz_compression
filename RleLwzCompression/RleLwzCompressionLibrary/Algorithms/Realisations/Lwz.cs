using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using RleLwzCompressionLibrary.Algorithms.Interfaces;
using RleLwzCompressionLibrary.Models;

namespace RleLwzCompressionLibrary.Algorithms.Realisations
{
    public class Lwz : IAlgorithmsCompression
    {
        //http://rosettacode.org/wiki/LZW_compression#C.23
        public Picture Encode(Picture picture)
        {
            var pictureInbytes = File.ReadAllBytes(picture.Path);
            Picture encodedPicture = new Picture
            {
                EncodedContents = new List<string>(),
                Name = picture.Name,
                Path = picture.Path
            };

            string uncompressed = ConvertByteArrayToString(pictureInbytes);
            
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            for (int i = 0; i < 256; i++)
                dictionary.Add(((char)i).ToString(), i);

            string w = string.Empty;
            List<string> compressed = new List<string>();

            foreach (char c in uncompressed)
            {
                string wc = w + c;
                if (dictionary.ContainsKey(wc))
                {
                    w = wc;
                }
                else
                {
                    compressed.Add(dictionary[w].ToString());
                    dictionary.Add(wc, dictionary.Count);
                    w = c.ToString();
                }
            }

            if (!string.IsNullOrEmpty(w))
                compressed.Add(dictionary[w].ToString());

            encodedPicture.EncodedContents = compressed.ToList();
            encodedPicture.Size = encodedPicture.EncodedContents.Count;
            return encodedPicture;
        }

        public Picture Decode(Picture picture, int size)
        {
            //todo
            var decodedPicture = picture;
            decodedPicture.DecodedContents = new List<byte>();

            List<string> compressed = picture.EncodedContents.ToList();
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            for (int i = 0; i < 256; i++)
                dictionary.Add(i, ((char)i).ToString());

            string w = dictionary[Convert.ToInt32(compressed[0])];
            compressed.RemoveAt(0);
            StringBuilder decompressed = new StringBuilder(w);
            foreach (string k in compressed)
            {
                int kInt = Convert.ToInt32(k);
                string entry = string.Empty;
                if (dictionary.ContainsKey(kInt))
                    entry = dictionary[kInt];
                else if (kInt == dictionary.Count)
                    entry = w + w[0];

                decompressed.Append(entry);
                dictionary.Add(dictionary.Count, w + entry[0]);
                w = entry;
            }
            string sstr = decompressed.ToString();
            decodedPicture.DecodedContents = ConvertStringToByteArray(sstr);
            return decodedPicture;
        }

        private List<byte> ConvertStringToByteArray(string strByteImage)
        {
            string[] split = strByteImage.Split(' ');
            return (from s in split where s.Trim() != string.Empty select Byte.Parse(s)).ToList();
        }

        private string ConvertByteArrayToString(byte[] image)
        {
            return string.Join(" ", image.Select(i => i));
        }
    }
}
