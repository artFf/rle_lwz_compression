using System;
using System.Collections.Generic;
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
        private readonly IRleLwzCompression _rleLwzCompression;
        private readonly IAlgorithmsCompression _algorithmsCompression;
        private Picture _picture;

        public CompressionPresenter(IRleLwzCompression rleLwzCompression,IAlgorithmsCompression algorithmsCompression)
        {
            _rleLwzCompression = rleLwzCompression;
            _algorithmsCompression = algorithmsCompression;

            _rleLwzCompression.ButtonLoadPicture += _rleLwzCompression_ButtonLoadPicture;
            _rleLwzCompression.ButtonEncodePicture += _rleLwzCompression_ButtonEncodePicture;
            _rleLwzCompression.ButtonDecodePicture += _rleLwzCompression_ButtonDecodePicture;
            _rleLwzCompression.ButtonCloseRleLwzCompressionForm+=_rleLwzCompression_ButtonCloseRleLwzCompressionForm;
            _rleLwzCompression.ButtonClearSources += _rleLwzCompression_ButtonClearSources;
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
            throw new NotImplementedException();
        }
    }
}
