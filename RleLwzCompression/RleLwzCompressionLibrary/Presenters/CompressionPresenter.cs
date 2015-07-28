using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using RleLwzCompressionLibrary.Algorithms.Contexts;
using RleLwzCompressionLibrary.Algorithms.Realisations;
using RleLwzCompressionLibrary.Enums;
using RleLwzCompressionLibrary.Enums.Extenstions;
using RleLwzCompressionLibrary.Exceptions;
using RleLwzCompressionLibrary.Models;
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
        private static readonly CancellationTokenSource TokenSource = new CancellationTokenSource();
        private readonly CancellationToken _token = TokenSource.Token;

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

        async void _rleLwzCompression_ButtonDecodePicture()
        {
            try
            {
                if (_picture == null || _rleEncodedPicture == null || _lwzEncodedPicture == null)
                {
                    _rleLwzCompression.ShowError(ErrorEnum.Decode.GetStringValue());
                    return;
                }

                if (_rleEncodedPicture != null && _lwzEncodedPicture != null &&
                    _rleEncodedPicture.DecodedContents != null && _lwzEncodedPicture.DecodedContents != null)
                {
                    _rleLwzCompression.ShowError("Pictures are decoded.");
                    return;
                }


                var rleDecodedPicture = CreateTask(new Context(AlgorithmsFactory.CreateInstance<Rle>()),
                    OperationEnum.Decode, AlgorithmEnum.Rle);
                var lwzDecodedPicture = CreateTask(new Context(AlgorithmsFactory.CreateInstance<Lwz>()),
                    OperationEnum.Decode, AlgorithmEnum.Lwz);

                _rleLwzCompression.ShowLoader(AlgorithmEnum.Rle, true, OperationEnum.Decode);
                _rleLwzCompression.ShowLoader(AlgorithmEnum.Lwz, true, OperationEnum.Decode);
                await Task.WhenAll(rleDecodedPicture, lwzDecodedPicture);

                var rleDecodedPictureResult = await rleDecodedPicture;
                var lwzDecodedPictureResult = await lwzDecodedPicture;

                _rleLwzCompression.ShowLoader(AlgorithmEnum.Rle, false, OperationEnum.Decode);
                _rleLwzCompression.ShowRleDecoded(rleDecodedPictureResult);
                _rleLwzCompression.ShowLoader(AlgorithmEnum.Lwz, false, OperationEnum.Decode);
                _rleLwzCompression.ShowLwzDecoded(lwzDecodedPictureResult);
            }
            catch (AlgorithmsException e)
            {
                _rleLwzCompression.ShowError(e.Message);
                _rleLwzCompression.ShowLoader(AlgorithmEnum.Rle, false, OperationEnum.Decode);
                _rleLwzCompression.ShowLoader(AlgorithmEnum.Lwz, false, OperationEnum.Decode);
            }
        }

        async void _rleLwzCompression_ButtonEncodePicture()
        {
            try
            {
                if (_picture == null)
                {
                    _rleLwzCompression.ShowError(ErrorEnum.Encode.GetStringValue());
                    return;
                }

                if (_rleEncodedPicture != null || _lwzEncodedPicture != null)
                {
                    _rleLwzCompression.ShowError("Pictures are encoded.");
                    return;
                }


                var rleEncodedPicture = CreateTask(new Context(AlgorithmsFactory.CreateInstance<Rle>()),
                    OperationEnum.Encode, AlgorithmEnum.Rle);
                var lwzEncodedPicture = CreateTask(new Context(AlgorithmsFactory.CreateInstance<Lwz>()),
                    OperationEnum.Encode, AlgorithmEnum.Lwz);

                _rleLwzCompression.ShowLoader(AlgorithmEnum.Rle, true, OperationEnum.Encode);
                _rleLwzCompression.ShowLoader(AlgorithmEnum.Lwz, true, OperationEnum.Encode);
                await Task.WhenAll(rleEncodedPicture, lwzEncodedPicture);

                _rleEncodedPicture = await rleEncodedPicture;
                _lwzEncodedPicture = await lwzEncodedPicture;

                _rleLwzCompression.ShowLoader(AlgorithmEnum.Rle, false, OperationEnum.Encode);
                _rleLwzCompression.ShowRleEncoded(rleEncodedPicture.Result);
                _rleLwzCompression.ShowLoader(AlgorithmEnum.Lwz, false, OperationEnum.Encode);
                _rleLwzCompression.ShowLwzEncoded(lwzEncodedPicture.Result);
            }
            catch (AlgorithmsException e)
            {
                _rleLwzCompression.ShowError(e.Message);
                _rleLwzCompression.ShowLoader(AlgorithmEnum.Rle, false, OperationEnum.Encode);
                _rleLwzCompression.ShowLoader(AlgorithmEnum.Lwz, false, OperationEnum.Encode);
            }
        }

        void _rleLwzCompression_ButtonLoadPicture()
        {
            if (_picture != null)
            {
                _rleLwzCompression.ShowError(ErrorEnum.Load.GetStringValue());
                return;
            }

            try
            {
                var pathToPicture = _rleLwzCompression.LoadPicture();
                _picture = _rleLwzCompression.GetPictureInfo(pathToPicture);
                _rleLwzCompression.ShowPicture(_picture);
            }
            catch (PresenterException e)
            {
                _rleLwzCompression.ShowError(e.Message);
            }
        }

        private Task<Picture> CreateTask(Context context, OperationEnum operationEnum,AlgorithmEnum algorithmEnum)
        {
            try
            {
                return Task.Run(() =>
                {
                    Picture picture = new Picture();
                    if (operationEnum == OperationEnum.Encode)
                    {
                        picture = context.ExuceteEncode(_picture);
                    }

                    if (operationEnum == OperationEnum.Decode)
                    {
                        if (algorithmEnum == AlgorithmEnum.Rle)
                            picture = context.ExuceteDecode(_rleLwzCompression.GetEncodedPicture(AlgorithmEnum.Rle));
                        if (algorithmEnum == AlgorithmEnum.Lwz)
                            picture = context.ExuceteDecode(_rleLwzCompression.GetEncodedPicture(AlgorithmEnum.Lwz));
                    }
                    return picture;
                }, _token);
            }
            catch (AlgorithmsException e)
            {
                throw;
            }
        }
    }
}
