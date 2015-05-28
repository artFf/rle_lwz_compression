using System.IO;
using RleLwzCompressionLibrary.Algorithms.Contexts;
using RleLwzCompressionLibrary.Algorithms.Realisations;
using RleLwzCompressionLibrary.Models;
using RleLwzCompressionLibrary.SimpleFactory;
using RleLwzCompressionLibrary.ViewInerfaces;

namespace RleLwzCompressionLibrary.Presenters
{
    public class CompressionPresenter
    {
        private readonly IRleLwzCompressionForm _rleLwzCompression;
        private Picture _picture;

        public CompressionPresenter(IRleLwzCompressionForm rleLwzCompression)
        {
            _rleLwzCompression = rleLwzCompression;

            _rleLwzCompression.ButtonLoadPicture += _rleLwzCompression_ButtonLoadPicture;
            _rleLwzCompression.ButtonShowLogView += _rleLwzCompression_ButtonShowLogView;
            _rleLwzCompression.ButtonEncodePicture += _rleLwzCompression_ButtonEncodePicture;
            _rleLwzCompression.ButtonDecodePicture += _rleLwzCompression_ButtonDecodePicture;
            _rleLwzCompression.ButtonCloseRleLwzCompressionForm+=_rleLwzCompression_ButtonCloseRleLwzCompressionForm;
            _rleLwzCompression.ButtonClearSources += _rleLwzCompression_ButtonClearSources;
        }

        void _rleLwzCompression_ButtonShowLogView()
        {
            _rleLwzCompression.ShowLogView();
        }

        void _rleLwzCompression_ButtonClearSources()
        {
            _rleLwzCompression.ClearSources();
        }

        void _rleLwzCompression_ButtonCloseRleLwzCompressionForm()
        {
            _rleLwzCompression.CloseForm();
        }

        void _rleLwzCompression_ButtonDecodePicture()
        {
            //var compressionsAlgorithms = new Context(new Rle());
            var compressionsAlgorithms = new Context(AlgorithmsFactory.CreateInstance<Rle>());
            var rleDecodedPicture = compressionsAlgorithms.ExuceteDecode(_rleLwzCompression.GetRleEncodedPicture(), (int)_picture.Size);
            _rleLwzCompression.ShowRleDecoded(rleDecodedPicture);

            //compressionsAlgorithms.SetAlgorithm(new Lwz());
            compressionsAlgorithms.SetAlgorithm(AlgorithmsFactory.CreateInstance<Lwz>());
            var lwzDecodedPicture = compressionsAlgorithms.ExuceteDecode(_rleLwzCompression.GetLwzEncodedPicture(),(int)_picture.Size);
            _rleLwzCompression.ShowLwzDecoded(lwzDecodedPicture);
        }

        void _rleLwzCompression_ButtonEncodePicture()
        {
            //var compressionsAlgorithms = new Context(new Rle());
            var compressionsAlgorithms = new Context(AlgorithmsFactory.CreateInstance<Rle>());
            var rleEncodedPicture = compressionsAlgorithms.ExuceteEncode(_picture);
            _rleLwzCompression.ShowRleEncoded(rleEncodedPicture);

            //compressionsAlgorithms.SetAlgorithm(new Lwz());
            compressionsAlgorithms.SetAlgorithm(AlgorithmsFactory.CreateInstance<Lwz>());
            var lwzEncodedPicture = compressionsAlgorithms.ExuceteEncode(_picture);
            _rleLwzCompression.ShowLwzEncoded(lwzEncodedPicture);
        }

        void _rleLwzCompression_ButtonLoadPicture()
        {
            var pathToPicture = _rleLwzCompression.LoadPicture();
            _picture = new Picture
            {
                Path = pathToPicture,
                Name = Path.GetFileName(pathToPicture),
                Size = new FileInfo(pathToPicture).Length
            };
            _rleLwzCompression.ShowPicture(_picture);
        }

        private void PrintToFile()
        {
            
        }
    }
}
