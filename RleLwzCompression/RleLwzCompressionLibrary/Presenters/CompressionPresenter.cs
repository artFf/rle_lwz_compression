using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using RleLwzCompressionLibrary.Algorithms.Contexts;
using RleLwzCompressionLibrary.Algorithms.Realisations;
using RleLwzCompressionLibrary.Enums;
using RleLwzCompressionLibrary.Models;
using RleLwzCompressionLibrary.Reporters;
using RleLwzCompressionLibrary.SimpleFactory;
using RleLwzCompressionLibrary.ViewInerfaces;

namespace RleLwzCompressionLibrary.Presenters
{
    public class CompressionPresenter
    {
        private readonly IRleLwzCompressionForm _rleLwzCompression;
        private Picture _picture;
        private Picture _rleEncodedPicture;
        private Picture _lwzEncodedPicture;

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
            _picture = null;
            _rleEncodedPicture = null;
            _lwzEncodedPicture = null;
            _rleLwzCompression.ClearSources();
        }

        void _rleLwzCompression_ButtonCloseRleLwzCompressionForm()
        {
            _rleLwzCompression.CloseForm();
        }

        void _rleLwzCompression_ButtonDecodePicture()
        {
            if (_picture == null || _rleEncodedPicture == null || _lwzEncodedPicture == null)
            {
                _rleLwzCompression.ShowError(ErrorEnum.Decode);
                return;
            }

            var compressionsAlgorithms = new Context(AlgorithmsFactory.CreateInstance<Rle>());
            var rleDecodedPicture = compressionsAlgorithms.ExuceteDecode(_rleLwzCompression.GetRleEncodedPicture(), (int)_picture.Size);
            _rleLwzCompression.ShowRleDecoded(rleDecodedPicture);

            compressionsAlgorithms.SetAlgorithm(AlgorithmsFactory.CreateInstance<Lwz>());
            var lwzDecodedPicture = compressionsAlgorithms.ExuceteDecode(_rleLwzCompression.GetLwzEncodedPicture(),(int)_picture.Size);
            _rleLwzCompression.ShowLwzDecoded(lwzDecodedPicture);
        }

        async void _rleLwzCompression_ButtonEncodePicture()
        {
            if (_picture == null)
            {
                _rleLwzCompression.ShowError(ErrorEnum.Encode);
                return;
            }

            
            //_rleEncodedPicture = compressionsAlgorithms.ExuceteEncode(_picture);
            
            CancellationTokenSource  tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            
            var rleEncodedPicture1 = Task<Picture>.Factory.StartNew(() =>
            //var rleEncodedPicture1 = Task<Picture>.Run(() =>
            {
                var compressionsAlgorithms = new Context(AlgorithmsFactory.CreateInstance<Rle>());
                _rleEncodedPicture = compressionsAlgorithms.ExuceteEncode(_picture);
                return _rleEncodedPicture;
            }, token);


            
            var lwzEncodedPicture1 = Task<Picture>.Factory.StartNew(() =>
            //var rleEncodedPicture1 = Task<Picture>.Run(() =>
            {
                var compressionsAlgorithms = new Context(AlgorithmsFactory.CreateInstance<Lwz>());
                _lwzEncodedPicture = compressionsAlgorithms.ExuceteEncode(_picture);
                return _lwzEncodedPicture;
            }, token);

            await Task.WhenAll(rleEncodedPicture1, lwzEncodedPicture1);

            _rleLwzCompression.ShowRleEncoded(rleEncodedPicture1.Result);
            _rleLwzCompression.ShowLwzEncoded(lwzEncodedPicture1.Result);

            /*compressionsAlgorithms.SetAlgorithm(AlgorithmsFactory.CreateInstance<Lwz>());
            _lwzEncodedPicture = compressionsAlgorithms.ExuceteEncode(_picture);
            _rleLwzCompression.ShowLwzEncoded(_lwzEncodedPicture);*/
        }

        void _rleLwzCompression_ButtonLoadPicture()
        {
            if (_picture != null)
            {
                _rleLwzCompression.ShowError(ErrorEnum.Load);
                return;
            }

            var pathToPicture = _rleLwzCompression.LoadPicture();
            _picture = new Picture
            {
                Path = pathToPicture,
                Name = Path.GetFileName(pathToPicture),
                Size = new FileInfo(pathToPicture).Length
            };
            _rleLwzCompression.ShowPicture(_picture);
        }
    }
}
