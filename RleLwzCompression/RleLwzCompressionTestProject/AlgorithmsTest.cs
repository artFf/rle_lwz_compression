using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RleLwzCompression;
using RleLwzCompressionLibrary.Algorithms.Contexts;
using RleLwzCompressionLibrary.Algorithms.Realisations;
using RleLwzCompressionLibrary.Models;
using RleLwzCompressionLibrary.SimpleFactory;

namespace RleLwzCompressionTestProject
{
    [TestClass]
    public class AlgorithmsTest
    {
        [TestMethod]
        public void TestRleGetEncodedPicture()
        {
            //act
            Context context = new Context(AlgorithmsFactory.CreateInstance<Rle>());
            string pathToPicture = Environment.CurrentDirectory + @"\black-and-white-wallpaper-3.jpg";            
            Picture loadPicture = new Picture();
            Picture encodedPicture = new Picture();
            RleLwzCompressionForm rleLwzCompressionForm = new RleLwzCompressionForm();

            //arrange
            loadPicture = rleLwzCompressionForm.GetPictureInfo(pathToPicture);
            encodedPicture = context.ExuceteEncode(loadPicture);
            //assert
            Assert.IsNotNull(loadPicture);
            Assert.IsNotNull(encodedPicture);
            Assert.IsNull(loadPicture.EncodedContents);
            Assert.IsNull(loadPicture.DecodedContents);
            Assert.IsNotNull(encodedPicture.EncodedContents);
            Assert.IsNull(encodedPicture.DecodedContents);
            Assert.AreEqual(loadPicture.Path,encodedPicture.Path);
            Assert.AreEqual(loadPicture.Name,encodedPicture.Name);
            Assert.AreNotEqual(loadPicture.Size,encodedPicture.Size);
        }

        [TestMethod]
        public void TestLwzGetEncodedPicture()
        {
            //act
            Context context = new Context(AlgorithmsFactory.CreateInstance<Lwz>());
            string pathToPicture = Environment.CurrentDirectory + @"\black-and-white-wallpaper-3.jpg";
            Picture loadPicture = new Picture();
            Picture encodedPicture = new Picture();
            RleLwzCompressionForm rleLwzCompressionForm = new RleLwzCompressionForm();

            //arrange
            loadPicture = rleLwzCompressionForm.GetPictureInfo(pathToPicture);
            encodedPicture = context.ExuceteEncode(loadPicture);
            //assert
            Assert.IsNotNull(loadPicture);
            Assert.IsNotNull(encodedPicture);
            Assert.IsNull(loadPicture.EncodedContents);
            Assert.IsNull(loadPicture.DecodedContents);
            Assert.IsNotNull(encodedPicture.EncodedContents);
            Assert.IsNull(encodedPicture.DecodedContents);
            Assert.AreEqual(loadPicture.Path, encodedPicture.Path);
            Assert.AreEqual(loadPicture.Name, encodedPicture.Name);
            Assert.AreNotEqual(loadPicture.Size, encodedPicture.Size);
        }

        [TestMethod]
        public void TestRleGetDecodedPicture()
        {
            //act
            Context context = new Context(AlgorithmsFactory.CreateInstance<Rle>());
            string pathToPicture = Environment.CurrentDirectory + @"\black-and-white-wallpaper-3.jpg";
            Picture loadPicture = new Picture();
            Picture decodedPicture = new Picture();
            Picture encodedPicture = new Picture();
            RleLwzCompressionForm rleLwzCompressionForm = new RleLwzCompressionForm();

            //arrange
            loadPicture = rleLwzCompressionForm.GetPictureInfo(pathToPicture);
            encodedPicture = context.ExuceteEncode(loadPicture);
            decodedPicture = context.ExuceteDecode(encodedPicture);
            //assert
            Assert.IsNotNull(loadPicture);
            Assert.IsNotNull(decodedPicture);
            Assert.IsNull(loadPicture.EncodedContents);
            Assert.IsNull(loadPicture.DecodedContents);
            Assert.IsNotNull(decodedPicture.EncodedContents);
            Assert.IsNotNull(decodedPicture.DecodedContents);
            Assert.AreEqual(loadPicture.Path, decodedPicture.Path);
            Assert.AreEqual(loadPicture.Name, decodedPicture.Name);
            Assert.AreEqual(loadPicture.Size, decodedPicture.Size);
        }

        [TestMethod]
        public void TestLwzGetDecodedPicture()
        {
            //act
            Context context = new Context(AlgorithmsFactory.CreateInstance<Lwz>());
            string pathToPicture = Environment.CurrentDirectory + @"\black-and-white-wallpaper-3.jpg";
            Picture loadPicture = new Picture();
            Picture decodedPicture = new Picture();
            Picture encodedPicture = new Picture();
            RleLwzCompressionForm rleLwzCompressionForm = new RleLwzCompressionForm();

            //arrange
            loadPicture = rleLwzCompressionForm.GetPictureInfo(pathToPicture);
            encodedPicture = context.ExuceteEncode(loadPicture);
            decodedPicture = context.ExuceteDecode(encodedPicture);
            //assert
            Assert.IsNotNull(loadPicture);
            Assert.IsNotNull(decodedPicture);
            Assert.IsNull(loadPicture.EncodedContents);
            Assert.IsNull(loadPicture.DecodedContents);
            Assert.IsNotNull(decodedPicture.EncodedContents);
            Assert.IsNotNull(decodedPicture.DecodedContents);
            Assert.AreEqual(loadPicture.Path, decodedPicture.Path);
            Assert.AreEqual(loadPicture.Name, decodedPicture.Name);
            Assert.AreEqual(loadPicture.Size, decodedPicture.Size);
        }
    }
}
