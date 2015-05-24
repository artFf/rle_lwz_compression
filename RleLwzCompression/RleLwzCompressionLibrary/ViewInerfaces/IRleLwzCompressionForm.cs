using System;
using RleLwzCompressionLibrary.Models;

namespace RleLwzCompressionLibrary.ViewInerfaces
{
    public interface IRleLwzCompressionForm
    {
        event Action ButtonLoadPicture;
        event Action ButtonShowLogView;
        event Action ButtonCloseRleLwzCompressionForm;
        event Action ButtonEncodePicture;
        event Action ButtonDecodePicture;
        event Action ButtonClearSources;

        void ShowPicture(Picture picture);
        void CloseForm();
        void ClearSources();
        string LoadPicture();
    }
}
