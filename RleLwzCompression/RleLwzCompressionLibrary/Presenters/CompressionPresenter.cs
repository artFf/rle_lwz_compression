using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RleLwzCompressionLibrary.Algorithms.Interfaces;
using RleLwzCompressionLibrary.Models;
using RleLwzCompressionLibrary.ViewInerfaces;

namespace RleLwzCompressionLibrary.Presenters
{
    public class CompressionPresenter
    {
        private readonly IRleLwzCompressionForm _rleLwzCompression;
        private IAlgorithmsCompression _algorithmsCompression;
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
            throw new NotImplementedException();
        }

        void _rleLwzCompression_ButtonClearSources()
        {
            throw new NotImplementedException();
        }

        void _rleLwzCompression_ButtonCloseRleLwzCompressionForm()
        {
            throw new NotImplementedException();
        }

        void _rleLwzCompression_ButtonDecodePicture()
        {
            throw new NotImplementedException();
        }

        void _rleLwzCompression_ButtonEncodePicture()
        {
            throw new NotImplementedException();
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
    }
}
