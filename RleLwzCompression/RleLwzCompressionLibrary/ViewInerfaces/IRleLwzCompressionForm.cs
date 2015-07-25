using System;
using RleLwzCompressionLibrary.Enums;
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
        void ShowRleEncoded(Picture picture);
        void ShowLwzEncoded(Picture picture);
        void ShowRleDecoded(Picture picture);
        void ShowLwzDecoded(Picture picture);
        void ShowLogView();
        Picture GetRleEncodedPicture();
        Picture GetLwzEncodedPicture();
        void CloseForm();
        void ClearSources();
        string LoadPicture();
        void ShowError(ErrorEnum error);
    }
}
