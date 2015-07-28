using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RleLwzCompression;
using RleLwzCompressionLibrary.Enums;
using RleLwzCompressionLibrary.Models;

namespace RleLwzCompressionTestProject
{
    [TestClass]
    public class PictureTest
    {
        [TestMethod]
        public void TestGetLoadedPictureInfo()
        {
            //act
            string pathToPicture = Environment.CurrentDirectory + @"\black-and-white-wallpaper-3.jpg";
            const int size = 253663;
            Picture testPicture = new Picture();
            RleLwzCompressionForm rleLwzCompressionForm = new RleLwzCompressionForm();

            //arrange
            testPicture = rleLwzCompressionForm.GetPictureInfo(pathToPicture);

            //assert
            Assert.IsNotNull(testPicture);
            Assert.AreEqual(pathToPicture, testPicture.Path);
            Assert.AreEqual("black-and-white-wallpaper-3.jpg", testPicture.Name);
            Assert.AreEqual(size, testPicture.Size);
            Assert.IsNull(testPicture.EncodedContents);
            Assert.IsNull(testPicture.DecodedContents);
        }

        [TestMethod]
        public void TestLoadPicture()
        {
            //act
            string pathToPicture = Environment.CurrentDirectory + @"\black-and-white-wallpaper-3.jpg";
            string pathToLoadedPicture = string.Empty;
            RleLwzCompressionForm rleLwzCompressionForm = new RleLwzCompressionForm();

            //arrange
            pathToLoadedPicture = rleLwzCompressionForm.LoadPicture();

            //assert
            Assert.IsNotNull(pathToLoadedPicture);
            Assert.AreEqual(pathToPicture, pathToLoadedPicture);
        }
    }
}
